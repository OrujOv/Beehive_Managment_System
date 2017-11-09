namespace Beehive_Managment_System_charpter_7_
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.assignJobToBee = new System.Windows.Forms.Button();
            this.nextShiftButton = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJobToBee);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shifts";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(7, 50);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(181, 21);
            this.workerBeeJob.TabIndex = 2;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(202, 50);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(89, 20);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // assignJobToBee
            // 
            this.assignJobToBee.Location = new System.Drawing.Point(7, 78);
            this.assignJobToBee.Name = "assignJobToBee";
            this.assignJobToBee.Size = new System.Drawing.Size(284, 23);
            this.assignJobToBee.TabIndex = 4;
            this.assignJobToBee.Text = "Assign this job to a bee";
            this.assignJobToBee.UseVisualStyleBackColor = true;
            this.assignJobToBee.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextShiftButton
            // 
            this.nextShiftButton.Location = new System.Drawing.Point(321, 12);
            this.nextShiftButton.Name = "nextShiftButton";
            this.nextShiftButton.Size = new System.Drawing.Size(122, 113);
            this.nextShiftButton.TabIndex = 1;
            this.nextShiftButton.Text = "Work the next job";
            this.nextShiftButton.UseVisualStyleBackColor = true;
            this.nextShiftButton.Click += new System.EventHandler(this.nextShiftButton_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(12, 132);
            this.Report.Multiline = true;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(431, 162);
            this.Report.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 306);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.nextShiftButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Managment System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignJobToBee;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextShiftButton;
        private System.Windows.Forms.TextBox Report;
    }
}

