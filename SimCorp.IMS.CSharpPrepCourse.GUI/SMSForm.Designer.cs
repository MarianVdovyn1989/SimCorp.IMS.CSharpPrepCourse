namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    partial class SMSForm
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
            this.SMSBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.cboSMSFormatSelector = new System.Windows.Forms.ComboBox();
            this.lvSMS = new System.Windows.Forms.ListView();
            this.SMSSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SMSText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SMSTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSMSSenderSelector = new System.Windows.Forms.ComboBox();
            this.lFormat = new System.Windows.Forms.Label();
            this.lSender = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.cbMultipleFilters = new System.Windows.Forms.CheckBox();
            this.tbSearchTextInMessages = new System.Windows.Forms.TextBox();
            this.lSearch = new System.Windows.Forms.Label();
            this.lTo = new System.Windows.Forms.Label();
            this.lFrom = new System.Windows.Forms.Label();
            this.dtFilterToTime = new System.Windows.Forms.DateTimePicker();
            this.dtFilterFromTime = new System.Windows.Forms.DateTimePicker();
            this.bDelete = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // SMSBackgroundWorker
            // 
            this.SMSBackgroundWorker.WorkerSupportsCancellation = true;
            this.SMSBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SMSBackgroundWorker_DoWork);
            // 
            // cboSMSFormatSelector
            // 
            this.cboSMSFormatSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSMSFormatSelector.FormattingEnabled = true;
            this.cboSMSFormatSelector.Items.AddRange(new object[] {
            "None",
            "LowerCase",
            "UpperCase",
            "End with DateTime",
            "Start with DateTime",
            "Custom"});
            this.cboSMSFormatSelector.Location = new System.Drawing.Point(576, 264);
            this.cboSMSFormatSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSMSFormatSelector.Name = "cboSMSFormatSelector";
            this.cboSMSFormatSelector.Size = new System.Drawing.Size(223, 28);
            this.cboSMSFormatSelector.TabIndex = 1;
            // 
            // lvSMS
            // 
            this.lvSMS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SMSSender,
            this.SMSText,
            this.SMSTime});
            this.lvSMS.FullRowSelect = true;
            this.lvSMS.HideSelection = false;
            this.lvSMS.Location = new System.Drawing.Point(18, 309);
            this.lvSMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvSMS.Name = "lvSMS";
            this.lvSMS.Size = new System.Drawing.Size(1014, 363);
            this.lvSMS.TabIndex = 2;
            this.lvSMS.UseCompatibleStateImageBehavior = false;
            this.lvSMS.View = System.Windows.Forms.View.Details;
            // 
            // SMSSender
            // 
            this.SMSSender.Text = "From";
            this.SMSSender.Width = 80;
            // 
            // SMSText
            // 
            this.SMSText.Text = "Message";
            this.SMSText.Width = 420;
            // 
            // SMSTime
            // 
            this.SMSTime.Text = "Date/Time";
            this.SMSTime.Width = 150;
            // 
            // cboSMSSenderSelector
            // 
            this.cboSMSSenderSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSMSSenderSelector.FormattingEnabled = true;
            this.cboSMSSenderSelector.Items.AddRange(new object[] {
            "None",
            "All"});
            this.cboSMSSenderSelector.Location = new System.Drawing.Point(100, 71);
            this.cboSMSSenderSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSMSSenderSelector.Name = "cboSMSSenderSelector";
            this.cboSMSSenderSelector.Size = new System.Drawing.Size(176, 28);
            this.cboSMSSenderSelector.TabIndex = 3;
            // 
            // lFormat
            // 
            this.lFormat.AutoSize = true;
            this.lFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFormat.Location = new System.Drawing.Point(401, 268);
            this.lFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFormat.Name = "lFormat";
            this.lFormat.Size = new System.Drawing.Size(116, 18);
            this.lFormat.TabIndex = 4;
            this.lFormat.Text = "Message format";
            // 
            // lSender
            // 
            this.lSender.AutoSize = true;
            this.lSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSender.Location = new System.Drawing.Point(9, 69);
            this.lSender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSender.Name = "lSender";
            this.lSender.Size = new System.Drawing.Size(55, 18);
            this.lSender.TabIndex = 5;
            this.lSender.Text = "Sender";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.cbMultipleFilters);
            this.groupBoxFilters.Controls.Add(this.tbSearchTextInMessages);
            this.groupBoxFilters.Controls.Add(this.lSearch);
            this.groupBoxFilters.Controls.Add(this.lTo);
            this.groupBoxFilters.Controls.Add(this.lFrom);
            this.groupBoxFilters.Controls.Add(this.dtFilterToTime);
            this.groupBoxFilters.Controls.Add(this.dtFilterFromTime);
            this.groupBoxFilters.Controls.Add(this.lSender);
            this.groupBoxFilters.Controls.Add(this.cboSMSSenderSelector);
            this.groupBoxFilters.Location = new System.Drawing.Point(18, 18);
            this.groupBoxFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilters.Size = new System.Drawing.Size(362, 281);
            this.groupBoxFilters.TabIndex = 6;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // cbMultipleFilters
            // 
            this.cbMultipleFilters.AutoSize = true;
            this.cbMultipleFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultipleFilters.Location = new System.Drawing.Point(12, 249);
            this.cbMultipleFilters.Name = "cbMultipleFilters";
            this.cbMultipleFilters.Size = new System.Drawing.Size(121, 22);
            this.cbMultipleFilters.TabIndex = 14;
            this.cbMultipleFilters.Text = "Multiple Filters";
            this.cbMultipleFilters.UseVisualStyleBackColor = true;
            this.cbMultipleFilters.CheckedChanged += new System.EventHandler(this.cbMultipleFilters_Changed);
            // 
            // tbSearchTextInMessages
            // 
            this.tbSearchTextInMessages.Location = new System.Drawing.Point(100, 196);
            this.tbSearchTextInMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchTextInMessages.Name = "tbSearchTextInMessages";
            this.tbSearchTextInMessages.Size = new System.Drawing.Size(176, 26);
            this.tbSearchTextInMessages.TabIndex = 12;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(9, 188);
            this.lSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(53, 34);
            this.lSearch.TabIndex = 13;
            this.lSearch.Text = "Search\r\nby text";
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTo.Location = new System.Drawing.Point(9, 155);
            this.lTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(26, 18);
            this.lTo.TabIndex = 11;
            this.lTo.Text = "To";
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFrom.Location = new System.Drawing.Point(9, 115);
            this.lFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(44, 18);
            this.lFrom.TabIndex = 10;
            this.lFrom.Text = "From";
            // 
            // dtFilterToTime
            // 
            this.dtFilterToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtFilterToTime.Location = new System.Drawing.Point(100, 152);
            this.dtFilterToTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFilterToTime.Name = "dtFilterToTime";
            this.dtFilterToTime.Size = new System.Drawing.Size(176, 26);
            this.dtFilterToTime.TabIndex = 9;
            this.dtFilterToTime.DropDown += new System.EventHandler(this.dtFilterToTime_DropDown);
            // 
            // dtFilterFromTime
            // 
            this.dtFilterFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtFilterFromTime.Location = new System.Drawing.Point(100, 112);
            this.dtFilterFromTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFilterFromTime.Name = "dtFilterFromTime";
            this.dtFilterFromTime.Size = new System.Drawing.Size(176, 26);
            this.dtFilterFromTime.TabIndex = 8;
            this.dtFilterFromTime.DropDown += new System.EventHandler(this.dtFilterFromTime_DropDown);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(875, 261);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(157, 32);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // SMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 692);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.cboSMSFormatSelector);
            this.Controls.Add(this.lFormat);
            this.Controls.Add(this.lvSMS);
            this.Controls.Add(this.groupBoxFilters);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SMSForm";
            this.Text = "SMS Form";
            this.Load += new System.EventHandler(this.SMSForm_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker SMSBackgroundWorker;
        internal System.Windows.Forms.ComboBox cboSMSFormatSelector;
        private System.Windows.Forms.ListView lvSMS;
        internal System.Windows.Forms.ComboBox cboSMSSenderSelector;
        private System.Windows.Forms.ColumnHeader SMSSender;
        private System.Windows.Forms.ColumnHeader SMSText;
        private System.Windows.Forms.ColumnHeader SMSTime;
        private System.Windows.Forms.Label lFormat;
        private System.Windows.Forms.Label lSender;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        internal System.Windows.Forms.DateTimePicker dtFilterToTime;
        internal System.Windows.Forms.DateTimePicker dtFilterFromTime;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lFrom;
        internal System.Windows.Forms.TextBox tbSearchTextInMessages;
        private System.Windows.Forms.Label lSearch;
        internal System.Windows.Forms.CheckBox cbMultipleFilters;
        private System.Windows.Forms.Button bDelete;
    }
}