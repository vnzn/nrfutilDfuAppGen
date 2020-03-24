using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using nrfjprogGUI;

namespace nrfutilDfuAppGen
{
    public partial class FormMain : Form, CliInterface
    {
        private const String backupDfuApplicationPrefix = "move app_dfu_package.zip app_dfu_package.zip.";
        private const String nrfutilCommandPefix = "nrfutil pkg generate ";
        private const String nrfutilCommandSuffix = "app_dfu_package.zip";


        public FormMain()
        {
            InitializeComponent();
        }


        private delegate void updateLogDelegate(String log);
        private void updateLog(String log)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new updateLogDelegate(updateLog), new object[] { log });
                }
                else
                {
                    textBoxLog.Text = log;
                }
            }
            catch
            {

            }
        }

        private delegate void updateGenerateButtonDelegate(Boolean isEnabled);
        private void updateGenerateButton(Boolean isEnabled)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new updateGenerateButtonDelegate(updateGenerateButton), new object[] { isEnabled });
                }
                else
                {
                    buttonGenerate.Enabled = isEnabled;
                }
            }
            catch
            {

            }
        }

        private void threadGenerate(object obj)
        {

            List<KeyValuePair<String, String>> kvpListParam = obj as List<KeyValuePair<String, String>>;
            Cli c = new Cli(this);


            c.Execute(backupDfuApplicationPrefix + (System.DateTime.UtcNow.ToUniversalTime().Ticks / 10000000).ToString());

            String cmd = nrfutilCommandPefix;
            foreach (KeyValuePair<String, String> kvp in kvpListParam)
            {
                cmd += kvp.Key + " ";
                cmd += kvp.Value + " ";
            }
            cmd += nrfutilCommandSuffix;
            c.Execute(cmd);
            Process proc = new Process();
            proc.StartInfo.FileName = "explorer";
            proc.StartInfo.Arguments = @"/select," + System.Windows.Forms.Application.ExecutablePath;
            proc.Start();
            updateGenerateButton(true);
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {

            DialogResult dr = openFileDialogHexFile.ShowDialog();
            String selectedFileName = openFileDialogHexFile.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(selectedFileName))
            {
                labelHexFilePath.Text = selectedFileName;
                buttonGenerate.Enabled = true;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            if (labelHexFilePath.Text.Length == 0)
            {
                MessageBox.Show("Need to Select a Hex File!");
                return;
            }
            if (String.IsNullOrEmpty(textBoxApplicationVersion.Text) == true)
            {
                MessageBox.Show("Need to Fill in the Application Version!");
                return;
            }
            if (String.IsNullOrEmpty(textBoxHardwareVersion.Text) == true)
            {
                MessageBox.Show("Need to Fill in the Hardware Version!");
                return;
            }
            if (String.IsNullOrEmpty(textBoxSoftDeviceVersion.Text) == true)
            {
                MessageBox.Show("Need to Fill in the SoftDevice Version!");
                return;
            }
            buttonGenerate.Enabled = false;

            List<KeyValuePair<String, String>> kvpListParam = new List<KeyValuePair<string, string>>();
            kvpListParam.Clear();
            kvpListParam.Add(new KeyValuePair<string, string>("--application-version", textBoxApplicationVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--hw-version", textBoxHardwareVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--sd-req", textBoxSoftDeviceVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--application", labelHexFilePath.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--key-file", Application.StartupPath + "\\private.key"));

            Thread thread = new Thread(new ParameterizedThreadStart(threadGenerate));
            thread.Start(kvpListParam);
        }

        public void CliInterfaceAnswerReceived(string answer)
        {
            updateLog(answer);
        }
    }
}
