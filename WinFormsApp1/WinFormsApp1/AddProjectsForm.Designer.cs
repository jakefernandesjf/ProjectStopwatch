namespace ProjectTimerApp
{
    partial class AddProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewProjectName_TextBox = new System.Windows.Forms.TextBox();
            this.EnterNewProjectName_Label = new System.Windows.Forms.Label();
            this.CurrentProjects_ListBox = new System.Windows.Forms.ListBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.CurrentProjects_Label = new System.Windows.Forms.Label();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.SaveAndExit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewProjectName_TextBox
            // 
            this.NewProjectName_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewProjectName_TextBox.Location = new System.Drawing.Point(223, 8);
            this.NewProjectName_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewProjectName_TextBox.Name = "NewProjectName_TextBox";
            this.NewProjectName_TextBox.Size = new System.Drawing.Size(222, 34);
            this.NewProjectName_TextBox.TabIndex = 0;
            // 
            // EnterNewProjectName_Label
            // 
            this.EnterNewProjectName_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterNewProjectName_Label.Location = new System.Drawing.Point(12, 12);
            this.EnterNewProjectName_Label.Name = "EnterNewProjectName_Label";
            this.EnterNewProjectName_Label.Size = new System.Drawing.Size(204, 28);
            this.EnterNewProjectName_Label.TabIndex = 1;
            this.EnterNewProjectName_Label.Text = "Enter new project name:";
            this.EnterNewProjectName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentProjects_ListBox
            // 
            this.CurrentProjects_ListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentProjects_ListBox.FormattingEnabled = true;
            this.CurrentProjects_ListBox.ItemHeight = 28;
            this.CurrentProjects_ListBox.Location = new System.Drawing.Point(223, 96);
            this.CurrentProjects_ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentProjects_ListBox.Name = "CurrentProjects_ListBox";
            this.CurrentProjects_ListBox.Size = new System.Drawing.Size(222, 228);
            this.CurrentProjects_ListBox.TabIndex = 2;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(223, 55);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(86, 31);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // CurrentProjects_Label
            // 
            this.CurrentProjects_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentProjects_Label.Location = new System.Drawing.Point(12, 96);
            this.CurrentProjects_Label.Name = "CurrentProjects_Label";
            this.CurrentProjects_Label.Size = new System.Drawing.Size(204, 28);
            this.CurrentProjects_Label.TabIndex = 4;
            this.CurrentProjects_Label.Text = "Current Projects:";
            this.CurrentProjects_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(223, 333);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(86, 31);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // SaveAndExit_Button
            // 
            this.SaveAndExit_Button.Location = new System.Drawing.Point(315, 333);
            this.SaveAndExit_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveAndExit_Button.Name = "SaveAndExit_Button";
            this.SaveAndExit_Button.Size = new System.Drawing.Size(130, 31);
            this.SaveAndExit_Button.TabIndex = 6;
            this.SaveAndExit_Button.Text = "Save and Exit";
            this.SaveAndExit_Button.UseVisualStyleBackColor = true;
            this.SaveAndExit_Button.Click += new System.EventHandler(this.SaveAndExit_Button_Click);
            // 
            // AddProjects
            // 
            this.AcceptButton = this.Add_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.Controls.Add(this.SaveAndExit_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.CurrentProjects_Label);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.CurrentProjects_ListBox);
            this.Controls.Add(this.EnterNewProjectName_Label);
            this.Controls.Add(this.NewProjectName_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(477, 411);
            this.Name = "AddProjects";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Projects";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NewProjectName_TextBox;
        private Label EnterNewProjectName_Label;
        private ListBox CurrentProjects_ListBox;
        private Button Add_Button;
        private Label CurrentProjects_Label;
        private Button Remove_Button;
        private Button SaveAndExit_Button;
    }
}