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
            this.otherOptions = new System.Windows.Forms.TabPage();
            this.connectionType = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.configName = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.networkOptions = new System.Windows.Forms.TabPage();
            this.networkCB4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.networkTB3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.networkTB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.networkTB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userOptions = new System.Windows.Forms.TabPage();
            this.userCB1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.userTB3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.userTB2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.userTB4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.additionalOptions = new System.Windows.Forms.TabPage();
            this.additionalTB4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.additionalTB3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.additionalTB2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.additionalTB1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.resourceOptions = new System.Windows.Forms.TabPage();
            this.resoursesTB3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.resoursesTB2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.resoursesTB1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.statisticOptions = new System.Windows.Forms.TabPage();
            this.statisticTB1 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pages.SuspendLayout();
            this.otherOptions.SuspendLayout();
            this.networkOptions.SuspendLayout();
            this.userOptions.SuspendLayout();
            this.additionalOptions.SuspendLayout();
            this.resourceOptions.SuspendLayout();
            this.statisticOptions.SuspendLayout();
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
            this.pages.Controls.Add(this.otherOptions);
            this.pages.Controls.Add(this.networkOptions);
            this.pages.Controls.Add(this.userOptions);
            this.pages.Controls.Add(this.additionalOptions);
            this.pages.Controls.Add(this.resourceOptions);
            this.pages.Controls.Add(this.statisticOptions);
            this.pages.Location = new System.Drawing.Point(12, 11);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(906, 425);
            this.pages.TabIndex = 7;
            // 
            // otherOptions
            // 
            this.otherOptions.Controls.Add(this.connectionType);
            this.otherOptions.Controls.Add(this.label47);
            this.otherOptions.Controls.Add(this.configName);
            this.otherOptions.Controls.Add(this.label41);
            this.otherOptions.Location = new System.Drawing.Point(4, 29);
            this.otherOptions.Name = "otherOptions";
            this.otherOptions.Padding = new System.Windows.Forms.Padding(3);
            this.otherOptions.Size = new System.Drawing.Size(898, 392);
            this.otherOptions.TabIndex = 10;
            this.otherOptions.Text = "Общие";
            this.otherOptions.UseVisualStyleBackColor = true;
            // 
            // connectionType
            // 
            this.connectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionType.FormattingEnabled = true;
            this.connectionType.Items.AddRange(new object[] {
            "Сервер",
            "Контейнер"});
            this.connectionType.Location = new System.Drawing.Point(327, 107);
            this.connectionType.Name = "connectionType";
            this.connectionType.Size = new System.Drawing.Size(549, 28);
            this.connectionType.TabIndex = 4;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label47.Location = new System.Drawing.Point(26, 104);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(103, 31);
            this.label47.TabIndex = 3;
            this.label47.Text = "Тип узла";
            // 
            // configName
            // 
            this.configName.Location = new System.Drawing.Point(327, 23);
            this.configName.Name = "configName";
            this.configName.Size = new System.Drawing.Size(553, 27);
            this.configName.TabIndex = 2;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label41.Location = new System.Drawing.Point(26, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(217, 31);
            this.label41.TabIndex = 0;
            this.label41.Text = "Имя конфигурации";
            // 
            // networkOptions
            // 
            this.networkOptions.Controls.Add(this.networkCB4);
            this.networkOptions.Controls.Add(this.label7);
            this.networkOptions.Controls.Add(this.label8);
            this.networkOptions.Controls.Add(this.networkTB3);
            this.networkOptions.Controls.Add(this.label5);
            this.networkOptions.Controls.Add(this.label6);
            this.networkOptions.Controls.Add(this.networkTB2);
            this.networkOptions.Controls.Add(this.label3);
            this.networkOptions.Controls.Add(this.label4);
            this.networkOptions.Controls.Add(this.networkTB1);
            this.networkOptions.Controls.Add(this.label2);
            this.networkOptions.Controls.Add(this.label1);
            this.networkOptions.Location = new System.Drawing.Point(4, 29);
            this.networkOptions.Name = "networkOptions";
            this.networkOptions.Padding = new System.Windows.Forms.Padding(3);
            this.networkOptions.Size = new System.Drawing.Size(898, 392);
            this.networkOptions.TabIndex = 0;
            this.networkOptions.Text = "Сеть";
            this.networkOptions.UseVisualStyleBackColor = true;
            // 
            // networkCB4
            // 
            this.networkCB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkCB4.FormattingEnabled = true;
            this.networkCB4.Items.AddRange(new object[] {
            "false",
            "true"});
            this.networkCB4.Location = new System.Drawing.Point(485, 271);
            this.networkCB4.Name = "networkCB4";
            this.networkCB4.Size = new System.Drawing.Size(395, 28);
            this.networkCB4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(23, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
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
            // networkTB3
            // 
            this.networkTB3.Location = new System.Drawing.Point(485, 186);
            this.networkTB3.Name = "networkTB3";
            this.networkTB3.Size = new System.Drawing.Size(395, 27);
            this.networkTB3.TabIndex = 8;
            this.networkTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(23, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
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
            // networkTB2
            // 
            this.networkTB2.Location = new System.Drawing.Point(485, 105);
            this.networkTB2.Name = "networkTB2";
            this.networkTB2.Size = new System.Drawing.Size(395, 27);
            this.networkTB2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
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
            // networkTB1
            // 
            this.networkTB1.Location = new System.Drawing.Point(485, 23);
            this.networkTB1.Name = "networkTB1";
            this.networkTB1.Size = new System.Drawing.Size(395, 27);
            this.networkTB1.TabIndex = 2;
            this.networkTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            // userOptions
            // 
            this.userOptions.Controls.Add(this.userCB1);
            this.userOptions.Controls.Add(this.label10);
            this.userOptions.Controls.Add(this.label11);
            this.userOptions.Controls.Add(this.userTB3);
            this.userOptions.Controls.Add(this.label12);
            this.userOptions.Controls.Add(this.label13);
            this.userOptions.Controls.Add(this.userTB2);
            this.userOptions.Controls.Add(this.label14);
            this.userOptions.Controls.Add(this.label15);
            this.userOptions.Controls.Add(this.userTB4);
            this.userOptions.Controls.Add(this.label16);
            this.userOptions.Controls.Add(this.label9);
            this.userOptions.Location = new System.Drawing.Point(4, 29);
            this.userOptions.Name = "userOptions";
            this.userOptions.Padding = new System.Windows.Forms.Padding(3);
            this.userOptions.Size = new System.Drawing.Size(898, 392);
            this.userOptions.TabIndex = 6;
            this.userOptions.Text = "Доступ";
            this.userOptions.UseVisualStyleBackColor = true;
            // 
            // userCB1
            // 
            this.userCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCB1.FormattingEnabled = true;
            this.userCB1.Items.AddRange(new object[] {
            "false",
            "true"});
            this.userCB1.Location = new System.Drawing.Point(588, 22);
            this.userCB1.Name = "userCB1";
            this.userCB1.Size = new System.Drawing.Size(292, 28);
            this.userCB1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(26, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(26, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "label11";
            // 
            // userTB3
            // 
            this.userTB3.Location = new System.Drawing.Point(588, 191);
            this.userTB3.Name = "userTB3";
            this.userTB3.Size = new System.Drawing.Size(292, 27);
            this.userTB3.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(26, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(26, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 31);
            this.label13.TabIndex = 6;
            this.label13.Text = "label13";
            // 
            // userTB2
            // 
            this.userTB2.Location = new System.Drawing.Point(588, 104);
            this.userTB2.Name = "userTB2";
            this.userTB2.Size = new System.Drawing.Size(292, 27);
            this.userTB2.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(26, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(26, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 31);
            this.label15.TabIndex = 3;
            this.label15.Text = "label15";
            // 
            // userTB4
            // 
            this.userTB4.Location = new System.Drawing.Point(588, 277);
            this.userTB4.Name = "userTB4";
            this.userTB4.Size = new System.Drawing.Size(292, 27);
            this.userTB4.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(26, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "label16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "label9";
            // 
            // additionalOptions
            // 
            this.additionalOptions.Controls.Add(this.additionalTB4);
            this.additionalOptions.Controls.Add(this.label18);
            this.additionalOptions.Controls.Add(this.label19);
            this.additionalOptions.Controls.Add(this.additionalTB3);
            this.additionalOptions.Controls.Add(this.label20);
            this.additionalOptions.Controls.Add(this.label21);
            this.additionalOptions.Controls.Add(this.additionalTB2);
            this.additionalOptions.Controls.Add(this.label22);
            this.additionalOptions.Controls.Add(this.label23);
            this.additionalOptions.Controls.Add(this.additionalTB1);
            this.additionalOptions.Controls.Add(this.label24);
            this.additionalOptions.Controls.Add(this.label17);
            this.additionalOptions.Location = new System.Drawing.Point(4, 29);
            this.additionalOptions.Name = "additionalOptions";
            this.additionalOptions.Padding = new System.Windows.Forms.Padding(3);
            this.additionalOptions.Size = new System.Drawing.Size(898, 392);
            this.additionalOptions.TabIndex = 7;
            this.additionalOptions.Text = "Дополнительные";
            this.additionalOptions.UseVisualStyleBackColor = true;
            // 
            // additionalTB4
            // 
            this.additionalTB4.Location = new System.Drawing.Point(485, 302);
            this.additionalTB4.Name = "additionalTB4";
            this.additionalTB4.Size = new System.Drawing.Size(395, 27);
            this.additionalTB4.TabIndex = 11;
            this.additionalTB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(26, 336);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(26, 296);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 31);
            this.label19.TabIndex = 9;
            this.label19.Text = "label19";
            // 
            // additionalTB3
            // 
            this.additionalTB3.Location = new System.Drawing.Point(485, 211);
            this.additionalTB3.Name = "additionalTB3";
            this.additionalTB3.Size = new System.Drawing.Size(395, 27);
            this.additionalTB3.TabIndex = 8;
            this.additionalTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(26, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(26, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 31);
            this.label21.TabIndex = 6;
            this.label21.Text = "label21";
            // 
            // additionalTB2
            // 
            this.additionalTB2.Location = new System.Drawing.Point(485, 130);
            this.additionalTB2.Name = "additionalTB2";
            this.additionalTB2.Size = new System.Drawing.Size(395, 27);
            this.additionalTB2.TabIndex = 5;
            this.additionalTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(26, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 20);
            this.label22.TabIndex = 4;
            this.label22.Text = "label22";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(26, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 31);
            this.label23.TabIndex = 3;
            this.label23.Text = "label23";
            // 
            // additionalTB1
            // 
            this.additionalTB1.Location = new System.Drawing.Point(485, 23);
            this.additionalTB1.Name = "additionalTB1";
            this.additionalTB1.Size = new System.Drawing.Size(395, 27);
            this.additionalTB1.TabIndex = 2;
            this.additionalTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(26, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "label24";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(26, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 31);
            this.label17.TabIndex = 0;
            this.label17.Text = "label17";
            // 
            // resourceOptions
            // 
            this.resourceOptions.Controls.Add(this.resoursesTB3);
            this.resourceOptions.Controls.Add(this.label28);
            this.resourceOptions.Controls.Add(this.label29);
            this.resourceOptions.Controls.Add(this.resoursesTB2);
            this.resourceOptions.Controls.Add(this.label30);
            this.resourceOptions.Controls.Add(this.label31);
            this.resourceOptions.Controls.Add(this.resoursesTB1);
            this.resourceOptions.Controls.Add(this.label32);
            this.resourceOptions.Controls.Add(this.label25);
            this.resourceOptions.Location = new System.Drawing.Point(4, 29);
            this.resourceOptions.Name = "resourceOptions";
            this.resourceOptions.Padding = new System.Windows.Forms.Padding(3);
            this.resourceOptions.Size = new System.Drawing.Size(898, 392);
            this.resourceOptions.TabIndex = 8;
            this.resourceOptions.Text = "Ресурсы";
            this.resourceOptions.UseVisualStyleBackColor = true;
            // 
            // resoursesTB3
            // 
            this.resoursesTB3.Location = new System.Drawing.Point(582, 185);
            this.resoursesTB3.Name = "resoursesTB3";
            this.resoursesTB3.Size = new System.Drawing.Size(298, 27);
            this.resoursesTB3.TabIndex = 8;
            this.resoursesTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label28.Location = new System.Drawing.Point(26, 229);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 20);
            this.label28.TabIndex = 7;
            this.label28.Text = "label28";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(26, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 31);
            this.label29.TabIndex = 6;
            this.label29.Text = "label29";
            // 
            // resoursesTB2
            // 
            this.resoursesTB2.Location = new System.Drawing.Point(582, 104);
            this.resoursesTB2.Name = "resoursesTB2";
            this.resoursesTB2.Size = new System.Drawing.Size(298, 27);
            this.resoursesTB2.TabIndex = 5;
            this.resoursesTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label30.Location = new System.Drawing.Point(26, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 20);
            this.label30.TabIndex = 4;
            this.label30.Text = "label30";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(26, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 31);
            this.label31.TabIndex = 3;
            this.label31.Text = "label31";
            // 
            // resoursesTB1
            // 
            this.resoursesTB1.Location = new System.Drawing.Point(582, 23);
            this.resoursesTB1.Name = "resoursesTB1";
            this.resoursesTB1.Size = new System.Drawing.Size(298, 27);
            this.resoursesTB1.TabIndex = 2;
            this.resoursesTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label32.Location = new System.Drawing.Point(26, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 20);
            this.label32.TabIndex = 1;
            this.label32.Text = "label32";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(26, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 31);
            this.label25.TabIndex = 0;
            this.label25.Text = "label25";
            // 
            // statisticOptions
            // 
            this.statisticOptions.Controls.Add(this.statisticTB1);
            this.statisticOptions.Controls.Add(this.label40);
            this.statisticOptions.Controls.Add(this.label33);
            this.statisticOptions.Location = new System.Drawing.Point(4, 29);
            this.statisticOptions.Name = "statisticOptions";
            this.statisticOptions.Padding = new System.Windows.Forms.Padding(3);
            this.statisticOptions.Size = new System.Drawing.Size(898, 392);
            this.statisticOptions.TabIndex = 9;
            this.statisticOptions.Text = "Статистика";
            this.statisticOptions.UseVisualStyleBackColor = true;
            // 
            // statisticTB1
            // 
            this.statisticTB1.Location = new System.Drawing.Point(485, 23);
            this.statisticTB1.Name = "statisticTB1";
            this.statisticTB1.Size = new System.Drawing.Size(395, 27);
            this.statisticTB1.TabIndex = 2;
            this.statisticTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.networkTB1_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label40.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label40.Location = new System.Drawing.Point(26, 63);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 20);
            this.label40.TabIndex = 1;
            this.label40.Text = "label40";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(26, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 31);
            this.label33.TabIndex = 0;
            this.label33.Text = "label33";
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
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.pages.ResumeLayout(false);
            this.otherOptions.ResumeLayout(false);
            this.otherOptions.PerformLayout();
            this.networkOptions.ResumeLayout(false);
            this.networkOptions.PerformLayout();
            this.userOptions.ResumeLayout(false);
            this.userOptions.PerformLayout();
            this.additionalOptions.ResumeLayout(false);
            this.additionalOptions.PerformLayout();
            this.resourceOptions.ResumeLayout(false);
            this.resourceOptions.PerformLayout();
            this.statisticOptions.ResumeLayout(false);
            this.statisticOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_cancel;
        private Button btn_ok;
        private TabControl pages;
        private TabPage networkOptions;
        private Label label7;
        private Label label8;
        private TextBox networkTB3;
        private Label label5;
        private Label label6;
        private TextBox networkTB2;
        private Label label3;
        private Label label4;
        private TextBox networkTB1;
        private Label label2;
        private Label label1;
        private ComboBox networkCB4;
        private TabPage otherOptions;
        private Label label47;
        private TextBox configName;
        private Label label41;
        private TabPage userOptions;
        private ComboBox userCB1;
        private Label label10;
        private Label label11;
        private TextBox userTB3;
        private Label label12;
        private Label label13;
        private TextBox userTB2;
        private Label label14;
        private Label label15;
        private TextBox userTB4;
        private Label label16;
        private Label label9;
        private TabPage additionalOptions;
        private Label label18;
        private Label label19;
        private TextBox additionalTB3;
        private Label label20;
        private Label label21;
        private TextBox additionalTB2;
        private Label label22;
        private Label label23;
        private TextBox additionalTB1;
        private Label label24;
        private Label label17;
        private TabPage resourceOptions;
        private TextBox resoursesTB3;
        private Label label28;
        private Label label29;
        private TextBox resoursesTB2;
        private Label label30;
        private Label label31;
        private TextBox resoursesTB1;
        private Label label32;
        private Label label25;
        private TabPage statisticOptions;
        private TextBox statisticTB1;
        private Label label40;
        private Label label33;
        private TextBox additionalTB4;
        private ComboBox connectionType;
    }
}