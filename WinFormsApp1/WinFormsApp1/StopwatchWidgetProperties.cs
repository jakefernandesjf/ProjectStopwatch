namespace ProjectStopwatchApp
{
    public class StopwatchWidgetProperties
    {
        #region Constructors
        public StopwatchWidgetProperties()
        {
            Name = "";
            TimeElapsed = TimeSpan.Zero;
            IsEnabled = false;
        }

        public StopwatchWidgetProperties(string name, TimeSpan timeElapsed)
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
        /// Save properties from <paramref name="widget"/>.
        /// </summary>
        /// <param name="widget"></param>
        public void SaveFromWidget(StopwatchWidget widget)
        {
            Name = widget.GetProjectName();
            TimeElapsed = widget.GetTimeElapsed();
            IsEnabled = widget.IsEnabled;
        }
        #endregion


        #region Public Fields
        public string Name;
        public TimeSpan TimeElapsed;
        public bool IsEnabled;
        #endregion
    }
}
