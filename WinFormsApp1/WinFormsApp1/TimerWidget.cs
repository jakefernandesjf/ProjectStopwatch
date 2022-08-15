using MyTimers;

namespace ProjectTimerApp
{
    internal class TimerWidget
    {
        #region Constructors
        public TimerWidget(Label _timeElapsedLabel)
        {
            TimeElapsedLabel = _timeElapsedLabel;
            ProjectNameLabel = new Label();
            Timer = new MyTimers.Timer("Timer");
            ActiveStatus = false;
        }

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
            ActiveStatus = false;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Starts TimerWidget
        /// </summary>
        public virtual void Start()
        {
            Timer.StartTimer();
            ActiveStatus = true;
        }

        /// <summary>
        /// Pauses TimerWidget
        /// </summary>
        public virtual void Pause()
        {
            Timer.PauseTimer();
            ActiveStatus = false;
        }

        /// <summary>
        /// Enables TimerWidget
        /// </summary>
        public virtual void Enable()
        {
            TimeElapsedLabel.Invoke(new Action(() => TimeElapsedLabel.Visible = true));
            ProjectNameLabel.Invoke(new Action(() => ProjectNameLabel.Visible = true));
        }

        /// <summary>
        /// Disables TimerWidget
        /// </summary>
        public virtual void Disable()
        {
            TimeElapsedLabel.Invoke(new Action(() => TimeElapsedLabel.Visible = false));
            ProjectNameLabel.Invoke(new Action(() => ProjectNameLabel.Visible = false));
            Reset();
        }

        /// <summary>
        /// Resets TimerWidget
        /// </summary>
        public virtual void Reset()
        {
            Timer.ResetTimer();
            SetInactiveWidgetStyle();
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
            TimeElapsedLabel.Text = Timer.GetTimeElapsed().ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Gets the Time elapsed label.
        /// </summary>
        /// <returns></returns>
        public ref Label GetTimeElapasedLabel()
        {
            return ref TimeElapsedLabel;
        }

        /// <summary>
        /// Get Active status of timer widget.
        /// </summary>
        /// <returns></returns>
        public bool GetActiveStatus()
        {
            return ActiveStatus;
        }

        /// <summary>
        /// Sets the timer widget to the Active Style
        /// </summary>
        public virtual void SetActiveWidgetStyle()
        {
            TimeElapsedLabel.Invoke(new MethodInvoker(() => TimeElapsedLabel.Font = new Font(TimeElapsedLabel.Font, FontStyle.Bold)));
            ProjectNameLabel.Invoke(new MethodInvoker(() => ProjectNameLabel.Font = new Font(ProjectNameLabel.Font, FontStyle.Bold)));
        }

        /// <summary>
        /// Sets the timer widget to the Inactive style.
        /// </summary>
        public virtual void SetInactiveWidgetStyle()
        {
            TimeElapsedLabel.Invoke(new MethodInvoker(() => TimeElapsedLabel.Font = new Font(TimeElapsedLabel.Font, FontStyle.Regular)));
            ProjectNameLabel.Invoke(new MethodInvoker(() => ProjectNameLabel.Font = new Font(ProjectNameLabel.Font, FontStyle.Regular)));
        }
        #endregion


        #region Fields
        private Label TimeElapsedLabel;
        private Label ProjectNameLabel;
        private MyTimers.Timer Timer;
        private bool ActiveStatus;
        #endregion
    }

    internal class TotalTimerWidget : TimerWidget
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>TotalTimerWidget</c> object.
        /// </summary>
        /// <param name="_timeElapsedLabel"></param>
        /// <param name="subtract30Button"></param>
        /// <param name="subtract10Button"></param>
        /// <param name="add10Button"></param>
        /// <param name="add30Button"></param>
        /// <param name="pauseButton"></param>
        /// <param name="_subTimerWidgets"></param>
        public TotalTimerWidget(
            Label _timeElapsedLabel, 
            Button subtract30Button, 
            Button subtract10Button,
            Button add10Button,
            Button add30Button,
            Button pauseButton,
            List<TimerWidget> _subTimerWidgets) 
            :base(_timeElapsedLabel)
        {
            SubTimerWidgets = _subTimerWidgets;
            ActiveTimerWidget = _subTimerWidgets.First();
            Subtract10Button = subtract10Button;
            Subtract30Button = subtract30Button;
            Add10Button = add10Button;
            Add30Button = add30Button;
            PauseButton = pauseButton;
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

            GetActiveTimerWidget().SetInactiveWidgetStyle();
            SetInactiveWidgetStyle();
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
        public List<TimerWidget> GetAllTimerWidgets()
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
            else if (GetActiveTimerWidget() == timerWidget)
            {
                StartActiveTimerWidget();
            }
            else
            {
                TimerWidget lastTimerWidget = GetActiveTimerWidget();
                ActiveTimerWidget = timerWidget;

                Thread StartActiveTimerWidgetThread = new(() => StartActiveTimerWidget());
                Thread PauseLastTimerWidgetThread = new(() => lastTimerWidget.Pause());

                StartActiveTimerWidgetThread.Start();
                PauseLastTimerWidgetThread.Start();

                lastTimerWidget.SetInactiveWidgetStyle();
            }
            GetActiveTimerWidget().SetActiveWidgetStyle();
            SetActiveWidgetStyle();
        }

        /// <summary>
        /// Gets the active sub-timer widget of the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <returns></returns>
        public ref TimerWidget GetActiveTimerWidget()
        {
            return ref ActiveTimerWidget;
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

        /// <summary>
        /// Sets the timer widget to the Active Style
        /// </summary>
        public override void SetActiveWidgetStyle()
        {
            Label timeElapsedLabel = GetTimeElapasedLabel();
            timeElapsedLabel.Invoke(new MethodInvoker(() => timeElapsedLabel.Font = new Font(timeElapsedLabel.Font, FontStyle.Bold)));
            
            SetButtonEnabledSetting(true);
        }

        /// <summary>
        /// Sets the timer widget to the Inactive style.
        /// </summary>
        public override void SetInactiveWidgetStyle()
        {
            Label timeElapsedLabel = GetTimeElapasedLabel();
            timeElapsedLabel.Invoke(new MethodInvoker(() => timeElapsedLabel.Font = new Font(timeElapsedLabel.Font, FontStyle.Regular)));
            SetButtonEnabledSetting(false);
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

        /// <summary>
        /// Sets all time-modification buttons to enabled if <paramref name="setting"/> is true, disabled otherwise.
        /// </summary>
        /// <param name="setting"></param>
        private void SetButtonEnabledSetting(bool setting)
        {
            List<Button> modifyTimeButtons = new List<Button>
            {
                Subtract10Button,
                Subtract30Button,
                Add10Button,
                Add30Button,
                PauseButton,
            };
            foreach (Button button in modifyTimeButtons)
            {
                button.Invoke(new MethodInvoker(() => button.Enabled = setting));
            }
        }
        #endregion


        #region Fields
        private List<TimerWidget> SubTimerWidgets;
        private TimerWidget ActiveTimerWidget;
        private Button Subtract30Button;
        private Button Subtract10Button;
        private Button Add10Button;
        private Button Add30Button;
        private Button PauseButton;
        #endregion
    }
}
