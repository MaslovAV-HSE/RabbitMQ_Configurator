namespace Бокеры_сообщений
{
    partial class FinalStep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.node_type = new System.Windows.Forms.Label();
            this.config_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.save_conf = new System.Windows.Forms.Button();
            this.save_log = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.node_type);
            this.groupBox1.Controls.Add(this.config_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус";
            // 
            // node_type
            // 
            this.node_type.AutoSize = true;
            this.node_type.Location = new System.Drawing.Point(482, 33);
            this.node_type.Name = "node_type";
            this.node_type.Size = new System.Drawing.Size(0, 20);
            this.node_type.TabIndex = 4;
            // 
            // config_name
            // 
            this.config_name.AutoSize = true;
            this.config_name.Location = new System.Drawing.Point(159, 33);
            this.config_name.Name = "config_name";
            this.config_name.Size = new System.Drawing.Size(0, 20);
            this.config_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип узлов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя конфигурации:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(6, 67);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(764, 298);
            this.statusTextBox.TabIndex = 0;
            this.statusTextBox.Text = "";
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(665, 389);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(117, 49);
            this.btn_finish.TabIndex = 6;
            this.btn_finish.Text = "Закрыть";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // save_conf
            // 
            this.save_conf.Location = new System.Drawing.Point(177, 389);
            this.save_conf.Name = "save_conf";
            this.save_conf.Size = new System.Drawing.Size(153, 49);
            this.save_conf.TabIndex = 8;
            this.save_conf.Text = "Сохранить конфигурацию";
            this.save_conf.UseVisualStyleBackColor = true;
            this.save_conf.Click += new System.EventHandler(this.save_conf_Click);
            // 
            // save_log
            // 
            this.save_log.Location = new System.Drawing.Point(18, 389);
            this.save_log.Name = "save_log";
            this.save_log.Size = new System.Drawing.Size(153, 49);
            this.save_log.TabIndex = 9;
            this.save_log.Text = "Сохранить лог";
            this.save_log.UseVisualStyleBackColor = true;
            this.save_log.Click += new System.EventHandler(this.save_log_Click);
            // 
            // FinalStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_log);
            this.Controls.Add(this.save_conf);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinalStep";
            this.Text = "Конфигуратор сети брокеров RabbitMQ";
            this.Load += new System.EventHandler(this.FinalStep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_finish;
        private RichTextBox statusTextBox;
        private Label label2;
        private Label label1;
        private Label node_type;
        private Label config_name;
        private Button save_conf;
        private Button save_log;
    }
}