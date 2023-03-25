namespace Бокеры_сообщений
{
    partial class Configuration
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pages = new System.Windows.Forms.TabControl();
            this.networkOptions = new System.Windows.Forms.TabPage();
            this.userOptions = new System.Windows.Forms.TabPage();
            this.additionalOption = new System.Windows.Forms.TabPage();
            this.resourceOptions = new System.Windows.Forms.TabPage();
            this.statisticsOptions = new System.Windows.Forms.TabPage();
            this.configurationOptions = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pages.SuspendLayout();
            this.networkOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(797, 442);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 39);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(663, 442);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(118, 39);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Применить";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pages
            // 
            this.pages.Controls.Add(this.configurationOptions);
            this.pages.Controls.Add(this.networkOptions);
            this.pages.Controls.Add(this.userOptions);
            this.pages.Controls.Add(this.additionalOption);
            this.pages.Controls.Add(this.resourceOptions);
            this.pages.Controls.Add(this.statisticsOptions);
            this.pages.Location = new System.Drawing.Point(9, 12);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(906, 425);
            this.pages.TabIndex = 7;
            // 
            // networkOptions
            // 
            this.networkOptions.Controls.Add(this.textBox4);
            this.networkOptions.Controls.Add(this.label7);
            this.networkOptions.Controls.Add(this.label8);
            this.networkOptions.Controls.Add(this.textBox3);
            this.networkOptions.Controls.Add(this.label5);
            this.networkOptions.Controls.Add(this.label6);
            this.networkOptions.Controls.Add(this.textBox2);
            this.networkOptions.Controls.Add(this.label3);
            this.networkOptions.Controls.Add(this.label4);
            this.networkOptions.Controls.Add(this.textBox1);
            this.networkOptions.Controls.Add(this.label2);
            this.networkOptions.Controls.Add(this.label1);
            this.networkOptions.Location = new System.Drawing.Point(4, 29);
            this.networkOptions.Name = "networkOptions";
            this.networkOptions.Padding = new System.Windows.Forms.Padding(3);
            this.networkOptions.Size = new System.Drawing.Size(898, 392);
            this.networkOptions.TabIndex = 0;
            this.networkOptions.Text = "Настройки сети";
            this.networkOptions.UseVisualStyleBackColor = true;
            // 
            // userOptions
            // 
            this.userOptions.Location = new System.Drawing.Point(4, 29);
            this.userOptions.Name = "userOptions";
            this.userOptions.Padding = new System.Windows.Forms.Padding(3);
            this.userOptions.Size = new System.Drawing.Size(898, 392);
            this.userOptions.TabIndex = 1;
            this.userOptions.Text = "Настройки доступа";
            this.userOptions.UseVisualStyleBackColor = true;
            // 
            // additionalOption
            // 
            this.additionalOption.Location = new System.Drawing.Point(4, 29);
            this.additionalOption.Name = "additionalOption";
            this.additionalOption.Padding = new System.Windows.Forms.Padding(3);
            this.additionalOption.Size = new System.Drawing.Size(898, 392);
            this.additionalOption.TabIndex = 2;
            this.additionalOption.Text = "Дополнительные настройки";
            this.additionalOption.UseVisualStyleBackColor = true;
            // 
            // resourceOptions
            // 
            this.resourceOptions.Location = new System.Drawing.Point(4, 29);
            this.resourceOptions.Name = "resourceOptions";
            this.resourceOptions.Padding = new System.Windows.Forms.Padding(3);
            this.resourceOptions.Size = new System.Drawing.Size(898, 392);
            this.resourceOptions.TabIndex = 3;
            this.resourceOptions.Text = "Доступ к ресурсам";
            this.resourceOptions.UseVisualStyleBackColor = true;
            // 
            // statisticsOptions
            // 
            this.statisticsOptions.Location = new System.Drawing.Point(4, 29);
            this.statisticsOptions.Name = "statisticsOptions";
            this.statisticsOptions.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsOptions.Size = new System.Drawing.Size(898, 392);
            this.statisticsOptions.TabIndex = 4;
            this.statisticsOptions.Text = "Статистические настройки";
            this.statisticsOptions.UseVisualStyleBackColor = true;
            // 
            // configurationOptions
            // 
            this.configurationOptions.Location = new System.Drawing.Point(4, 29);
            this.configurationOptions.Name = "configurationOptions";
            this.configurationOptions.Padding = new System.Windows.Forms.Padding(3);
            this.configurationOptions.Size = new System.Drawing.Size(898, 392);
            this.configurationOptions.TabIndex = 5;
            this.configurationOptions.Text = "Общие настройки";
            this.configurationOptions.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(731, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(731, 27);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(731, 27);
            this.textBox3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 272);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(731, 27);
            this.textBox4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 493);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Configuration";
            this.Text = "Конфигуратор сети брокеров RabbitMQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuration_FormClosing);
            this.pages.ResumeLayout(false);
            this.networkOptions.ResumeLayout(false);
            this.networkOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_cancel;
        private Button btn_ok;
        private TabControl pages;
        private TabPage networkOptions;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TabPage userOptions;
        private TabPage additionalOption;
        private TabPage resourceOptions;
        private TabPage statisticsOptions;
        private TabPage configurationOptions;
    }
}