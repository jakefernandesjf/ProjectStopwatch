namespace ProjectStopwatchApp
{
    partial class AboutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GitHub_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Stopwatch\r\nVersion 0.9\r\n\r\nJake Fernandes\r\n2022";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GitHub_Link
            // 
            this.GitHub_Link.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHub_Link.Location = new System.Drawing.Point(10, 109);
            this.GitHub_Link.Name = "GitHub_Link";
            this.GitHub_Link.Size = new System.Drawing.Size(212, 43);
            this.GitHub_Link.TabIndex = 1;
            this.GitHub_Link.TabStop = true;
            this.GitHub_Link.Text = "Help / GitHub";
            this.GitHub_Link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GitHub_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_Link_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.GitHub_Link);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private LinkLabel GitHub_Link;
    }
}