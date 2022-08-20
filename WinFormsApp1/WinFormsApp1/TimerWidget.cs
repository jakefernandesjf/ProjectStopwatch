using MyTimers;

namespace ProjectTimerApp
{
    public class TimerWidget
    {
        #region Constructors
        public TimerWidget(Label timeElapsedLabel)
        {
            _timeElapsedLabel = timeElapsedLabel;
            _projectNameLabel = new Label();
            _timer = new MyTimers.Timer("Timer");
            _activeStatus = false;
        }

        /// <summary>
        /// Creates a <c>TimerWidget</c> with TimeElapsed Label <paramref name="timeElapsedLabel"/> and Project Name Label <paramref name="projectNameLabel"/>
        /// </summary>
        /// <param name="timeElapsedLabel"></param>
        /// <param name="projectNameLabel"></param>
        public TimerWidget(Label timeElapsedLabel, Label projectNameLabel)
        {
            _timeElapsedLabel = timeElapsedLabel;
            _projectNameLabel = projectNameLabel;
            _timer = new MyTimers.Timer(projectNameLabel.Text);
            _activeStatus = false;
            _enabledStatus = true;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Starts TimerWidget
        /// </summary>
        public virtual void Start()
        {
            _timer.StartTimer();
            _activeStatus = true;
        }

        /// <summary>
        /// Pauses TimerWidget
        /// </summary>
        public virtual void Pause()
        {
            _timer.PauseTimer();
            _activeStatus = false;
        }

        /// <summary>
        /// Enables TimerWidget
        /// </summary>
        public void Enable()
        {
            _enabledStatus = true;
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Visible = true));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Visible = true));
        }

        /// <summary>
        /// Disables TimerWidget
        /// </summary>
        public void Disable()
        {
            _enabledStatus = false;
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Visible = false));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Visible = false));
        }

        /// <summary>
        /// Resets TimerWidget
        /// </summary>
        public virtual void Reset()
        {
            _timer.ResetTimer();
            SetInactiveWidgetStyle();
        }

        /// <summary>
        /// Adds <paramref name="time"/> to timer.
        /// </summary>
        /// <param name="time"></param>
        public void AddTime(TimeSpan time)
        {
            _timer.AddTime(time);
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> from timer.
        /// </summary>
        /// <param name="time"></param>
        public void SubtractTime(TimeSpan time)
        {
            _timer.SubtractTime(time);
        }

        /// <summary>
        /// Sets project name to <paramref name="name"/>.
        /// </summary>
        /// <param name="name"></param>
        public void SetProjectName(string name)
        {
            _projectNameLabel.Text = name;
        }

        /// <summary>
        /// Gets the project name of the widget.
        /// </summary>
        /// <returns></returns>
        public string GetProjectName()
        {
            return _projectNameLabel.Text;
        }

        /// <summary>
        /// Updates the time Elapsed.
        /// </summary>
        public virtual void UpdateTimeElapsed()
        {
            _timeElapsedLabel.Text = _timer.GetTimeElapsed().ToString(TIMESPAN_STRING_FORMAT);
        }

        /// <summary>
        /// Gets the Time elapsed label.
        /// </summary>
        /// <returns></returns>
        public ref Label GetTimeElapasedLabel()
        {
            return ref _timeElapsedLabel;
        }

        /// <summary>
        /// Get Active status of timer widget.
        /// </summary>
        /// <returns></returns>
        public bool GetActiveStatus()
        {
            return _activeStatus;
        }

        /// <summary>
        /// Sets the timer widget to the Active Style
        /// </summary>
        public virtual void SetActiveWidgetStyle()
        {
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Font = new Font(_timeElapsedLabel.Font, FontStyle.Bold)));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Font = new Font(_projectNameLabel.Font, FontStyle.Bold)));
        }

        /// <summary>
        /// Sets the timer widget to the Inactive style.
        /// </summary>
        public virtual void SetInactiveWidgetStyle()
        {
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Font = new Font(_timeElapsedLabel.Font, FontStyle.Regular)));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Font = new Font(_projectNameLabel.Font, FontStyle.Regular)));
        }
        #endregion


        #region Public Fields
        public bool EnabledStatus { get { return _enabledStatus; } }
        #endregion


        #region Private Fields
        private Label _timeElapsedLabel;
        private Label _projectNameLabel;
        private readonly MyTimers.Timer _timer;
        private bool _activeStatus;
        private bool _enabledStatus;
        private const string TIMESPAN_STRING_FORMAT = @"hh\:mm\:ss";
        #endregion
    }

    public class TotalTimerWidget : TimerWidget
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>TotalTimerWidget</c> object.
        /// </summary>
        /// <param name="timeElapsedLabel"></param>
        /// <param name="subtract30Button"></param>
        /// <param name="subtract10Button"></param>
        /// <param name="add10Button"></param>
        /// <param name="add30Button"></param>
        /// <param name="pauseButton"></param>
        /// <param name="subTimerWidgets"></param>
        public TotalTimerWidget(
            Label timeElapsedLabel, 
            Button subtract30Button, 
            Button subtract10Button,
            Button add10Button,
            Button add30Button,
            Button pauseButton,
            List<TimerWidget> subTimerWidgets) 
            :base(timeElapsedLabel)
        {
            _subTimerWidgets = subTimerWidgets;
            _activeTimerWidget = subTimerWidgets.First();
            _subtract10Button = subtract10Button;
            _subtract30Button = subtract30Button;
            _add10Button = add10Button;
            _add30Button = add30Button;
            _pauseButton = pauseButton;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>TotalTimerWidget</c>.
        /// </summary>
        public override void Pause()
        {
            Thread TotalTimerWidgetThread = new(() => base.Pause());
            Thread ActiveSubTimerWidgetThread = new(() => _activeTimerWidget.Pause());

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

            foreach(TimerWidget timerWidget in _subTimerWidgets)
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
            _subTimerWidgets.Add(timerWidget);
        }

        /// <summary>
        /// Disables all sub-timer widgets and clears the sub-timer widget list.
        /// </summary>
        public void DisableAllTimerWidgets()
        {
            List<TimerWidget> list = GetAllTimerWidgets();
            for (int i = 0; i < list.Count; i++)
            {
                TimerWidget timerWidget = list[i];
                timerWidget.Disable();
            }
        }

        /// <summary>
        /// Gets the list of sub-timer widgets fo the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <returns></returns>
        public List<TimerWidget> GetAllTimerWidgets()
        {
            return _subTimerWidgets;
        }

        /// <summary>
        /// Sets the active sub-timer widget to the <paramref name="timerWidget"/> and starts the sub-timer widget.
        /// </summary>
        /// <param name="timerWidget"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetAndStartActiveSubTimerWidget(TimerWidget timerWidget)
        {
            TimerWidget lastTimerWidget = GetActiveTimerWidget();
            if (lastTimerWidget != timerWidget)
            {               
                _activeTimerWidget = timerWidget;

                Thread TotalTimerWidgetThread = new(() => Start());
                Thread StartActiveTimerWidgetThread = new(() => _activeTimerWidget.Start());
                Thread PauseLastTimerWidgetThread = new(() => lastTimerWidget.Pause());

                TotalTimerWidgetThread.Start();
                StartActiveTimerWidgetThread.Start();
                PauseLastTimerWidgetThread.Start();

                UpdateTimeElapsed();
                lastTimerWidget.SetInactiveWidgetStyle();
            }
            else if (lastTimerWidget == timerWidget && !GetActiveStatus())
            {
                Thread TotalTimerWidgetThread = new(() => Start());
                Thread StartActiveTimerWidgetThread = new(() => _activeTimerWidget.Start());

                TotalTimerWidgetThread.Start();
                StartActiveTimerWidgetThread.Start();

                UpdateTimeElapsed();
            }
            else if (_subTimerWidgets.Contains(timerWidget) == false)
            {
                throw new ArgumentException($"SubTimerWidgets does not contain {timerWidget.GetProjectName()}");
            }
            
            GetActiveTimerWidget().SetActiveWidgetStyle();
            SetActiveWidgetStyle();

            lastTimerWidget.UpdateTimeElapsed();
            UpdateTimeElapsed();
        }

        /// <summary>
        /// Gets the active sub-timer widget of the <c>TotalTimerWidget</c>.
        /// </summary>
        /// <returns></returns>
        public ref TimerWidget GetActiveTimerWidget()
        {
            return ref _activeTimerWidget;
        }

        /// <summary>
        /// Adds <paramref name="time"/> to the active sub-timer widget.
        /// </summary>
        /// <param name="time"></param>
        public void AddTimeToActiveTimerWidget(TimeSpan time)
        {
            Thread TotalTimerWidgetThread = new(() => AddTime(time));
            Thread ActiveSubTimerWidgetThread = new(() => _activeTimerWidget.AddTime(time));

            TotalTimerWidgetThread.Start();
            ActiveSubTimerWidgetThread.Start();

            UpdateTimeElapsed();
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> from the active sub-timer widget.
        /// </summary>
        /// <param name="time"></param>
        public void SubtractTimeFromActiveTimerWidget(TimeSpan time)
        {
            Thread TotalTimerWidgetThread = new(() => SubtractTime(time));
            Thread ActiveSubTimerWidgetThread = new(() => _activeTimerWidget.SubtractTime(time));

            TotalTimerWidgetThread.Start();
            ActiveSubTimerWidgetThread.Start();

            UpdateTimeElapsed();
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

        /// <summary>
        /// Updates the time Elapsed.
        /// </summary>
        public override void UpdateTimeElapsed()
        {
            _activeTimerWidget.UpdateTimeElapsed();
            base.UpdateTimeElapsed();
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Sets all time-modification buttons to enabled if <paramref name="setting"/> is true, disabled otherwise.
        /// </summary>
        /// <param name="setting"></param>
        private void SetButtonEnabledSetting(bool setting)
        {
            List<Button> modifyTimeButtons = new()
            {
                _subtract10Button,
                _subtract30Button,
                _add10Button,
                _add30Button,
                _pauseButton,
            };
            foreach (Button button in modifyTimeButtons)
            {
                button.Invoke(new MethodInvoker(() => button.Enabled = setting));
            }
        }
        #endregion


        #region Fields
        private List<TimerWidget> _subTimerWidgets;
        private TimerWidget _activeTimerWidget;
        private readonly Button _subtract30Button;
        private readonly Button _subtract10Button;
        private readonly Button _add10Button;
        private readonly Button _add30Button;
        private readonly Button _pauseButton;
        #endregion
    }
}
