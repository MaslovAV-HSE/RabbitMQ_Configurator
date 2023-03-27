namespace Бокеры_сообщений
{
    partial class Connections
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btd_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.node_type = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.containerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(662, 377);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(117, 49);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btd_del
            // 
            this.btd_del.Location = new System.Drawing.Point(184, 377);
            this.btd_del.Name = "btd_del";
            this.btd_del.Size = new System.Drawing.Size(117, 49);
            this.btd_del.TabIndex = 1;
            this.btd_del.Text = "Удалить";
            this.btd_del.UseVisualStyleBackColor = true;
            this.btd_del.Click += new System.EventHandler(this.btd_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(340, 377);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 49);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Изменить";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(490, 377);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 49);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(23, 377);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(117, 49);
            this.btn_apply.TabIndex = 4;
            this.btn_apply.Text = "Ок";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(23, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 298);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доступные подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип узлов:";
            // 
            // node_type
            // 
            this.node_type.AutoSize = true;
            this.node_type.Location = new System.Drawing.Point(110, 28);
            this.node_type.Name = "node_type";
            this.node_type.Size = new System.Drawing.Size(0, 20);
            this.node_type.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(755, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // containerDataBindingSource
            // 
            this.containerDataBindingSource.DataSource = typeof(Бокеры_сообщений.Models.ContainerData);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.node_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btd_del);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Connections";
            this.Text = "Конфигуратор сети брокеров RabbitMQ";
            this.Load += new System.EventHandler(this.Connections_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cancel;
        private Button btd_del;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_apply;
        private GroupBox groupBox1;
        private Label label1;
        private Label node_type;
        private DataGridView dataGridView1;
        private BindingSource containerDataBindingSource;
    }
}