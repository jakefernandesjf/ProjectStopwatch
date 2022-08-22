namespace ProjectTimerApp
{
    public class TimerWidgetProperties
    {
        #region Constructors
        public TimerWidgetProperties()
        {
            Name = "";
            TimeElapsed = TimeSpan.Zero;
            IsEnabled = false;
        }

        public TimerWidgetProperties(string name, TimeSpan timeElapsed)
        {
            Name = name;
            TimeElapsed = timeElapsed;
            if (name != string.Empty)
            {
                IsEnabled = true;
            }
        }
        #endregion


        #region Public Methdods
        /// <summary>
        /// Save properties from <paramref name="timerWidget"/>.
        /// </summary>
        /// <param name="timerWidget"></param>
        public void SaveFromTimerWidget(TimerWidget timerWidget)
        {
            Name = timerWidget.GetProjectName();
            TimeElapsed = timerWidget.GetTimeElapsed();
            IsEnabled = timerWidget.IsEnabled;
        }
        #endregion


        #region Public Fields
        public string Name;
        public TimeSpan TimeElapsed;
        public bool IsEnabled;
        #endregion
    }
}
