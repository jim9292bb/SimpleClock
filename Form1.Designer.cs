namespace SimpleClock
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.StartAlarmButton = new System.Windows.Forms.Button();
            this.StopAlarmButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HourComboBox1 = new System.Windows.Forms.ComboBox();
            this.MinuteComboBox1 = new System.Windows.Forms.ComboBox();
            this.MinuteComboBox4 = new System.Windows.Forms.ComboBox();
            this.HourComboBox4 = new System.Windows.Forms.ComboBox();
            this.MinuteComboBox5 = new System.Windows.Forms.ComboBox();
            this.HourComboBox5 = new System.Windows.Forms.ComboBox();
            this.MinuteComboBox3 = new System.Windows.Forms.ComboBox();
            this.HourComboBox3 = new System.Windows.Forms.ComboBox();
            this.MinuteComboBox2 = new System.Windows.Forms.ComboBox();
            this.HourComboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(253, 26);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(284, 33);
            this.txtTime.TabIndex = 0;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartAlarmButton
            // 
            this.StartAlarmButton.Location = new System.Drawing.Point(296, 333);
            this.StartAlarmButton.Name = "StartAlarmButton";
            this.StartAlarmButton.Size = new System.Drawing.Size(205, 39);
            this.StartAlarmButton.TabIndex = 1;
            this.StartAlarmButton.Text = "啟動鬧鐘";
            this.StartAlarmButton.UseVisualStyleBackColor = true;
            this.StartAlarmButton.Click += new System.EventHandler(this.StartAlarmButton_Click);
            // 
            // StopAlarmButton
            // 
            this.StopAlarmButton.Location = new System.Drawing.Point(296, 390);
            this.StopAlarmButton.Name = "StopAlarmButton";
            this.StopAlarmButton.Size = new System.Drawing.Size(205, 39);
            this.StopAlarmButton.TabIndex = 2;
            this.StopAlarmButton.Text = "關閉鬧鐘";
            this.StopAlarmButton.UseVisualStyleBackColor = true;
            this.StopAlarmButton.Click += new System.EventHandler(this.StopAlarmButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // HourComboBox1
            // 
            this.HourComboBox1.Font = new System.Drawing.Font("新細明體", 16F);
            this.HourComboBox1.FormattingEnabled = true;
            this.HourComboBox1.Location = new System.Drawing.Point(253, 79);
            this.HourComboBox1.Name = "HourComboBox1";
            this.HourComboBox1.Size = new System.Drawing.Size(121, 29);
            this.HourComboBox1.TabIndex = 3;
            // 
            // MinuteComboBox1
            // 
            this.MinuteComboBox1.Font = new System.Drawing.Font("新細明體", 16F);
            this.MinuteComboBox1.FormattingEnabled = true;
            this.MinuteComboBox1.Location = new System.Drawing.Point(416, 79);
            this.MinuteComboBox1.Name = "MinuteComboBox1";
            this.MinuteComboBox1.Size = new System.Drawing.Size(121, 29);
            this.MinuteComboBox1.TabIndex = 4;
            // 
            // MinuteComboBox4
            // 
            this.MinuteComboBox4.Font = new System.Drawing.Font("新細明體", 16F);
            this.MinuteComboBox4.FormattingEnabled = true;
            this.MinuteComboBox4.Location = new System.Drawing.Point(416, 232);
            this.MinuteComboBox4.Name = "MinuteComboBox4";
            this.MinuteComboBox4.Size = new System.Drawing.Size(121, 29);
            this.MinuteComboBox4.TabIndex = 6;
            // 
            // HourComboBox4
            // 
            this.HourComboBox4.Font = new System.Drawing.Font("新細明體", 16F);
            this.HourComboBox4.FormattingEnabled = true;
            this.HourComboBox4.Location = new System.Drawing.Point(253, 232);
            this.HourComboBox4.Name = "HourComboBox4";
            this.HourComboBox4.Size = new System.Drawing.Size(121, 29);
            this.HourComboBox4.TabIndex = 5;
            // 
            // MinuteComboBox5
            // 
            this.MinuteComboBox5.Font = new System.Drawing.Font("新細明體", 16F);
            this.MinuteComboBox5.FormattingEnabled = true;
            this.MinuteComboBox5.Location = new System.Drawing.Point(416, 287);
            this.MinuteComboBox5.Name = "MinuteComboBox5";
            this.MinuteComboBox5.Size = new System.Drawing.Size(121, 29);
            this.MinuteComboBox5.TabIndex = 8;
            // 
            // HourComboBox5
            // 
            this.HourComboBox5.Font = new System.Drawing.Font("新細明體", 16F);
            this.HourComboBox5.FormattingEnabled = true;
            this.HourComboBox5.Location = new System.Drawing.Point(253, 287);
            this.HourComboBox5.Name = "HourComboBox5";
            this.HourComboBox5.Size = new System.Drawing.Size(121, 29);
            this.HourComboBox5.TabIndex = 7;
            // 
            // MinuteComboBox3
            // 
            this.MinuteComboBox3.Font = new System.Drawing.Font("新細明體", 16F);
            this.MinuteComboBox3.FormattingEnabled = true;
            this.MinuteComboBox3.Location = new System.Drawing.Point(416, 180);
            this.MinuteComboBox3.Name = "MinuteComboBox3";
            this.MinuteComboBox3.Size = new System.Drawing.Size(121, 29);
            this.MinuteComboBox3.TabIndex = 10;
            // 
            // HourComboBox3
            // 
            this.HourComboBox3.Font = new System.Drawing.Font("新細明體", 16F);
            this.HourComboBox3.FormattingEnabled = true;
            this.HourComboBox3.Location = new System.Drawing.Point(253, 180);
            this.HourComboBox3.Name = "HourComboBox3";
            this.HourComboBox3.Size = new System.Drawing.Size(121, 29);
            this.HourComboBox3.TabIndex = 9;
            // 
            // MinuteComboBox2
            // 
            this.MinuteComboBox2.Font = new System.Drawing.Font("新細明體", 16F);
            this.MinuteComboBox2.FormattingEnabled = true;
            this.MinuteComboBox2.Location = new System.Drawing.Point(416, 130);
            this.MinuteComboBox2.Name = "MinuteComboBox2";
            this.MinuteComboBox2.Size = new System.Drawing.Size(121, 29);
            this.MinuteComboBox2.TabIndex = 12;
            // 
            // HourComboBox2
            // 
            this.HourComboBox2.Font = new System.Drawing.Font("新細明體", 16F);
            this.HourComboBox2.FormattingEnabled = true;
            this.HourComboBox2.Location = new System.Drawing.Point(253, 131);
            this.HourComboBox2.Name = "HourComboBox2";
            this.HourComboBox2.Size = new System.Drawing.Size(121, 29);
            this.HourComboBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinuteComboBox2);
            this.Controls.Add(this.HourComboBox2);
            this.Controls.Add(this.MinuteComboBox3);
            this.Controls.Add(this.HourComboBox3);
            this.Controls.Add(this.MinuteComboBox5);
            this.Controls.Add(this.HourComboBox5);
            this.Controls.Add(this.MinuteComboBox4);
            this.Controls.Add(this.HourComboBox4);
            this.Controls.Add(this.MinuteComboBox1);
            this.Controls.Add(this.HourComboBox1);
            this.Controls.Add(this.StopAlarmButton);
            this.Controls.Add(this.StartAlarmButton);
            this.Controls.Add(this.txtTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button StartAlarmButton;
        private System.Windows.Forms.Button StopAlarmButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox HourComboBox1;
        private System.Windows.Forms.ComboBox MinuteComboBox1;
        private System.Windows.Forms.ComboBox MinuteComboBox4;
        private System.Windows.Forms.ComboBox HourComboBox4;
        private System.Windows.Forms.ComboBox MinuteComboBox5;
        private System.Windows.Forms.ComboBox HourComboBox5;
        private System.Windows.Forms.ComboBox MinuteComboBox3;
        private System.Windows.Forms.ComboBox HourComboBox3;
        private System.Windows.Forms.ComboBox MinuteComboBox2;
        private System.Windows.Forms.ComboBox HourComboBox2;
    }
}

