namespace SEPD
{
    partial class SEPD
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtMalSpeech = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnFemSpeech = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(438, 69);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select WAV File:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(122, 70);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(310, 22);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtMalSpeech
            // 
            this.txtMalSpeech.Location = new System.Drawing.Point(283, 193);
            this.txtMalSpeech.Name = "txtMalSpeech";
            this.txtMalSpeech.Size = new System.Drawing.Size(127, 39);
            this.txtMalSpeech.TabIndex = 3;
            this.txtMalSpeech.Text = "Sound As Male";
            this.txtMalSpeech.UseVisualStyleBackColor = true;
            this.txtMalSpeech.Click += new System.EventHandler(this.txtMalSpeech_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(438, 127);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 35);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnFemSpeech
            // 
            this.btnFemSpeech.Location = new System.Drawing.Point(150, 193);
            this.btnFemSpeech.Name = "btnFemSpeech";
            this.btnFemSpeech.Size = new System.Drawing.Size(127, 39);
            this.btnFemSpeech.TabIndex = 5;
            this.btnFemSpeech.Text = "Sound As Girl";
            this.btnFemSpeech.UseVisualStyleBackColor = true;
            this.btnFemSpeech.Click += new System.EventHandler(this.btnFemSpeech_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(357, 127);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 35);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 272);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnFemSpeech);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtMalSpeech);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Speech Enhancer Pitch Distorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button txtMalSpeech;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnFemSpeech;
        private System.Windows.Forms.Button btnPlay;
    }
}

