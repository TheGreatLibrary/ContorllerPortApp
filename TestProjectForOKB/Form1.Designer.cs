namespace TestProjectForOKB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxHandshake = new System.Windows.Forms.ComboBox();
            this.ConnectOn = new System.Windows.Forms.Button();
            this.textBoxPressure = new System.Windows.Forms.TextBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConnectOff = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(559, 44);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(141, 21);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(559, 80);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(141, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(559, 154);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(141, 21);
            this.comboBoxParity.TabIndex = 2;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "4",
            "5",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(559, 118);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(141, 21);
            this.comboBoxDataBits.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(451, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Бит в секунду:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(460, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Биты данных:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(482, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Четность:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(443, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стоповые биты:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(559, 194);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(141, 21);
            this.comboBoxStopBits.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(459, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выбор порта:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(404, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Управление потоком:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxHandshake
            // 
            this.comboBoxHandshake.FormattingEnabled = true;
            this.comboBoxHandshake.Location = new System.Drawing.Point(559, 231);
            this.comboBoxHandshake.Name = "comboBoxHandshake";
            this.comboBoxHandshake.Size = new System.Drawing.Size(141, 21);
            this.comboBoxHandshake.TabIndex = 10;
            // 
            // ConnectOn
            // 
            this.ConnectOn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConnectOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectOn.ForeColor = System.Drawing.Color.Cornsilk;
            this.ConnectOn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConnectOn.Location = new System.Drawing.Point(559, 300);
            this.ConnectOn.Name = "ConnectOn";
            this.ConnectOn.Size = new System.Drawing.Size(141, 23);
            this.ConnectOn.TabIndex = 12;
            this.ConnectOn.Text = "Подключиться";
            this.ConnectOn.UseVisualStyleBackColor = false;
            this.ConnectOn.Click += new System.EventHandler(this.ConnectOn_Click);
            // 
            // textBoxPressure
            // 
            this.textBoxPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxPressure.Location = new System.Drawing.Point(12, 44);
            this.textBoxPressure.Multiline = true;
            this.textBoxPressure.Name = "textBoxPressure";
            this.textBoxPressure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPressure.Size = new System.Drawing.Size(174, 175);
            this.textBoxPressure.TabIndex = 13;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxTemperature.Location = new System.Drawing.Point(218, 44);
            this.textBoxTemperature.Multiline = true;
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTemperature.Size = new System.Drawing.Size(174, 184);
            this.textBoxTemperature.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Давление:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(215, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Температура";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxStatus.Location = new System.Drawing.Point(12, 259);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(380, 65);
            this.textBoxStatus.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Строка состояния:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(497, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Настройки порта";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConnectOff
            // 
            this.ConnectOff.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConnectOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectOff.ForeColor = System.Drawing.Color.Cornsilk;
            this.ConnectOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConnectOff.Location = new System.Drawing.Point(407, 300);
            this.ConnectOff.Name = "ConnectOff";
            this.ConnectOff.Size = new System.Drawing.Size(141, 23);
            this.ConnectOff.TabIndex = 20;
            this.ConnectOff.Text = "Отключиться";
            this.ConnectOff.UseVisualStyleBackColor = false;
            this.ConnectOff.Click += new System.EventHandler(this.ConnectOff_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(409, 260);
            this.label11.MaximumSize = new System.Drawing.Size(325, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Чтобы переподключить COM-порт, сначала нужно отключиться";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 336);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ConnectOff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.textBoxPressure);
            this.Controls.Add(this.ConnectOn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHandshake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxPorts);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Контроллер COM-порта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxHandshake;
        private System.Windows.Forms.Button ConnectOn;
        private System.Windows.Forms.TextBox textBoxPressure;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ConnectOff;
        private System.Windows.Forms.Label label11;
    }
}

