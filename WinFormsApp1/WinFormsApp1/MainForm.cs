using AddProjectsForm;
using MyTimerWidgets;

namespace MainForm
{
    public partial class ProjectTimer : Form
    {
        public ProjectTimer()
        {
            InitializeComponent();           

            Project1 = new(Project1_TimeElapsed_Label, Project1_Name_Label);
            Project2 = new(Project2_TimeElapsed_Label, Project2_Name_Label);
            Project3 = new(Project3_TimeElapsed_Label, Project3_Name_Label);
            Project4 = new(Project4_TimeElapsed_Label, Project4_Name_Label);
            Project5 = new(Project5_TimeElapsed_Label, Project5_Name_Label);
            Project6 = new(Project6_TimeElapsed_Label, Project6_Name_Label);
            Project7 = new(Project7_TimeElapsed_Label, Project7_Name_Label);
            Project8 = new(Project8_TimeElapsed_Label, Project8_Name_Label);

            SubTimerWidgets = new List<TimerWidget>
            {
                Project1,
                Project2,
                Project3,
                Project4,
                Project5,
                Project6,
                Project7,
                Project8,
            };

            TotalTimerWidget = new TotalTimerWidget
            (
                TotalTimerTimeElapsedLabel,
                Subtract30_Button,
                Subtract10_Button,
                Add10_Button,
                Add30_Button,
                TotalTimerPauseButton,
                SubTimerWidgets
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalTimerWidget.SetInactiveWidgetStyle();
        }

        #region ToolStrip Menu
        private void AddProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProjects addProjects = new();
            addProjects.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region TotalTimer
        private void TotalTimerPause_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.Pause();
        }
        #endregion


        #region ActiveTimer Buttons
        private void Subtract30_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SubtractTimeFromActiveTimerWidget(TimeSpan.FromMinutes(30));
        }

        private void Subtract10_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SubtractTimeFromActiveTimerWidget(TimeSpan.FromMinutes(10));
        }

        private void Add10_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.AddTimeToActiveTimerWidget(TimeSpan.FromMinutes(10));
        }

        private void Add30_Button_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.AddTimeToActiveTimerWidget(TimeSpan.FromMinutes(30));
        }
        #endregion


        #region SubTimers
        private void Project1_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project1);
        }

        private void Project2_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project2);
        }

        private void Project3_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project3);
        }

        private void Project4_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project4);
        }

        private void Project5_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project5);
        }

        private void Project6_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project6);
        }

        private void Project7_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project7);
        }

        private void Project8_Click(object sender, EventArgs e)
        {
            TotalTimerWidget.SetAndStartActiveSubTimerWidget(Project8);
        }
        #endregion SubTimers


        #region Fields
        private List<TimerWidget> SubTimerWidgets;
        private TotalTimerWidget TotalTimerWidget;
        private TimerWidget Project1;
        private TimerWidget Project2;
        private TimerWidget Project3;
        private TimerWidget Project4;
        private TimerWidget Project5;
        private TimerWidget Project6;
        private TimerWidget Project7;
        private TimerWidget Project8;
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<TimerWidget> widgets = TotalTimerWidget.GetAllTimerWidgets();
            widgets.Add(TotalTimerWidget);
            foreach (TimerWidget widget in widgets)
            {
                var temp = widget;
                Invoke(new Action(() => widget.UpdateTimeElapsed()));
            }
        }
    }
}