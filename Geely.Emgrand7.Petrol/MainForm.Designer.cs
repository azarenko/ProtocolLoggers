namespace Geely.Emgrand7.Petrol
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._portNames = new System.Windows.Forms.ComboBox();
            this._connect = new System.Windows.Forms.Button();
            this._disconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._filePath = new System.Windows.Forms.TextBox();
            this.selectFile = new System.Windows.Forms.Button();
            this._startLog = new System.Windows.Forms.Button();
            this._stopLog = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com port:";
            // 
            // _portNames
            // 
            this._portNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._portNames.FormattingEnabled = true;
            this._portNames.Location = new System.Drawing.Point(81, 21);
            this._portNames.Name = "_portNames";
            this._portNames.Size = new System.Drawing.Size(100, 21);
            this._portNames.TabIndex = 1;
            // 
            // _connect
            // 
            this._connect.Location = new System.Drawing.Point(23, 48);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(75, 23);
            this._connect.TabIndex = 2;
            this._connect.Text = "Connect";
            this._connect.UseVisualStyleBackColor = true;
            this._connect.Click += new System.EventHandler(this._connect_Click);
            // 
            // _disconnect
            // 
            this._disconnect.Location = new System.Drawing.Point(106, 48);
            this._disconnect.Name = "_disconnect";
            this._disconnect.Size = new System.Drawing.Size(75, 23);
            this._disconnect.TabIndex = 3;
            this._disconnect.Text = "Disconnect";
            this._disconnect.UseVisualStyleBackColor = true;
            this._disconnect.Click += new System.EventHandler(this._disconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._disconnect);
            this.groupBox1.Controls.Add(this._portNames);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cc/min";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Injector flow:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(344, 123);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._stopLog);
            this.groupBox3.Controls.Add(this._startLog);
            this.groupBox3.Controls.Add(this.selectFile);
            this.groupBox3.Controls.Add(this._filePath);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 78);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log file";
            // 
            // _filePath
            // 
            this._filePath.Location = new System.Drawing.Point(6, 19);
            this._filePath.Name = "_filePath";
            this._filePath.Size = new System.Drawing.Size(302, 20);
            this._filePath.TabIndex = 0;
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(314, 17);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(35, 23);
            this.selectFile.TabIndex = 1;
            this.selectFile.Text = "...";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // _startLog
            // 
            this._startLog.Location = new System.Drawing.Point(6, 45);
            this._startLog.Name = "_startLog";
            this._startLog.Size = new System.Drawing.Size(75, 23);
            this._startLog.TabIndex = 2;
            this._startLog.Text = "Start";
            this._startLog.UseVisualStyleBackColor = true;
            this._startLog.Click += new System.EventHandler(this._startLog_Click);
            // 
            // _stopLog
            // 
            this._stopLog.Location = new System.Drawing.Point(87, 45);
            this._stopLog.Name = "_stopLog";
            this._stopLog.Size = new System.Drawing.Size(75, 23);
            this._stopLog.TabIndex = 3;
            this._stopLog.Text = "Stop";
            this._stopLog.UseVisualStyleBackColor = true;
            this._stopLog.Click += new System.EventHandler(this._stopLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Geely.Emgrand7.Petrol by Azarenko S.A.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _portNames;
        private System.Windows.Forms.Button _connect;
        private System.Windows.Forms.Button _disconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _stopLog;
        private System.Windows.Forms.Button _startLog;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.TextBox _filePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

