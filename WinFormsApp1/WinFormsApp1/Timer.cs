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
            _startPoint = DateTime.Now;
            _timeElapsed = TimeSpan.Zero;
            _activeStatus = false;
        }

        /// <summary>
        /// Creates a <c>Timer</c> object with name <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Name of the <c>Timer</c></param>
        public Timer(string name) : this()
        {
            _name = name;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>Timer</c>.
        /// </summary>
        public void PauseTimer()
        {
            var nowDateTime = DateTime.Now;
            if (IsTimerActive())
            {
                _activeStatus = false;
                _timeElapsed += (nowDateTime - _startPoint);
            }
        }

        /// <summary>
        /// Starts the <c>Timer</c>.
        /// </summary>
        public void StartTimer()
        {
            var newStartPoint = DateTime.Now;
            if (!IsTimerActive())
            {
                _activeStatus = true;
                _startPoint = newStartPoint;
            }
        }

        /// <summary>
        /// Resets the <c>Timer</c> to 0.
        /// </summary>
        public void ResetTimer()
        {
            var newStartPoint = DateTime.Now;
            _activeStatus = false;
            
            _startPoint = newStartPoint;
            _timeElapsed = TimeSpan.Zero;           
        }

        /// <summary>
        /// Gets the time elapsed from the <c>Timer</c>.
        /// </summary>
        /// <returns>Time Elapsed <c>TimeSpan</c></returns>
        public TimeSpan GetTimeElapsed()
        {
            var nowDateTime = DateTime.Now;
            if (IsTimerActive())
            {
                return nowDateTime - _startPoint + _timeElapsed;
            }
            else
            {
                return _timeElapsed;
            }
        }

        /// <summary>
        /// Gets the status of the <c>Timer</c>.
        /// </summary>
        /// <returns><c>True</c> if the <c>Timer</c> is active, <c>False</c> if the <c>Timer</c> is inactive.</returns>
        public bool IsTimerActive()
        {
            return _activeStatus;
        }

        /// <summary>
        /// Adds <paramref name="time"/> to the <c>Timer</c>.
        /// </summary>
        /// <param name="time">Time to be added to the timer.</param>
        public void AddTime(TimeSpan time)
        {
            _timeElapsed += time;
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> to the <c>Timer</c>.
        /// </summary>
        /// <param name="time">Time to be subtracted from the timer.</param>
        public void SubtractTime(TimeSpan time)
        {
            TimeSpan newTimeElapsed = new[] { TimeSpan.Zero, _timeElapsed - time }.Max();
            if (newTimeElapsed == TimeSpan.Zero)
            {
                _startPoint = DateTime.Now;
            }
            _timeElapsed = newTimeElapsed;
        }

        /// <summary>
        /// Sets the name of the <c>Timer</c>.
        /// </summary>
        /// <param name="name">The name of the timer.</param>
        public void SetName(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets the name of the <c>Timer</c>.
        /// </summary>
        /// <returns>Name of the timer</returns>
        public string GetName()
        {
            return _name;
        }
        #endregion


        #region Private Fields
        private DateTime _startPoint;
        private TimeSpan _timeElapsed;
        private bool _activeStatus;
        private string _name = "";
        #endregion
    }
}
