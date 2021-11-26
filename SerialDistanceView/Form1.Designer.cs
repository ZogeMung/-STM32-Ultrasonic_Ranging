namespace SerialDistanceView
{
    partial class SerialDistanceView
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.DistanceBar = new System.Windows.Forms.ProgressBar();
            this.DistanceText = new System.Windows.Forms.Label();
            this.OpenSerial = new System.Windows.Forms.Button();
            this.CloseSerial = new System.Windows.Forms.Button();
            this.SerialPortName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // DistanceBar
            // 
            this.DistanceBar.Location = new System.Drawing.Point(12, 67);
            this.DistanceBar.Maximum = 60;
            this.DistanceBar.Name = "DistanceBar";
            this.DistanceBar.Size = new System.Drawing.Size(960, 50);
            this.DistanceBar.Step = 1;
            this.DistanceBar.TabIndex = 0;
            // 
            // DistanceText
            // 
            this.DistanceText.AutoSize = true;
            this.DistanceText.Font = new System.Drawing.Font("宋体", 16F);
            this.DistanceText.Location = new System.Drawing.Point(8, 21);
            this.DistanceText.Name = "DistanceText";
            this.DistanceText.Size = new System.Drawing.Size(120, 22);
            this.DistanceText.TabIndex = 1;
            this.DistanceText.Text = "Distance: ";
            // 
            // OpenSerial
            // 
            this.OpenSerial.Location = new System.Drawing.Point(781, 18);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(80, 35);
            this.OpenSerial.TabIndex = 2;
            this.OpenSerial.Text = "OpenSerial";
            this.OpenSerial.UseVisualStyleBackColor = true;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // CloseSerial
            // 
            this.CloseSerial.Location = new System.Drawing.Point(882, 18);
            this.CloseSerial.Name = "CloseSerial";
            this.CloseSerial.Size = new System.Drawing.Size(80, 35);
            this.CloseSerial.TabIndex = 3;
            this.CloseSerial.Text = "CloseSerial";
            this.CloseSerial.UseVisualStyleBackColor = true;
            this.CloseSerial.Click += new System.EventHandler(this.CloseSerial_Click);
            // 
            // SerialPortName
            // 
            this.SerialPortName.Font = new System.Drawing.Font("Arial", 16F);
            this.SerialPortName.FormattingEnabled = true;
            this.SerialPortName.Items.AddRange(new object[] {
            "dsdf",
            "sdfsd"});
            this.SerialPortName.Location = new System.Drawing.Point(670, 21);
            this.SerialPortName.Name = "SerialPortName";
            this.SerialPortName.Size = new System.Drawing.Size(90, 32);
            this.SerialPortName.TabIndex = 5;
            this.SerialPortName.SelectedIndexChanged += new System.EventHandler(this.SerialPortName_SelectedIndexChanged);
            // 
            // SerialDistanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 136);
            this.Controls.Add(this.SerialPortName);
            this.Controls.Add(this.CloseSerial);
            this.Controls.Add(this.OpenSerial);
            this.Controls.Add(this.DistanceText);
            this.Controls.Add(this.DistanceBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialDistanceView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialDistanceView";
            this.Load += new System.EventHandler(this.SerialDistanceView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar DistanceBar;
        private System.Windows.Forms.Label DistanceText;
        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.Button CloseSerial;
        private System.Windows.Forms.ComboBox SerialPortName;
    }
}

