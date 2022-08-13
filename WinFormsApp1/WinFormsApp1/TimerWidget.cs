using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTimers;

namespace MyTimerWidgets
{
    internal class TimerWidget
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>TimerWidget</c> with TimeElapsed Label <paramref name="_timeElapsedLabel"/> and Project Name Label <paramref name="_projectNameLabel"/>
        /// </summary>
        /// <param name="_timeElapsedLabel"></param>
        /// <param name="_projectNameLabel"></param>
        public TimerWidget(Label _timeElapsedLabel, Label _projectNameLabel)
        {
            TimeElapsedLabel = _timeElapsedLabel;
            ProjectNameLabel = _projectNameLabel;
            Timer = new MyTimers.Timer(_projectNameLabel.Text);
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Starts TimerWidget
        /// </summary>
        public virtual void Start()
        {
            Timer.StartTimer();
            SetActiveWidgetStyle();
        }

        /// <summary>
        /// Pauses TimerWidget
        /// </summary>
        public virtual void Pause()
        {
            Timer.PauseTimer();
            SetInactiveWidgetStyle();
        }

        /// <summary>
        /// Enables TimerWidget
        /// </summary>
        public virtual void Enable()
        {
            //TODO
            //  enable visibility for labels
        }

        /// <summary>
        /// Disables TimerWidget
        /// </summary>
        public virtual void Disable()
        {
            //TODO
            //  disable visibility for labels
        }

        /// <summary>
        /// Resets TimerWidget
        /// </summary>
        public virtual void Reset()
        {
            Timer.ResetTimer();
        }

        /// <summary>
        /// Adds <paramref name="_time"/> to timer.
        /// </summary>
        /// <param name="_time"></param>
        public void AddTime(TimeSpan _time)
        {
            Timer.AddTime(_time);
        }

        /// <summary>
        /// Subtracts <paramref name="_time"/> from timer.
        /// </summary>
        /// <param name="_time"></param>
        public void SubtractTime(TimeSpan _time)
        {
            Timer.SubtractTime(_time);
        }

        /// <summary>
        /// Sets project name to <paramref name="_name"/>.
        /// </summary>
        /// <param name="_name"></param>
        public void SetProjectName(string _name)
        {
            ProjectNameLabel.Text = _name;
        }

        /// <summary>
        /// Gets the project name of the widget.
        /// </summary>
        /// <returns></returns>
        public string GetProjectName()
        {
            return ProjectNameLabel.Text;
        }

        /// <summary>
        /// Updates the time Elapsed.
        /// </summary>
        public void UpdateTimeElapsed()
        {
            TimeElapsedLabel.Text = Timer.GetTimeElapsed().ToString();
        }

        /// <summary>
        /// Gets the <c>Timer</c> of the widget.
        /// </summary>
        /// <returns></returns>
        public MyTimers.Timer GetTimer()
        {
            return Timer;
        }

        /// <summary>
        /// Sets the <c>Timer</c> of the widget.
        /// </summary>
        /// <param name="_timer"></param>
        public void SetTimer(MyTimers.Timer _timer)
        {
            Timer = _timer;
        }
        #endregion


        #region Private Methods
        private void SetActiveWidgetStyle()
        {
            //TODO
        }

        private void SetInactiveWidgetStyle()
        {
            //TODO
        }
        #endregion


        #region Fields
        private Label TimeElapsedLabel;
        private Label ProjectNameLabel;
        private MyTimers.Timer Timer;
        #endregion
    }

