namespace MyTimers
{
    internal class Timer
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>Timer</c> object.
        /// </summary>
        public Timer()
        {
            StartPoint = DateTime.Now;
            TimeElapsed = TimeSpan.Zero;
            SetActiveStatus(false);
        }

        /// <summary>
        /// Creates a <c>Timer</c> object with name <paramref name="_name"/>.
        /// </summary>
        /// <param name="_name">Name of the <c>Timer</c></param>
        public Timer(string _name) : this()
        {
            Name = _name;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>Timer</c>.
        /// </summary>
        public virtual void PauseTimer()
        {
            if (IsTimerActive())
            {
                // Do nothing
            }
            else
            {
                SetActiveStatus(false);
                TimeElapsed = TimeElapsed + (DateTime.Now - StartPoint);
            }
        }

        /// <summary>
        /// Starts the <c>Timer</c>.
        /// </summary>
        public void StartTimer()
        {
            var _newStartPoint = DateTime.Now;
            if (IsTimerActive())
            {
                // Do nothing
            }
            else
            {
                SetActiveStatus(true);
                StartPoint = _newStartPoint;
            }
        }

        /// <summary>
        /// Resets the <c>Timer</c> to 0.
        /// </summary>
        public virtual void ResetTimer()
        {
            StartPoint = DateTime.Now;
            TimeElapsed = TimeSpan.Zero;
            SetActiveStatus(false);
        }

        /// <summary>
        /// Gets the time elapsed from the <c>Timer</c>.
        /// </summary>
        /// <returns>Time Elapsed <c>TimeSpan</c></returns>
        public TimeSpan GetTimeElapsed()
        {
            if (IsTimerActive())
            {
                return DateTime.Now - StartPoint + TimeElapsed;
            }
            else
            {
                return TimeElapsed;
            }
        }

        /// <summary>
        /// Gets the status of the <c>Timer</c>.
        /// </summary>
        /// <returns><c>True</c> if the <c>Timer</c> is active, <c>False</c> if the <c>Timer</c> is inactive.</returns>
        public bool IsTimerActive()
        {
            return ActiveStatus;
        }

        /// <summary>
        /// Adds <paramref name="_time"/> to the <c>Timer</c>.
        /// </summary>
        /// <param name="_time">Time to be added to the timer.</param>
        public void AddTime(TimeSpan _time)
        {
            TimeElapsed = TimeElapsed + _time;
        }

        /// <summary>
        /// Subtracts <paramref name="_time"/> to the <c>Timer</c>.
        /// </summary>
        /// <param name="_time">Time to be subtracted from the timer.</param>
        public void SubtractTime(TimeSpan _time)
        {
            TimeElapsed = TimeElapsed - _time;
        }

        /// <summary>
        /// Sets the name of the <c>Timer</c>.
        /// </summary>
        /// <param name="_name">The name of the timer.</param>
        public void SetName(string _name)
        {
            Name = _name;
        }

        /// <summary>
        /// Gets the name of the <c>Timer</c>.
        /// </summary>
        /// <returns>Name of the timer</returns>
        public string GetName()
        {
            return Name;
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Sets the <param>ActiveStatus</param> to <paramref name="_status"/>.
        /// </summary>
        /// <param name="_status">Status of the <c>Timer</c></param>
        private void SetActiveStatus(bool _status)
        {
            ActiveStatus = _status;
        }
        #endregion


        #region Private Fields
        private DateTime StartPoint;
        private TimeSpan TimeElapsed;
        private bool ActiveStatus;
        private string Name = "";
        #endregion
    }


    internal class TotalTimer : Timer
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>TotalTimer</c> object with name <paramref name="_name"/>.
        /// </summary>
        /// <param name="_name">Name of the <c>TotalTimer</c></param>
        /// <param name="_subTimers">List of sub-timers for the <c>TotalTimer</c></param>
        public TotalTimer(string _name, List<Timer> _subTimers) : base(_name)
        {
            SubTimers = _subTimers;
            ActiveSubTimer = _subTimers.First();
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>TotalTimer</c>.
        /// </summary>
        public override void PauseTimer()
        {
            Thread TotalTimerThread = new(() => base.PauseTimer());
            Thread ActiveSubTimerThread = new(() => PauseActiveSubTimer());

            TotalTimerThread.Start();
            ActiveSubTimerThread.Start();
        }

        /// <summary>
        /// Resets the <c>TotalTimer</c> to 0 and all sub-timers.
        /// </summary>
        public override void ResetTimer()
        {
            base.ResetTimer();

            foreach (Timer _timer in SubTimers)
            {
                _timer.ResetTimer();
            }
        }

        /// <summary>
        /// Adds the <paramref name="_subTimer"/> to the <c>TotalTimer</c>.
        /// </summary>
        /// <param name="_subTimer">Timer to be added as a sub-timer to the <c>TotalTimer</c></param>
        public void AddSubTimer(Timer _subTimer)
        {
            SubTimers.Append(_subTimer);
        }

        /// <summary>
        /// Removes the sub-timer <paramref name="_subTimer"/> from the sub-timers list.
        /// </summary>
        /// <param name="_subTimer">Sub-timer to be removed from the <c>TotalTimer</c></param>
        public void RemoveSubTimer(Timer _subTimer)
        {
            if (SubTimers.Contains(_subTimer) == false)
            {
                throw new ArgumentException($"SubTimers does not contain {_subTimer.GetName()}");
            }
            else
            {
                SubTimers.Remove(_subTimer);
            }
        }

        /// <summary>
        /// Removes all sub-timers and resets <c>TotalTimer</c>
        /// </summary>
        public void RemoveAllSubTimers()
        {
            Thread TotalTimerThread = new(() => base.ResetTimer());
            Thread SubTimersThread = new(() => SubTimers.Clear());

            TotalTimerThread.Start();
            SubTimersThread.Start();
        }

        /// <summary>
        /// Gets the list of sub-timers of the <c>TotalTimer</c>.
        /// </summary>
        /// <returns>List of sub-timers of the <c>TotalTimer</c></returns>
        public List<Timer> GetSubTimers()
        {
            return SubTimers;
        }

        /// <summary>
        /// Sets the active sub-timer to the <paramref name="_subTimer"/> and starts that sub-timer.
        /// </summary>
        /// <param name="_subTimer">Sub-timer to start</param>
        public void SetAndStartActiveSubTimer(Timer _subTimer)
        {
            if (SubTimers.Contains(_subTimer) == false)
            {
                throw new ArgumentException($"SubTimers does not contain {_subTimer.GetName()}");
            }
            else
            {
                Timer lastTimer = ActiveSubTimer;
                ActiveSubTimer = _subTimer;

                Thread StartActiveSubTimerThread = new(() => StartActiveSubTimer());
                Thread PauseLastTimerThread = new(() => lastTimer.PauseTimer());

                StartActiveSubTimerThread.Start();
                PauseLastTimerThread.Start();
            }
        }

        /// <summary>
        /// Gets the active sub-timer of the <c>TotalTimer</c>.
        /// </summary>
        /// <returns>Active sub-timer of the <c>TotalTimer</c></returns>
        public Timer GetActiveSubTimer()
        {
            return ActiveSubTimer;
        }

        /// <summary>
        /// Adds <paramref name="_time"/> to active sub-timer.
        /// </summary>
        /// <param name="_time"></param>
        public void AddTimeToActiveSubTimer(TimeSpan _time)
        {
            ActiveSubTimer.AddTime(_time);
        }

        /// <summary>
        /// Subtracts <paramref name="_time"/> from active sub-timer.
        /// </summary>
        /// <param name="_time"></param>
        public void SubtractTimeFromActiveSubTimer(TimeSpan _time)
        {
            ActiveSubTimer.SubtractTime(_time);
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Starts the active sub-timer.
        /// </summary>
        private void StartActiveSubTimer()
        {
            Thread TotalTimerThread = new(() => StartTimer());
            Thread ActiveSubTimerThread = new(() => ActiveSubTimer.StartTimer());

            TotalTimerThread.Start();
            ActiveSubTimerThread.Start();
        }

        /// <summary>
        /// Pauses the active sub-timer.
        /// </summary>
        private void PauseActiveSubTimer()
        {
            ActiveSubTimer.PauseTimer();
        }
        #endregion


        #region Private Fields
        private List<Timer> SubTimers;
        private Timer ActiveSubTimer;
        #endregion
    }
}
