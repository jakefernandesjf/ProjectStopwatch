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
        public void Start()
        {
            //TODO
        }

        public void Pause()
        {
            //TODO
        }

        public void Enable()
        {
            //TODO
        }

        public void Disable()
        {
            //TODO
        }

        public void Reset()
        {
            //TODO
        }

        public void AddTime(TimeSpan _time)
        {
            Timer.AddTime(_time);
        }

        public void SubtractTime(TimeSpan _time)
        {
            Timer.SubtractTime(_time);
        }

        public void SetProjectName(string _name)
        {
            ProjectNameLabel.Text = _name;
        }

        public string GetProjectName()
        {
            return ProjectNameLabel.Text;
        }
        #endregion


        #region Private Methods

        #endregion


        #region Fields
        private Label TimeElapsedLabel;
        private Label ProjectNameLabel;
        private MyTimers.Timer Timer;
        #endregion
    }
}
