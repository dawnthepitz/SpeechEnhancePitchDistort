using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SEPD
{
    public partial class SEPD : Form
    {
        public SEPD()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                if (o.FileName.EndsWith(".wav"))
                    txtFilePath.Text = o.FileName;
                else
                    MessageBox.Show("Selected File not compatible to the System, please use .wav Files only","Unsupported File",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo recorder = new ProcessStartInfo();
                recorder.FileName = @"soundrecorder";
                recorder.Arguments = @"/file outputfile.wav";
                Process.Start(recorder);
            }
            catch
            {
                MessageBox.Show("Cannot use Sound Recorder", "Sound Recorder not working", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(txtFilePath.Text);
            }
            catch
            {
                MessageBox.Show("File is either missing or corrupted", "Sound File cannot be opened", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMalSpeech_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != "")
            {
                MLApp.MLApp matlab = new MLApp.MLApp();
                matlab.Visible = 0;
                matlab.Execute("VoiceChange('" + txtFilePath.Text + "',0)");
            }
            else
                MessageBox.Show("Select a file", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFemSpeech_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != "")
            {
                MLApp.MLApp matlab = new MLApp.MLApp();
                matlab.Visible = 0;
                matlab.Execute("VoiceChange('" + txtFilePath.Text + "',1)");
            }
            else
                MessageBox.Show("Select a file", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