    internal class TotalTimerWidget : TimerWidget
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>TotalTimerWidget</c> object.
        /// </summary>
        /// <param name="_timeElapsedLabel"></param>
        /// <param name="_projectNameLabel"></param>
        /// <param name="_subTimerWidgets"></param>
        public TotalTimerWidget(Label _timeElapsedLabel, Label _projectNameLabel, List<TimerWidget> _subTimerWidgets) :base(_timeElapsedLabel, _projectNameLabel)
        {
            SubTimerWidgets = _subTimerWidgets;
            ActiveTimerWidget = _subTimerWidgets.First();
            SetActiveWidgetStyle();
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>TotalTimerWidget</c>.
        /// </summary>
        public override void Pause()
        {
            Thread TotalTimerWidgetThread = new(() => base.Pause());
            Thread ActiveSubTimerWidgetThread = new(() => PauseActiveTimerWidget());

            TotalTimerWidgetThread.Start();
            ActiveSubTimerWidgetThread.Start();
        }

        /// <summary>
        /// Resets the <c>TotalTimerWidget</c> to 0 and all sub-timer widgets.
        /// </summary>
        public override void Reset()
        {
            base.Reset();

            foreach(TimerWidget timerWidget in SubTimerWidgets)
            {
                timerWidget.Reset();
            }
        }

        /// <summary>
        /// Adds the <paramref name="timerWidget"/> to the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <param name="timerWidget"></param>
        public void AddTimerWidget(TimerWidget timerWidget)
        {
            SubTimerWidgets.Add(timerWidget);
        }

        /// <summary>
        /// Removes the <paramref name="timerWidget"/> from the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <param name="timerWidget"></param>
        /// <exception cref="ArgumentException"></exception>
        public void RemoveTimerWidget(TimerWidget timerWidget)
        {
            if (SubTimerWidgets.Contains(timerWidget) == false)
            {
                throw new ArgumentException($"SubTimerWidgets does not contain {timerWidget.GetProjectName()}");
            }
            else
            {
                timerWidget.Disable();
                SubTimerWidgets.Remove(timerWidget);
            }
        }

        /// <summary>
        /// Removes all sub-timer widgets and resets the <c>TotalTimerWidget</c>.
        /// </summary>
        public void RemoveAllTimerWidgets()
        {
            Thread TotalTimerWidgetThread = new(() => base.Reset());
            Thread SubTimerWidgetThread = new(() => DisableAllTimerWidgets());

            TotalTimerWidgetThread.Start();
            SubTimerWidgetThread.Start();
            SetInactiveWidgetStyle();
        }

        /// <summary>
        /// Gets the list of sub-timer widgets fo the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <returns></returns>
        public List<TimerWidget> GetAllTimerWIdgets()
        {
            return SubTimerWidgets;
        }

        /// <summary>
        /// Sets the active sub-timer widget to the <paramref name="timerWidget"/> and starts the sub-timer widget.
        /// </summary>
        /// <param name="timerWidget"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetAndStartActiveSubTimerWidget(TimerWidget timerWidget)
        {
            if (SubTimerWidgets.Contains(timerWidget) == false)
            {
                throw new ArgumentException($"SubTimerWidgets does not contain {timerWidget.GetProjectName()}");
            }
            else
            {
                TimerWidget lastTimerWidget = ActiveTimerWidget;
                ActiveTimerWidget = timerWidget;

                Thread StartActiveTimerWidgetThread = new(() => StartActiveTimerWidget());
                Thread PauseLastTimerWidgetThread = new(() => lastTimerWidget.Pause());

                StartActiveTimerWidgetThread.Start();
                PauseLastTimerWidgetThread.Start();
                SetActiveWidgetStyle();
            }
        }

        /// <summary>
        /// Gets the active sub-timer widget of the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <returns></returns>
        public TimerWidget GetActiveTimerWidget()
        {
            return ActiveTimerWidget;
        }

        /// <summary>
        /// Adds <paramref name="time"/> to the active sub-timer widget.
        /// </summary>
        /// <param name="time"></param>
        public void AddTimeToActiveTimerWidget(TimeSpan time)
        {
            Thread TotalTimerWidgetThread = new(() => base.AddTime(time));
            Thread ActiveSubTimerWidgetThread = new(() => ActiveTimerWidget.AddTime(time));

            TotalTimerWidgetThread.Start();
            ActiveSubTimerWidgetThread.Start();
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> from the active sub-timer widget.
        /// </summary>
        /// <param name="time"></param>
        public void SubtractTimeFromActiveTimerWidget(TimeSpan time)
        {
            Thread TotalTimerWidgetThread = new(() => base.SubtractTime(time));
            Thread ActiveSubTimerWidgetThread = new(() => ActiveTimerWidget.SubtractTime(time));

            TotalTimerWidgetThread.Start();
            ActiveSubTimerWidgetThread.Start();
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Starts the active sub-timer widget.
        /// </summary>
        private void StartActiveTimerWidget()
        {
            Thread TotalTimerWidgetThread = new(() => base.Start());
            Thread ActiveSubTimerWidgetThread = new(() => ActiveTimerWidget.Start());

            TotalTimerWidgetThread.Start();
            ActiveSubTimerWidgetThread.Start();
        }

        /// <summary>
        /// Pauses the active sub-timer widget.
        /// </summary>
        private void PauseActiveTimerWidget()
        {
            ActiveTimerWidget.Pause();
        }

        /// <summary>
        /// Disables all sub-timer widgets and clears the sub-timer widget list.
        /// </summary>
        private void DisableAllTimerWidgets()
        {
            foreach(TimerWidget timerWidget in SubTimerWidgets)
            {
                timerWidget.Disable();
                RemoveTimerWidget(timerWidget);
            }
        }

        private void SetActiveWidgetStyle()
        {
            //TODO
        }

        private void SetInactiveWidgetStyle()
        {
            //TODO
        }
        #endregion


        #region Fields
        private List<TimerWidget> SubTimerWidgets;
        private TimerWidget ActiveTimerWidget;
        #endregion
    }
}
