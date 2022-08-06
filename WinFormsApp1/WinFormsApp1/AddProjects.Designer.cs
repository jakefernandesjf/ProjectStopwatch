namespace ProjectTimerWinFormsApp
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
            this.NewProjectName_TextBox.Location = new System.Drawing.Point(195, 6);
            this.NewProjectName_TextBox.Name = "NewProjectName_TextBox";
            this.NewProjectName_TextBox.Size = new System.Drawing.Size(195, 29);
            this.NewProjectName_TextBox.TabIndex = 0;
            // 
            // EnterNewProjectName_Label
            // 
            this.EnterNewProjectName_Label.AutoSize = true;
            this.EnterNewProjectName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterNewProjectName_Label.Location = new System.Drawing.Point(12, 9);
            this.EnterNewProjectName_Label.Name = "EnterNewProjectName_Label";
            this.EnterNewProjectName_Label.Size = new System.Drawing.Size(177, 21);
            this.EnterNewProjectName_Label.TabIndex = 1;
            this.EnterNewProjectName_Label.Text = "Enter new project name:";
            // 
            // CurrentProjects_ListBox
            // 
            this.CurrentProjects_ListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentProjects_ListBox.FormattingEnabled = true;
            this.CurrentProjects_ListBox.ItemHeight = 21;
            this.CurrentProjects_ListBox.Location = new System.Drawing.Point(195, 72);
            this.CurrentProjects_ListBox.Name = "CurrentProjects_ListBox";
            this.CurrentProjects_ListBox.Size = new System.Drawing.Size(195, 172);
            this.CurrentProjects_ListBox.TabIndex = 2;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(195, 41);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // CurrentProjects_Label
            // 
            this.CurrentProjects_Label.AutoSize = true;
            this.CurrentProjects_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentProjects_Label.Location = new System.Drawing.Point(64, 72);
            this.CurrentProjects_Label.Name = "CurrentProjects_Label";
            this.CurrentProjects_Label.Size = new System.Drawing.Size(125, 21);
            this.CurrentProjects_Label.TabIndex = 4;
            this.CurrentProjects_Label.Text = "Current Projects:";
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(195, 250);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // SaveAndExit_Button
            // 
            this.SaveAndExit_Button.Location = new System.Drawing.Point(276, 250);
            this.SaveAndExit_Button.Name = "SaveAndExit_Button";
            this.SaveAndExit_Button.Size = new System.Drawing.Size(114, 23);
            this.SaveAndExit_Button.TabIndex = 6;
            this.SaveAndExit_Button.Text = "Save and Exit";
            this.SaveAndExit_Button.UseVisualStyleBackColor = true;
            // 
            // AddProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.SaveAndExit_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.CurrentProjects_Label);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.CurrentProjects_ListBox);
            this.Controls.Add(this.EnterNewProjectName_Label);
            this.Controls.Add(this.NewProjectName_TextBox);
            this.MaximumSize = new System.Drawing.Size(420, 320);
            this.MinimumSize = new System.Drawing.Size(420, 320);
            this.Name = "AddProjects";
            this.Text = "Add Projects";
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