namespace nrfutilDfuAppGen
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.labelHexFilePath = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxApplicationVersion = new System.Windows.Forms.TextBox();
            this.labelApplicationVersion = new System.Windows.Forms.Label();
            this.labelHardwareVersion = new System.Windows.Forms.Label();
            this.textBoxHardwareVersion = new System.Windows.Forms.TextBox();
            this.labelSoftDeviceVersion = new System.Windows.Forms.Label();
            this.textBoxSoftDeviceVersion = new System.Windows.Forms.TextBox();
            this.openFileDialogHexFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChooseFile.Location = new System.Drawing.Point(45, 121);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(157, 63);
            this.buttonChooseFile.TabIndex = 1;
            this.buttonChooseFile.Text = "Select Hex File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // labelHexFilePath
            // 
            this.labelHexFilePath.AutoSize = true;
            this.labelHexFilePath.Location = new System.Drawing.Point(43, 187);
            this.labelHexFilePath.Name = "labelHexFilePath";
            this.labelHexFilePath.Size = new System.Drawing.Size(17, 12);
            this.labelHexFilePath.TabIndex = 2;
            this.labelHexFilePath.Text = "./";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGenerate.Location = new System.Drawing.Point(45, 223);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(317, 118);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLog.Location = new System.Drawing.Point(13, 354);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(509, 135);
            this.textBoxLog.TabIndex = 4;
            // 
            // textBoxApplicationVersion
            // 
            this.textBoxApplicationVersion.Location = new System.Drawing.Point(161, 17);
            this.textBoxApplicationVersion.Name = "textBoxApplicationVersion";
            this.textBoxApplicationVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxApplicationVersion.TabIndex = 5;
            this.textBoxApplicationVersion.Text = "1";
            // 
            // labelApplicationVersion
            // 
            this.labelApplicationVersion.AutoSize = true;
            this.labelApplicationVersion.Location = new System.Drawing.Point(42, 21);
            this.labelApplicationVersion.Name = "labelApplicationVersion";
            this.labelApplicationVersion.Size = new System.Drawing.Size(113, 12);
            this.labelApplicationVersion.TabIndex = 6;
            this.labelApplicationVersion.Text = "ApplicationVersion";
            // 
            // labelHardwareVersion
            // 
            this.labelHardwareVersion.AutoSize = true;
            this.labelHardwareVersion.Location = new System.Drawing.Point(42, 57);
            this.labelHardwareVersion.Name = "labelHardwareVersion";
            this.labelHardwareVersion.Size = new System.Drawing.Size(95, 12);
            this.labelHardwareVersion.TabIndex = 8;
            this.labelHardwareVersion.Text = "HardwareVersion";
            // 
            // textBoxHardwareVersion
            // 
            this.textBoxHardwareVersion.Location = new System.Drawing.Point(161, 53);
            this.textBoxHardwareVersion.Name = "textBoxHardwareVersion";
            this.textBoxHardwareVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxHardwareVersion.TabIndex = 7;
            this.textBoxHardwareVersion.Text = "52";
            // 
            // labelSoftDeviceVersion
            // 
            this.labelSoftDeviceVersion.AutoSize = true;
            this.labelSoftDeviceVersion.Location = new System.Drawing.Point(42, 93);
            this.labelSoftDeviceVersion.Name = "labelSoftDeviceVersion";
            this.labelSoftDeviceVersion.Size = new System.Drawing.Size(107, 12);
            this.labelSoftDeviceVersion.TabIndex = 10;
            this.labelSoftDeviceVersion.Text = "SoftDeviceVersion";
            // 
            // textBoxSoftDeviceVersion
            // 
            this.textBoxSoftDeviceVersion.Location = new System.Drawing.Point(161, 89);
            this.textBoxSoftDeviceVersion.Name = "textBoxSoftDeviceVersion";
            this.textBoxSoftDeviceVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxSoftDeviceVersion.TabIndex = 9;
            this.textBoxSoftDeviceVersion.Text = "0xCB";
            // 
            // openFileDialogHexFile
            // 
            this.openFileDialogHexFile.Filter = "Hex(*.hex)|*.hex";
            this.openFileDialogHexFile.InitialDirectory = "./";
            this.openFileDialogHexFile.Title = "Select the Hex File";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.labelSoftDeviceVersion);
            this.Controls.Add(this.textBoxSoftDeviceVersion);
            this.Controls.Add(this.labelHardwareVersion);
            this.Controls.Add(this.textBoxHardwareVersion);
            this.Controls.Add(this.labelApplicationVersion);
            this.Controls.Add(this.textBoxApplicationVersion);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelHexFilePath);
            this.Controls.Add(this.buttonChooseFile);
            this.Name = "FormMain";
            this.Text = "nrfutilDfuAppGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Label labelHexFilePath;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxApplicationVersion;
        private System.Windows.Forms.Label labelApplicationVersion;
        private System.Windows.Forms.Label labelHardwareVersion;
        private System.Windows.Forms.TextBox textBoxHardwareVersion;
        private System.Windows.Forms.Label labelSoftDeviceVersion;
        private System.Windows.Forms.TextBox textBoxSoftDeviceVersion;
        private System.Windows.Forms.OpenFileDialog openFileDialogHexFile;
    }
}

