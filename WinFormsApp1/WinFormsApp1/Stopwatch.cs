namespace MyStopwatch
{
    internal class Stopwatch
    {
        #region Constructors
        /// <summary>
        /// Creates a <c>Stopwatch</c> object.
        /// </summary>
        public Stopwatch()
        {
            _startPoint = DateTime.Now;
            _timeElapsed = TimeSpan.Zero;
            _isActive = false;
        }

        /// <summary>
        /// Creates a <c>Stopwatch</c> object with name <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Name of the <c>Stopwatch</c></param>
        public Stopwatch(string name) : this()
        {
            _name = name;
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>Stopwatch</c>.
        /// </summary>
        public void Pause()
        {
            var nowDateTime = DateTime.Now;
            if (IsStopwatchActive())
            {
                _isActive = false;
                _timeElapsed += (nowDateTime - _startPoint);
            }
        }

        /// <summary>
        /// Starts the <c>Stopwatch</c>.
        /// </summary>
        public void Start()
        {
            var newStartPoint = DateTime.Now;
            if (!IsStopwatchActive())
            {
                _isActive = true;
                _startPoint = newStartPoint;
            }
        }

        /// <summary>
        /// Resets the <c>Stopwatch</c> to 0.
        /// </summary>
        public void Reset()
        {
            var newStartPoint = DateTime.Now;
            _isActive = false;
            
            _startPoint = newStartPoint;
            _timeElapsed = TimeSpan.Zero;           
        }

        /// <summary>
        /// Gets the time elapsed from the <c>Stopwatch</c>.
        /// </summary>
        /// <returns>Time Elapsed <c>TimeSpan</c></returns>
        public TimeSpan GetTimeElapsed()
        {
            var nowDateTime = DateTime.Now;
            if (IsStopwatchActive())
            {
                return nowDateTime - _startPoint + _timeElapsed;
            }
            else
            {
                return _timeElapsed;
            }
        }

        /// <summary>
        /// Gets the status of the <c>Stopwatch</c>.
        /// </summary>
        /// <returns><c>True</c> if the <c>Stopwatch</c> is active, <c>False</c> if the <c>Stopwatch</c> is inactive.</returns>
        public bool IsStopwatchActive()
        {
            return _isActive;
        }

        /// <summary>
        /// Adds <paramref name="time"/> to the <c>Stopwatch</c>.
        /// </summary>
        /// <param name="time">Time to be added to the stopwatch.</param>
        public void AddTime(TimeSpan time)
        {
            _timeElapsed += time;
        }

        /// <summary>
        /// Subtracts <paramref name="time"/> to the <c>Stopwatch</c>.
        /// </summary>
        /// <param name="time">Time to be subtracted from the stopwatch.</param>
        public void SubtractTime(TimeSpan time)
        {
            TimeSpan newTimeElapsed = new[] { TimeSpan.Zero, GetTimeElapsed() - time }.Max();
            _startPoint = DateTime.Now;
            _timeElapsed = newTimeElapsed;
        }

        /// <summary>
        /// Sets the name of the <c>Stopwatch</c>.
        /// </summary>
        /// <param name="name">The name of the stopwatch.</param>
        public void SetName(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets the name of the <c>Stopwatch</c>.
        /// </summary>
        /// <returns>Name of the stopwatch</returns>
        public string GetName()
        {
            return _name;
        }
        #endregion


        #region Private Fields
        private DateTime _startPoint;
        private TimeSpan _timeElapsed;
        private bool _isActive;
        private string _name = "";
        #endregion
    }
}
