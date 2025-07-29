namespace InitalUI
{
    partial class GeneralDashboardForm
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
            GCSEbtn = new Button();
            Alevelbtn = new Button();
            Demobtn = new Button();
            Furtherbtn = new Button();
            Helpbtn = new Button();
            TeacherDashboardbtn = new Button();
            SuspendLayout();
            // 
            // GCSEbtn
            // 
            GCSEbtn.Location = new Point(36, 42);
            GCSEbtn.Name = "GCSEbtn";
            GCSEbtn.Size = new Size(112, 34);
            GCSEbtn.TabIndex = 0;
            GCSEbtn.Text = "GCSE";
            GCSEbtn.UseVisualStyleBackColor = true;
            GCSEbtn.Click += GCSEbtn_Click;
            // 
            // Alevelbtn
            // 
            Alevelbtn.Location = new Point(170, 42);
            Alevelbtn.Name = "Alevelbtn";
            Alevelbtn.Size = new Size(112, 34);
            Alevelbtn.TabIndex = 1;
            Alevelbtn.Text = "A-Level";
            Alevelbtn.UseVisualStyleBackColor = true;
            Alevelbtn.Click += Alevelbtn_Click;
            // 
            // Demobtn
            // 
            Demobtn.Location = new Point(36, 96);
            Demobtn.Name = "Demobtn";
            Demobtn.Size = new Size(112, 34);
            Demobtn.TabIndex = 2;
            Demobtn.Text = "Demos";
            Demobtn.UseVisualStyleBackColor = true;
            Demobtn.Click += Demobtn_Click;
            // 
            // Furtherbtn
            // 
            Furtherbtn.Location = new Point(170, 96);
            Furtherbtn.Name = "Furtherbtn";
            Furtherbtn.Size = new Size(112, 34);
            Furtherbtn.TabIndex = 3;
            Furtherbtn.Text = "Further";
            Furtherbtn.UseVisualStyleBackColor = true;
            Furtherbtn.Click += Furtherbtn_Click;
            // 
            // Helpbtn
            // 
            Helpbtn.Location = new Point(105, 154);
            Helpbtn.Name = "Helpbtn";
            Helpbtn.Size = new Size(112, 34);
            Helpbtn.TabIndex = 4;
            Helpbtn.Text = "Help";
            Helpbtn.UseVisualStyleBackColor = true;
            Helpbtn.Click += Helpbtn_Click;
            // 
            // TeacherDashboardbtn
            // 
            TeacherDashboardbtn.Location = new Point(105, 214);
            TeacherDashboardbtn.Name = "TeacherDashboardbtn";
            TeacherDashboardbtn.Size = new Size(112, 34);
            TeacherDashboardbtn.TabIndex = 5;
            TeacherDashboardbtn.Text = "Teacher Dashboard";
            TeacherDashboardbtn.UseVisualStyleBackColor = true;
            TeacherDashboardbtn.Click += TeacherDashboard_btn;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TeacherDashboardbtn);
            Controls.Add(Helpbtn);
            Controls.Add(Furtherbtn);
            Controls.Add(Demobtn);
            Controls.Add(Alevelbtn);
            Controls.Add(GCSEbtn);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button GCSEbtn;
        private Button Alevelbtn;
        private Button Demobtn;
        private Button Furtherbtn;
        private Button Helpbtn;
        private Button TeacherDashboardbtn;
    }
}