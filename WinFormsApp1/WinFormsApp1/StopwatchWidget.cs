namespace ProjectStopwatchApp
{
    public class StopwatchWidget
    {
        #region Constructors
        public StopwatchWidget(Label timeElapsedLabel, StopwatchWidgetProperties properties)
        {
            _timeElapsedLabel = timeElapsedLabel;
            _projectNameLabel = new Label();
            _stopwatch = new MyStopwatch.Stopwatch(properties.Name);
            _isActive = false;
            _isEnabled = properties.IsEnabled;
            _stopwatch.AddTime(properties.TimeElapsed);
        }

        /// <summary>
        /// Creates a <c>StopwatchWidget</c> with TimeElapsed Label <paramref name="timeElapsedLabel"/> and Project Name Label <paramref name="projectNameLabel"/>
        /// </summary>
        /// <param name="timeElapsedLabel"></param>
        /// <param name="projectNameLabel"></param>
        public StopwatchWidget(Label timeElapsedLabel, Label projectNameLabel)
        {
            _timeElapsedLabel = timeElapsedLabel;
            _projectNameLabel = projectNameLabel;
            _stopwatch = new MyStopwatch.Stopwatch(projectNameLabel.Text);
            _isActive = false;
            _isEnabled = true;
        }

        /// <summary>
        /// Creates a <c>StopwatchWidget</c> with TimeElapsed Label <paramref name="timeElapsedLabel"/> and Project Name Label <paramref name="projectNameLabel"/>. Sets properties from <paramref name="properties"/>.
        /// </summary>
        /// <param name="timeElapsedLabel"></param>
        /// <param name="projectNameLabel"></param>
        /// <param name="properties"></param>
        public StopwatchWidget(Label timeElapsedLabel, Label projectNameLabel, StopwatchWidgetProperties properties)
        {
            _timeElapsedLabel = timeElapsedLabel;
            _projectNameLabel = projectNameLabel;
            _stopwatch = new MyStopwatch.Stopwatch();
            _isActive = false;

            SetProjectName(properties.Name);
            AddTime(properties.TimeElapsed);         
            _isEnabled = properties.IsEnabled;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Starts StopwatchWidget
        /// </summary>
        public virtual void Start()
        {
            _stopwatch.Start();
            _isActive = true;
        }

        /// <summary>
        /// Pauses StopwatchWidget
        /// </summary>
        public virtual void Pause()
        {
            _stopwatch.Pause();
            _isActive = false;
        }

        /// <summary>
        /// Enables StopwatchWidget
        /// </summary>
        public void Enable()
        {
            _isEnabled = true;
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Visible = true));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Visible = true));
        }

        /// <summary>
        /// Disables StopwatchWidget
        /// </summary>
        public void Disable()
        {
            _isEnabled = false;
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Visible = false));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Visible = false));
        }

        /// <summary>
        /// Resets StopwatchWidget
        /// </summary>
        public virtual void Reset()
        {
            _stopwatch.Reset();
            SetInactiveWidgetStyle();
            UpdateTimeElapsed();
        }

        /// <summary>
        /// Adds <paramref name="time"/> to stopwatch.
        /// </summary>
        /// <param name="time"></param>
        public void AddTime(TimeSpan time)
        {
            _stopwatch.AddTime(time);
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> from stopwatch.
        /// </summary>
        /// <param name="time"></param>
        public void SubtractTime(TimeSpan time)
        {
            _stopwatch.SubtractTime(time);
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
            _timeElapsedLabel.Text = _stopwatch.GetTimeElapsed().ToString(TIMESPAN_STRING_FORMAT);
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
        /// Gets the time elapsed of the stopwatch widget.
        /// </summary>
        /// <returns>Time elapsed</returns>
        public TimeSpan GetTimeElapsed()
        {
            return _stopwatch.GetTimeElapsed();
        }

        /// <summary>
        /// Get Active status of stopwatch widget.
        /// </summary>
        /// <returns></returns>
        public bool GetActiveStatus()
        {
            return _isActive;
        }

        /// <summary>
        /// Sets the stopwatch widget to the Active Style
        /// </summary>
        public virtual void SetActiveWidgetStyle()
        {
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Font = new Font(_timeElapsedLabel.Font, FontStyle.Bold)));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Font = new Font(_projectNameLabel.Font, FontStyle.Bold)));
        }

        /// <summary>
        /// Sets the stopwatch widget to the Inactive style.
        /// </summary>
        public virtual void SetInactiveWidgetStyle()
        {
            _timeElapsedLabel.Invoke(new MethodInvoker(() => _timeElapsedLabel.Font = new Font(_timeElapsedLabel.Font, FontStyle.Regular)));
            _projectNameLabel.Invoke(new MethodInvoker(() => _projectNameLabel.Font = new Font(_projectNameLabel.Font, FontStyle.Regular)));
        }

        /// <summary>
        /// Loads <paramref name="properties"/> to stopwatch widget.
        /// </summary>
        /// <param name="properties"></param>
        public void LoadProperties(StopwatchWidgetProperties properties)
        {
            SetProjectName(properties.Name);
            _isEnabled = properties.IsEnabled;
            _stopwatch.Reset();
            _stopwatch.AddTime(properties.TimeElapsed);

            if (!_isEnabled) { Disable(); }
            else { Enable(); }
        }
        #endregion


        #region Public Fields
        public bool IsEnabled { get { return _isEnabled; } }
        #endregion


        #region Private Fields
        private Label _timeElapsedLabel;
        private Label _projectNameLabel;
        private readonly MyStopwatch.Stopwatch _stopwatch;
        private bool _isActive;
        private bool _isEnabled;
        private const string TIMESPAN_STRING_FORMAT = @"hh\:mm\:ss";
        #endregion
    }

    public class TotalStopwatchWidget : StopwatchWidget
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>TotalStopwatchWidget</c> object.
        /// </summary>
        /// <param name="timeElapsedLabel"></param>
        /// <param name="subtract30Button"></param>
        /// <param name="subtract10Button"></param>
        /// <param name="add10Button"></param>
        /// <param name="add30Button"></param>
        /// <param name="pauseButton"></param>
        /// <param name="subWidgets"></param>
        public TotalStopwatchWidget(
            Label timeElapsedLabel, 
            Button subtract30Button, 
            Button subtract10Button,
            Button add10Button,
            Button add30Button,
            Button pauseButton,
            List<StopwatchWidget> subWidgets,
            StopwatchWidgetProperties widgetProperties) 
            :base(timeElapsedLabel, widgetProperties)
        {
            _subWidgets = subWidgets;
            _activeWidget = subWidgets.First();
            _subtract10Button = subtract10Button;
            _subtract30Button = subtract30Button;
            _add10Button = add10Button;
            _add30Button = add30Button;
            _pauseButton = pauseButton;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>TotalStopwatchWidget</c>.
        /// </summary>
        public override void Pause()
        {
            Thread TotalStopwatchWidgetThread = new(() => base.Pause());
            Thread ActiveSubWidgetThread = new(() => _activeWidget.Pause());

            TotalStopwatchWidgetThread.Start();
            ActiveSubWidgetThread.Start();

            GetActiveWidget().SetInactiveWidgetStyle();
            SetInactiveWidgetStyle();
        }

        /// <summary>
        /// Resets the <c>TotalStopwatchWidget</c> to 0 and all sub-stopwatch widgets.
        /// </summary>
        public override void Reset()
        {
            base.Reset();

            foreach(StopwatchWidget widget in _subWidgets)
            {
                widget.Reset();
            }

            UpdateTimeElapsed();
        }

        /// <summary>
        /// Adds the <paramref name="widget"/> to the <c>TotalStopwatchWidget</c>.
        /// </summary>
        /// <param name="widget"></param>
        public void AddWidget(StopwatchWidget widget)
        {
            _subWidgets.Add(widget);
        }

        /// <summary>
        /// Disables all sub-stopwatch widgets and clears the sub-timer widget list.
        /// </summary>
        public void DisableAllWidgets()
        {
            foreach  (var widget in _subWidgets)
            {
                widget.Disable();
            }
        }

        /// <summary>
        /// Gets the list of sub-stopwatch widgets fo the <c>TotalStopwatchWidget</c>.
        /// </summary>
        /// <returns></returns>
        public List<StopwatchWidget> GetAllSubWidgets()
        {
            return _subWidgets;
        }

        /// <summary>
        /// Sets the active sub-stopwatch widget to the <paramref name="widget"/> and starts the sub-stopwatch widget.
        /// </summary>
        /// <param name="widget"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetAndStartActiveSubWidget(StopwatchWidget widget)
        {
            StopwatchWidget lastStopwatchWidget = GetActiveWidget();
            if (lastStopwatchWidget != widget)
            {               
                _activeWidget = widget;

                Thread TotalStopwatchWidgetThread = new(() => Start());
                Thread StartActiveWidgetThread = new(() => _activeWidget.Start());
                Thread PauseLastWidgetThread = new(() => lastStopwatchWidget.Pause());

                TotalStopwatchWidgetThread.Start();
                StartActiveWidgetThread.Start();
                PauseLastWidgetThread.Start();

                UpdateTimeElapsed();
                lastStopwatchWidget.SetInactiveWidgetStyle();
            }
            else if (lastStopwatchWidget == widget && !GetActiveStatus())
            {
                Thread TotalStopwatchWidgetThread = new(() => Start());
                Thread StartActiveWidgetThread = new(() => _activeWidget.Start());

                TotalStopwatchWidgetThread.Start();
                StartActiveWidgetThread.Start();

                UpdateTimeElapsed();
            }
            else if (_subWidgets.Contains(widget) == false)
            {
                throw new ArgumentException($"SubWidgets does not contain {widget.GetProjectName()}");
            }
            
            GetActiveWidget().SetActiveWidgetStyle();
            SetActiveWidgetStyle();

            lastStopwatchWidget.UpdateTimeElapsed();
            UpdateTimeElapsed();
        }

        /// <summary>
        /// Gets the active sub-stopwatch widget of the <c>TotalStopwatchWidget</c>.
        /// </summary>
        /// <returns></returns>
        public ref StopwatchWidget GetActiveWidget()
        {
            return ref _activeWidget;
        }

        /// <summary>
        /// Adds <paramref name="time"/> to the active sub-stopwatch widget.
        /// </summary>
        /// <param name="time"></param>
        public void AddTimeToActiveWidget(TimeSpan time)
        {
            Thread TotalStopwatchWidgetThread = new(() => AddTime(time));
            Thread ActiveSubWidgetThread = new(() => _activeWidget.AddTime(time));

            TotalStopwatchWidgetThread.Start();
            ActiveSubWidgetThread.Start();

            UpdateTimeElapsed();
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> from the active sub-stopwatch widget.
        /// </summary>
        /// <param name="time"></param>
        public void SubtractTimeFromActiveWidget(TimeSpan time)
        {
            if (_activeWidget.GetTimeElapsed() > time)
            {
                Thread TotalStopwatchWidgetThread = new(() => SubtractTime(time));
                Thread ActiveSubWidgetThread = new(() => _activeWidget.SubtractTime(time));

                TotalStopwatchWidgetThread.Start();
                ActiveSubWidgetThread.Start();

                UpdateTimeElapsed();
            }
        }

        /// <summary>
        /// Sets the stopwatch widget to the Active Style
        /// </summary>
        public override void SetActiveWidgetStyle()
        {
            Label timeElapsedLabel = GetTimeElapasedLabel();
            timeElapsedLabel.Invoke(new MethodInvoker(() => timeElapsedLabel.Font = new Font(timeElapsedLabel.Font, FontStyle.Bold)));            
            SetButtonEnabledSetting(true);
        }

        /// <summary>
        /// Sets the stopwatch widget to the Inactive style.
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
            _activeWidget.UpdateTimeElapsed();
            base.UpdateTimeElapsed();
        }

        /// <summary>
        /// Updates all stopwatch widgets time elapsed label and disables/enables UI controls.
        /// </summary>
        public void UpdateAllWidgets()
        {
            foreach (var widget in _subWidgets)
            {
                widget.UpdateTimeElapsed();
                if (!widget.IsEnabled) { widget.Disable(); }
                else { widget.Enable(); }
            }
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
        private List<StopwatchWidget> _subWidgets;
        private StopwatchWidget _activeWidget;
        private readonly Button _subtract30Button;
        private readonly Button _subtract10Button;
        private readonly Button _add10Button;
        private readonly Button _add30Button;
        private readonly Button _pauseButton;
        #endregion
    }
}
