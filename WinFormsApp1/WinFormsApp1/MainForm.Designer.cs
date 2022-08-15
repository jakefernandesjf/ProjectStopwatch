namespace ProjectTimerApp
{
    partial class ProjectTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TotalTimerTimeElapsedLabel = new System.Windows.Forms.Label();
            this.TotalTimerPauseButton = new System.Windows.Forms.Button();
            this.Project1_Name_Label = new System.Windows.Forms.Label();
            this.Project1_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project2_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project2_Name_Label = new System.Windows.Forms.Label();
            this.Project4_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project4_Name_Label = new System.Windows.Forms.Label();
            this.Project3_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project3_Name_Label = new System.Windows.Forms.Label();
            this.Project6_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project6_Name_Label = new System.Windows.Forms.Label();
            this.Project5_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project5_Name_Label = new System.Windows.Forms.Label();
            this.Project8_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project8_Name_Label = new System.Windows.Forms.Label();
            this.Project7_TimeElapsed_Label = new System.Windows.Forms.Label();
            this.Project7_Name_Label = new System.Windows.Forms.Label();
            this.Subtract30_Button = new System.Windows.Forms.Button();
            this.Subtract10_Button = new System.Windows.Forms.Button();
            this.Add10_Button = new System.Windows.Forms.Button();
            this.Add30_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProjectsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // AddProjectsToolStripMenuItem
            // 
            this.AddProjectsToolStripMenuItem.Name = "AddProjectsToolStripMenuItem";
            this.AddProjectsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.AddProjectsToolStripMenuItem.Text = "Add Projects";
            this.AddProjectsToolStripMenuItem.Click += new System.EventHandler(this.AddProjectsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TotalTimerTimeElapsedLabel
            // 
            this.TotalTimerTimeElapsedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalTimerTimeElapsedLabel.AutoSize = true;
            this.TotalTimerTimeElapsedLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTimerTimeElapsedLabel.Location = new System.Drawing.Point(10, 32);
            this.TotalTimerTimeElapsedLabel.Name = "TotalTimerTimeElapsedLabel";
            this.TotalTimerTimeElapsedLabel.Size = new System.Drawing.Size(222, 65);
            this.TotalTimerTimeElapsedLabel.TabIndex = 2;
            this.TotalTimerTimeElapsedLabel.Text = "00:00:00";
            this.TotalTimerTimeElapsedLabel.Click += new System.EventHandler(this.TotalTimerPause_Click);
            // 
            // TotalTimerPauseButton
            // 
            this.TotalTimerPauseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalTimerPauseButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TotalTimerPauseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalTimerPauseButton.Location = new System.Drawing.Point(259, 32);
            this.TotalTimerPauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalTimerPauseButton.Name = "TotalTimerPauseButton";
            this.TotalTimerPauseButton.Size = new System.Drawing.Size(243, 61);
            this.TotalTimerPauseButton.TabIndex = 3;
            this.TotalTimerPauseButton.Text = "Pause";
            this.TotalTimerPauseButton.UseVisualStyleBackColor = false;
            this.TotalTimerPauseButton.Click += new System.EventHandler(this.TotalTimerPause_Click);
            // 
            // Project1_Name_Label
            // 
            this.Project1_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project1_Name_Label.AutoSize = true;
            this.Project1_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project1_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project1_Name_Label.Location = new System.Drawing.Point(258, 158);
            this.Project1_Name_Label.Name = "Project1_Name_Label";
            this.Project1_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project1_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project1_Name_Label.TabIndex = 4;
            this.Project1_Name_Label.Text = "Project 1";
            this.Project1_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project1_Name_Label.Click += new System.EventHandler(this.Project1_Click);
            // 
            // Project1_TimeElapsed_Label
            // 
            this.Project1_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project1_TimeElapsed_Label.AutoSize = true;
            this.Project1_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project1_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project1_TimeElapsed_Label.Location = new System.Drawing.Point(13, 158);
            this.Project1_TimeElapsed_Label.Name = "Project1_TimeElapsed_Label";
            this.Project1_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project1_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project1_TimeElapsed_Label.TabIndex = 5;
            this.Project1_TimeElapsed_Label.Text = "00:00:00";
            this.Project1_TimeElapsed_Label.Click += new System.EventHandler(this.Project1_Click);
            // 
            // Project2_TimeElapsed_Label
            // 
            this.Project2_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project2_TimeElapsed_Label.AutoSize = true;
            this.Project2_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project2_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project2_TimeElapsed_Label.Location = new System.Drawing.Point(14, 207);
            this.Project2_TimeElapsed_Label.Name = "Project2_TimeElapsed_Label";
            this.Project2_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project2_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project2_TimeElapsed_Label.TabIndex = 11;
            this.Project2_TimeElapsed_Label.Text = "00:00:00";
            this.Project2_TimeElapsed_Label.Click += new System.EventHandler(this.Project2_Click);
            // 
            // Project2_Name_Label
            // 
            this.Project2_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project2_Name_Label.AutoSize = true;
            this.Project2_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project2_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project2_Name_Label.Location = new System.Drawing.Point(258, 207);
            this.Project2_Name_Label.Name = "Project2_Name_Label";
            this.Project2_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project2_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project2_Name_Label.TabIndex = 10;
            this.Project2_Name_Label.Text = "Project 2";
            this.Project2_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project2_Name_Label.Click += new System.EventHandler(this.Project2_Click);
            // 
            // Project4_TimeElapsed_Label
            // 
            this.Project4_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project4_TimeElapsed_Label.AutoSize = true;
            this.Project4_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project4_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project4_TimeElapsed_Label.Location = new System.Drawing.Point(14, 307);
            this.Project4_TimeElapsed_Label.Name = "Project4_TimeElapsed_Label";
            this.Project4_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project4_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project4_TimeElapsed_Label.TabIndex = 61;
            this.Project4_TimeElapsed_Label.Text = "00:00:00";
            this.Project4_TimeElapsed_Label.Click += new System.EventHandler(this.Project4_Click);
            // 
            // Project4_Name_Label
            // 
            this.Project4_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project4_Name_Label.AutoSize = true;
            this.Project4_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project4_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project4_Name_Label.Location = new System.Drawing.Point(258, 307);
            this.Project4_Name_Label.Name = "Project4_Name_Label";
            this.Project4_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project4_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project4_Name_Label.TabIndex = 60;
            this.Project4_Name_Label.Text = "Project 4";
            this.Project4_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project4_Name_Label.Click += new System.EventHandler(this.Project4_Click);
            // 
            // Project3_TimeElapsed_Label
            // 
            this.Project3_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project3_TimeElapsed_Label.AutoSize = true;
            this.Project3_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project3_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project3_TimeElapsed_Label.Location = new System.Drawing.Point(14, 256);
            this.Project3_TimeElapsed_Label.Name = "Project3_TimeElapsed_Label";
            this.Project3_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project3_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project3_TimeElapsed_Label.TabIndex = 55;
            this.Project3_TimeElapsed_Label.Text = "00:00:00";
            this.Project3_TimeElapsed_Label.Click += new System.EventHandler(this.Project3_Click);
            // 
            // Project3_Name_Label
            // 
            this.Project3_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project3_Name_Label.AutoSize = true;
            this.Project3_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project3_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project3_Name_Label.Location = new System.Drawing.Point(258, 256);
            this.Project3_Name_Label.Name = "Project3_Name_Label";
            this.Project3_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project3_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project3_Name_Label.TabIndex = 54;
            this.Project3_Name_Label.Text = "Project 3";
            this.Project3_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project3_Name_Label.Click += new System.EventHandler(this.Project3_Click);
            // 
            // Project6_TimeElapsed_Label
            // 
            this.Project6_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project6_TimeElapsed_Label.AutoSize = true;
            this.Project6_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project6_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project6_TimeElapsed_Label.Location = new System.Drawing.Point(14, 406);
            this.Project6_TimeElapsed_Label.Name = "Project6_TimeElapsed_Label";
            this.Project6_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project6_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project6_TimeElapsed_Label.TabIndex = 75;
            this.Project6_TimeElapsed_Label.Text = "00:00:00";
            this.Project6_TimeElapsed_Label.Click += new System.EventHandler(this.Project6_Click);
            // 
            // Project6_Name_Label
            // 
            this.Project6_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project6_Name_Label.AutoSize = true;
            this.Project6_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project6_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project6_Name_Label.Location = new System.Drawing.Point(258, 406);
            this.Project6_Name_Label.Name = "Project6_Name_Label";
            this.Project6_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project6_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project6_Name_Label.TabIndex = 74;
            this.Project6_Name_Label.Text = "Project 6";
            this.Project6_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project6_Name_Label.Click += new System.EventHandler(this.Project6_Click);
            // 
            // Project5_TimeElapsed_Label
            // 
            this.Project5_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project5_TimeElapsed_Label.AutoSize = true;
            this.Project5_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project5_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project5_TimeElapsed_Label.Location = new System.Drawing.Point(14, 356);
            this.Project5_TimeElapsed_Label.Name = "Project5_TimeElapsed_Label";
            this.Project5_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project5_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project5_TimeElapsed_Label.TabIndex = 69;
            this.Project5_TimeElapsed_Label.Text = "00:00:00";
            this.Project5_TimeElapsed_Label.Click += new System.EventHandler(this.Project5_Click);
            // 
            // Project5_Name_Label
            // 
            this.Project5_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project5_Name_Label.AutoSize = true;
            this.Project5_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project5_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project5_Name_Label.Location = new System.Drawing.Point(258, 356);
            this.Project5_Name_Label.Name = "Project5_Name_Label";
            this.Project5_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project5_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project5_Name_Label.TabIndex = 68;
            this.Project5_Name_Label.Text = "Project 5";
            this.Project5_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project5_Name_Label.Click += new System.EventHandler(this.Project5_Click);
            // 
            // Project8_TimeElapsed_Label
            // 
            this.Project8_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project8_TimeElapsed_Label.AutoSize = true;
            this.Project8_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project8_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project8_TimeElapsed_Label.Location = new System.Drawing.Point(14, 506);
            this.Project8_TimeElapsed_Label.Name = "Project8_TimeElapsed_Label";
            this.Project8_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project8_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project8_TimeElapsed_Label.TabIndex = 89;
            this.Project8_TimeElapsed_Label.Text = "00:00:00";
            this.Project8_TimeElapsed_Label.Click += new System.EventHandler(this.Project8_Click);
            // 
            // Project8_Name_Label
            // 
            this.Project8_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project8_Name_Label.AutoSize = true;
            this.Project8_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project8_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project8_Name_Label.Location = new System.Drawing.Point(258, 506);
            this.Project8_Name_Label.Name = "Project8_Name_Label";
            this.Project8_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project8_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project8_Name_Label.TabIndex = 88;
            this.Project8_Name_Label.Text = "Project 8";
            this.Project8_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project8_Name_Label.Click += new System.EventHandler(this.Project8_Click);
            // 
            // Project7_TimeElapsed_Label
            // 
            this.Project7_TimeElapsed_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project7_TimeElapsed_Label.AutoSize = true;
            this.Project7_TimeElapsed_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project7_TimeElapsed_Label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project7_TimeElapsed_Label.Location = new System.Drawing.Point(14, 456);
            this.Project7_TimeElapsed_Label.Name = "Project7_TimeElapsed_Label";
            this.Project7_TimeElapsed_Label.Padding = new System.Windows.Forms.Padding(57, 0, 57, 0);
            this.Project7_TimeElapsed_Label.Size = new System.Drawing.Size(235, 39);
            this.Project7_TimeElapsed_Label.TabIndex = 83;
            this.Project7_TimeElapsed_Label.Text = "00:00:00";
            this.Project7_TimeElapsed_Label.Click += new System.EventHandler(this.Project7_Click);
            // 
            // Project7_Name_Label
            // 
            this.Project7_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project7_Name_Label.AutoSize = true;
            this.Project7_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Project7_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Project7_Name_Label.Location = new System.Drawing.Point(258, 456);
            this.Project7_Name_Label.Name = "Project7_Name_Label";
            this.Project7_Name_Label.Padding = new System.Windows.Forms.Padding(81, 8, 81, 8);
            this.Project7_Name_Label.Size = new System.Drawing.Size(235, 39);
            this.Project7_Name_Label.TabIndex = 82;
            this.Project7_Name_Label.Text = "Project 7";
            this.Project7_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project7_Name_Label.Click += new System.EventHandler(this.Project7_Click);
            // 
            // Subtract30_Button
            // 
            this.Subtract30_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subtract30_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Subtract30_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtract30_Button.Location = new System.Drawing.Point(10, 97);
            this.Subtract30_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subtract30_Button.Name = "Subtract30_Button";
            this.Subtract30_Button.Size = new System.Drawing.Size(119, 50);
            this.Subtract30_Button.TabIndex = 6;
            this.Subtract30_Button.Text = "-30";
            this.Subtract30_Button.UseVisualStyleBackColor = false;
            this.Subtract30_Button.Click += new System.EventHandler(this.Subtract30_Button_Click);
            // 
            // Subtract10_Button
            // 
            this.Subtract10_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subtract10_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Subtract10_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtract10_Button.Location = new System.Drawing.Point(135, 97);
            this.Subtract10_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subtract10_Button.Name = "Subtract10_Button";
            this.Subtract10_Button.Size = new System.Drawing.Size(119, 50);
            this.Subtract10_Button.TabIndex = 7;
            this.Subtract10_Button.Text = "-10";
            this.Subtract10_Button.UseVisualStyleBackColor = false;
            this.Subtract10_Button.Click += new System.EventHandler(this.Subtract10_Button_Click);
            // 
            // Add10_Button
            // 
            this.Add10_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add10_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Add10_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add10_Button.Location = new System.Drawing.Point(259, 97);
            this.Add10_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add10_Button.Name = "Add10_Button";
            this.Add10_Button.Size = new System.Drawing.Size(119, 50);
            this.Add10_Button.TabIndex = 8;
            this.Add10_Button.Text = "+10";
            this.Add10_Button.UseVisualStyleBackColor = false;
            this.Add10_Button.Click += new System.EventHandler(this.Add10_Button_Click);
            // 
            // Add30_Button
            // 
            this.Add30_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add30_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Add30_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add30_Button.Location = new System.Drawing.Point(383, 97);
            this.Add30_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add30_Button.Name = "Add30_Button";
            this.Add30_Button.Size = new System.Drawing.Size(119, 50);
            this.Add30_Button.TabIndex = 9;
            this.Add30_Button.Text = "+30";
            this.Add30_Button.UseVisualStyleBackColor = false;
            this.Add30_Button.Click += new System.EventHandler(this.Add30_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProjectTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 562);
            this.Controls.Add(this.Project8_TimeElapsed_Label);
            this.Controls.Add(this.Project8_Name_Label);
            this.Controls.Add(this.Project7_TimeElapsed_Label);
            this.Controls.Add(this.Project7_Name_Label);
            this.Controls.Add(this.Project6_TimeElapsed_Label);
            this.Controls.Add(this.Project6_Name_Label);
            this.Controls.Add(this.Project5_TimeElapsed_Label);
            this.Controls.Add(this.Project5_Name_Label);
            this.Controls.Add(this.Project4_TimeElapsed_Label);
            this.Controls.Add(this.Project4_Name_Label);
            this.Controls.Add(this.Project3_TimeElapsed_Label);
            this.Controls.Add(this.Project3_Name_Label);
            this.Controls.Add(this.Project2_TimeElapsed_Label);
            this.Controls.Add(this.Project2_Name_Label);
            this.Controls.Add(this.Add30_Button);
            this.Controls.Add(this.Add10_Button);
            this.Controls.Add(this.Subtract10_Button);
            this.Controls.Add(this.Subtract30_Button);
            this.Controls.Add(this.Project1_TimeElapsed_Label);
            this.Controls.Add(this.Project1_Name_Label);
            this.Controls.Add(this.TotalTimerPauseButton);
            this.Controls.Add(this.TotalTimerTimeElapsedLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(534, 599);
            this.Name = "ProjectTimer";
            this.Text = "Project Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem AddProjectsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label TotalTimerTimeElapsedLabel;
        private Button TotalTimerPauseButton;
        private Label Project1_Name_Label;
        private Label Project1_TimeElapsed_Label;
        private Label Project2_TimeElapsed_Label;
        private Label Project2_Name_Label;
        private Label Project4_TimeElapsed_Label;
        private Label Project4_Name_Label;
        private Label Project3_TimeElapsed_Label;
        private Label Project3_Name_Label;
        private Label Project6_TimeElapsed_Label;
        private Label Project6_Name_Label;
        private Label Project5_TimeElapsed_Label;
        private Label Project5_Name_Label;
        private Label Project8_TimeElapsed_Label;
        private Label Project8_Name_Label;
        private Label Project7_TimeElapsed_Label;
        private Label Project7_Name_Label;
        private Button Subtract30_Button;
        private Button Subtract10_Button;
        private Button Add10_Button;
        private Button Add30_Button;
        private System.Windows.Forms.Timer timer1;
    }
}