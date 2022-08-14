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
                SetActiveStatus(false);
                TimeElapsed = TimeElapsed + (DateTime.Now - StartPoint);
            }
            else
            {
                // Do nothing
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
}
