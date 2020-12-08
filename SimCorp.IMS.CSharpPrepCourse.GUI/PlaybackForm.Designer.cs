namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    partial class PlaybackForm
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
            this.bApply = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.rbAirPods = new System.Windows.Forms.RadioButton();
            this.rbAirPodsPro = new System.Windows.Forms.RadioButton();
            this.rbGalaxyBuds = new System.Windows.Forms.RadioButton();
            this.rbGalaxyBudsLive = new System.Windows.Forms.RadioButton();
            this.rbHomePod = new System.Windows.Forms.RadioButton();
            this.rbNoNameHeadSet = new System.Windows.Forms.RadioButton();
            this.rbPhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.lText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(510, 184);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(115, 31);
            this.bApply.TabIndex = 0;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbOutput.Location = new System.Drawing.Point(12, 221);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(614, 264);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbAirPods
            // 
            this.rbAirPods.AutoSize = true;
            this.rbAirPods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAirPods.Location = new System.Drawing.Point(17, 79);
            this.rbAirPods.Name = "rbAirPods";
            this.rbAirPods.Size = new System.Drawing.Size(67, 19);
            this.rbAirPods.TabIndex = 2;
            this.rbAirPods.TabStop = true;
            this.rbAirPods.Text = "AirPods";
            this.rbAirPods.UseVisualStyleBackColor = true;
            this.rbAirPods.CheckedChanged += new System.EventHandler(this.rbAirPods_CheckedChanged);
            // 
            // rbAirPodsPro
            // 
            this.rbAirPodsPro.AutoSize = true;
            this.rbAirPodsPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAirPodsPro.Location = new System.Drawing.Point(17, 114);
            this.rbAirPodsPro.Name = "rbAirPodsPro";
            this.rbAirPodsPro.Size = new System.Drawing.Size(89, 19);
            this.rbAirPodsPro.TabIndex = 3;
            this.rbAirPodsPro.TabStop = true;
            this.rbAirPodsPro.Text = "AirPods Pro";
            this.rbAirPodsPro.UseVisualStyleBackColor = true;
            this.rbAirPodsPro.CheckedChanged += new System.EventHandler(this.rbAirPodsPro_CheckedChanged);
            // 
            // rbGalaxyBuds
            // 
            this.rbGalaxyBuds.AutoSize = true;
            this.rbGalaxyBuds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGalaxyBuds.Location = new System.Drawing.Point(151, 79);
            this.rbGalaxyBuds.Name = "rbGalaxyBuds";
            this.rbGalaxyBuds.Size = new System.Drawing.Size(93, 19);
            this.rbGalaxyBuds.TabIndex = 4;
            this.rbGalaxyBuds.TabStop = true;
            this.rbGalaxyBuds.Text = "Galaxy Buds";
            this.rbGalaxyBuds.UseVisualStyleBackColor = true;
            this.rbGalaxyBuds.CheckedChanged += new System.EventHandler(this.rbGalaxyBuds_CheckedChanged);
            // 
            // rbGalaxyBudsLive
            // 
            this.rbGalaxyBudsLive.AutoSize = true;
            this.rbGalaxyBudsLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGalaxyBudsLive.Location = new System.Drawing.Point(151, 114);
            this.rbGalaxyBudsLive.Name = "rbGalaxyBudsLive";
            this.rbGalaxyBudsLive.Size = new System.Drawing.Size(118, 19);
            this.rbGalaxyBudsLive.TabIndex = 5;
            this.rbGalaxyBudsLive.TabStop = true;
            this.rbGalaxyBudsLive.Text = "Galaxy Buds Live";
            this.rbGalaxyBudsLive.UseVisualStyleBackColor = true;
            this.rbGalaxyBudsLive.CheckedChanged += new System.EventHandler(this.rbGalaxyBudsLive_CheckedChanged);
            // 
            // rbHomePod
            // 
            this.rbHomePod.AutoSize = true;
            this.rbHomePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHomePod.Location = new System.Drawing.Point(17, 151);
            this.rbHomePod.Name = "rbHomePod";
            this.rbHomePod.Size = new System.Drawing.Size(81, 19);
            this.rbHomePod.TabIndex = 6;
            this.rbHomePod.TabStop = true;
            this.rbHomePod.Text = "HomePod";
            this.rbHomePod.UseVisualStyleBackColor = true;
            this.rbHomePod.CheckedChanged += new System.EventHandler(this.rbHomePod_CheckedChanged);
            // 
            // rbNoNameHeadSet
            // 
            this.rbNoNameHeadSet.AutoSize = true;
            this.rbNoNameHeadSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoNameHeadSet.Location = new System.Drawing.Point(302, 79);
            this.rbNoNameHeadSet.Name = "rbNoNameHeadSet";
            this.rbNoNameHeadSet.Size = new System.Drawing.Size(129, 19);
            this.rbNoNameHeadSet.TabIndex = 7;
            this.rbNoNameHeadSet.TabStop = true;
            this.rbNoNameHeadSet.Text = "No Name HeadSet";
            this.rbNoNameHeadSet.UseVisualStyleBackColor = true;
            this.rbNoNameHeadSet.CheckedChanged += new System.EventHandler(this.rbNoNameHeadSet_CheckedChanged);
            // 
            // rbPhoneSpeaker
            // 
            this.rbPhoneSpeaker.AutoSize = true;
            this.rbPhoneSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoneSpeaker.Location = new System.Drawing.Point(302, 114);
            this.rbPhoneSpeaker.Name = "rbPhoneSpeaker";
            this.rbPhoneSpeaker.Size = new System.Drawing.Size(110, 19);
            this.rbPhoneSpeaker.TabIndex = 8;
            this.rbPhoneSpeaker.TabStop = true;
            this.rbPhoneSpeaker.Text = "Phone Speaker";
            this.rbPhoneSpeaker.UseVisualStyleBackColor = true;
            this.rbPhoneSpeaker.CheckedChanged += new System.EventHandler(this.rbPhoneSpeaker_CheckedChanged);
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lText.Location = new System.Drawing.Point(14, 22);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(359, 20);
            this.lText.TabIndex = 9;
            this.lText.Text = "Please select playback component for your phone";
            // 
            // PlaybackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 497);
            this.Controls.Add(this.lText);
            this.Controls.Add(this.rbPhoneSpeaker);
            this.Controls.Add(this.rbNoNameHeadSet);
            this.Controls.Add(this.rbHomePod);
            this.Controls.Add(this.rbGalaxyBudsLive);
            this.Controls.Add(this.rbGalaxyBuds);
            this.Controls.Add(this.rbAirPodsPro);
            this.Controls.Add(this.rbAirPods);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.bApply);
            this.Name = "PlaybackForm";
            this.Text = "SimCorp Mobile App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.RadioButton rbAirPods;
        private System.Windows.Forms.RadioButton rbAirPodsPro;
        private System.Windows.Forms.RadioButton rbGalaxyBuds;
        private System.Windows.Forms.RadioButton rbGalaxyBudsLive;
        private System.Windows.Forms.RadioButton rbHomePod;
        private System.Windows.Forms.RadioButton rbNoNameHeadSet;
        private System.Windows.Forms.RadioButton rbPhoneSpeaker;
        private System.Windows.Forms.Label lText;
    }
}

