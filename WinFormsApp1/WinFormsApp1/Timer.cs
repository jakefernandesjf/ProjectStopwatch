using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Timer
    {
        #region Constructors and Destructor
        /// <summary>
        /// Creates a <c>Timer</c> object.
        /// </summary>
        public Timer()
        {
            // TODO
        }
        
        /// <summary>
        /// Creates a <c>Timer</c> object with name <paramref name="_name"/>.
        /// </summary>
        /// <param name="_name">Name of the <c>Timer</c></param>
        public Timer(string _name)
        {
            // TODO
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>Timer</c>.
        /// </summary>
        public void PauseTimer()
        {
            // TODO
        }
        
        /// <summary>
        /// Starts the <c>Timer</c>.
        /// </summary>
        public void StartTimer()
        {
            // TODO
        }
        
        /// <summary>
        /// Resets the <c>Timer</c> to 0.
        /// </summary>
        public void ResetTimer()
        {
            // TODO
        }
        
        /// <summary>
        /// Gets the time elapsed from the <c>Timer</c>.
        /// </summary>
        /// <returns>Time Elapsed <c>TimeSpan</c></returns>
        public TimeSpan GetTimeElapsed()
        {
            // TODO
            return TimeSpan.Zero;
        }

        /// <summary>
        /// Gets the status of the <c>Timer</c>.
        /// </summary>
        /// <returns><c>True</c> if the <c>Timer</c> is active, <c>False</c> if the <c>Timer</c> is inactive.</returns>
        public bool IsTimerActive()
        {
            // TODO
            return false;
        }
        
        /// <summary>
        /// Adds <paramref name="_time"/> to the <c>Timer</c>.
        /// </summary>
        /// <param name="_time">Time to be added to the timer.</param>
        public void AddTime(TimeSpan _time)
        {
            // TODO
        }

        /// <summary>
        /// Subtracts <paramref name="_time"/> to the <c>Timer</c>.
        /// </summary>
        /// <param name="_time">Time to be subtracted from the timer.</param>
        public void SubtractTime(TimeSpan _time)
        {
            // TODO
        }

        /// <summary>
        /// Sets the name of the <c>Timer</c>.
        /// </summary>
        /// <param name="_name">The name of the timer.</param>
        public void SetName(string _name)
        {
            // TODO
        }

        /// <summary>
        /// Gets the name of the <c>Timer</c>.
        /// </summary>
        /// <returns>Name of the timer</returns>
        public string GetName()
        {
            return string.Empty;
            // TODO
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Sets the <param>ActiveStatus</param> to <paramref name="_status"/>.
        /// </summary>
        /// <param name="_status">Status of the <c>Timer</c></param>
        private void SetActiveStatus(bool _status)
        {
            // TODO
        }
        #endregion


        #region Private Fields
        private DateTime StartPoint;
        private TimeSpan TimeElapsed;
        private bool ActiveStatus;
        #endregion
    }


    internal class TotalTimer : Timer
    {
        #region Constructors and Destructor
        /// <summary>
        /// Creates a <c>TotalTimer</c> object.
        /// </summary>
        public TotalTimer()
        {
            // TODO
        }

        /// <summary>
        /// Creates a <c>TotalTimer</c> object with name <paramref name="_name"/>.
        /// </summary>
        /// <param name="_name">Name of the <c>TotalTimer</c></param>
        /// <param name="_subTimers">List of sub-timers for the <c>TotalTimer</c></param>
        public TotalTimer(string _name, List<Timer> _subTimers)
        {
            // TODO
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Pauses the <c>TotalTimer</c>.
        /// </summary>
        public new void PauseTimer()
        {
            // TODO
        }

        /// <summary>
        /// Adds the <paramref name="_subTimer"/> to the <c>TotalTimer</c>.
        /// </summary>
        /// <param name="_subTimer">Timer to be added as a sub-timer to the <c>TotalTimer</c></param>
        public void AddSubTimer(Timer _subTimer)
        {
            // TODO
        }

        /// <summary>
        /// Removes the sub-timer at position <paramref name="_position"/> of the sub-timers list.
        /// </summary>
        /// <param name="_position">Position of the sub-timer to be removed from the <c>TotalTimer</c></param>
        public void RemoveSubTimer(int _position)
        {
            // TODO
        }

        /// <summary>
        /// Gets the list of sub-timers of the <c>TotalTimer</c>.
        /// </summary>
        /// <returns>List of sub-timers of the <c>TotalTimer</c></returns>
        public List<Timer> GetSubTimers()
        {
            return new List<Timer>();
            // TODO
        }

        /// <summary>
        /// Sets the active sub-timer to the sub-timer at position <paramref name="_position"/> and starts that sub-timer.
        /// </summary>
        /// <param name="_position">Position of sub-timer</param>
        public void SetAndStartActiveSubTimer(int _position)
        {
            // TODO
        }

        /// <summary>
        /// Gets the active sub-timer of the <c>TotalTimer</c>.
        /// </summary>
        /// <returns>Active sub-timer of the <c>TotalTimer</c></returns>
        public Timer GetActiveSubTimer()
        {
            return new Timer();
            // TODO
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Starts the active sub-timer.
        /// </summary>
        private void StartActiveSubTimer()
        {
            // TODO
        }

        /// <summary>
        /// Pauses the active sub-timer.
        /// </summary>
        private void PauseActiveSubTimer()
        {
            // TODO
        }
        #endregion


        #region Private Fields
        private List<Timer> SubTimers;      // TODO: Determine if List is the best container to use in C# for this
        private Timer ActiveSubTimer;
        #endregion
    }
}
