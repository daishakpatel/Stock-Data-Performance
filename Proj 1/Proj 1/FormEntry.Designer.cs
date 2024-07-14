namespace Proj_1
{
    partial class FormEntry
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.button_Load = new System.Windows.Forms.Button();
            this.LoaddateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.LoaddateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.LoadButtonOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(345, 41);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(514, 61);
            this.MainLabel.TabIndex = 8;
            this.MainLabel.Text = "Stock Data Analysis";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Load
            // 
            this.button_Load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Load.Location = new System.Drawing.Point(896, 127);
            this.button_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(166, 104);
            this.button_Load.TabIndex = 11;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // LoaddateTimePicker_endDate
            // 
            this.LoaddateTimePicker_endDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoaddateTimePicker_endDate.Location = new System.Drawing.Point(483, 192);
            this.LoaddateTimePicker_endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoaddateTimePicker_endDate.Name = "LoaddateTimePicker_endDate";
            this.LoaddateTimePicker_endDate.Size = new System.Drawing.Size(379, 31);
            this.LoaddateTimePicker_endDate.TabIndex = 12;
            this.LoaddateTimePicker_endDate.Value = new System.DateTime(2023, 7, 15, 0, 0, 0, 0);
            // 
            // LoaddateTimePicker_startDate
            // 
            this.LoaddateTimePicker_startDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoaddateTimePicker_startDate.Location = new System.Drawing.Point(483, 131);
            this.LoaddateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoaddateTimePicker_startDate.Name = "LoaddateTimePicker_startDate";
            this.LoaddateTimePicker_startDate.Size = new System.Drawing.Size(376, 31);
            this.LoaddateTimePicker_startDate.TabIndex = 13;
            this.LoaddateTimePicker_startDate.Value = new System.DateTime(2023, 6, 15, 0, 0, 0, 0);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(310, 130);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(141, 32);
            this.StartDateLabel.TabIndex = 14;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(310, 191);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(132, 32);
            this.EndDateLabel.TabIndex = 15;
            this.EndDateLabel.Text = "End Date";
            // 
            // LoadButtonOpenFileDialog
            // 
            this.LoadButtonOpenFileDialog.FileName = "openFileDialog1";
            this.LoadButtonOpenFileDialog.Filter = "All Stock files| *.csv| Daily Stocks|*-Day.csv| Weekly Stocks|*-Week.csv|Monthly " +
    "Stocks|*-Month.csv";
            this.LoadButtonOpenFileDialog.InitialDirectory = "C:\\Users\\rachi\\Desktop\\Proj 2\\Proj 1\\Stock Data";
            this.LoadButtonOpenFileDialog.Multiselect = true;
            this.LoadButtonOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadButtonOpenFileDialog_FileOk);
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 333);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.LoaddateTimePicker_startDate);
            this.Controls.Add(this.LoaddateTimePicker_endDate);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.MainLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEntry";
            this.Text = "Stock Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.DateTimePicker LoaddateTimePicker_endDate;
        private System.Windows.Forms.DateTimePicker LoaddateTimePicker_startDate;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.OpenFileDialog LoadButtonOpenFileDialog;
    }
}