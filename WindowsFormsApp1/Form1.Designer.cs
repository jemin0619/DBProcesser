namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.INPUT_button = new System.Windows.Forms.Button();
            this.INPUT_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.READ_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // INPUT_button
            // 
            this.INPUT_button.Location = new System.Drawing.Point(584, 47);
            this.INPUT_button.Name = "INPUT_button";
            this.INPUT_button.Size = new System.Drawing.Size(43, 28);
            this.INPUT_button.TabIndex = 0;
            this.INPUT_button.Text = "...";
            this.INPUT_button.UseVisualStyleBackColor = true;
            this.INPUT_button.Click += new System.EventHandler(this.INPUT_button_Click);
            // 
            // INPUT_textbox
            // 
            this.INPUT_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.INPUT_textbox.Location = new System.Drawing.Point(149, 47);
            this.INPUT_textbox.Name = "INPUT_textbox";
            this.INPUT_textbox.ReadOnly = true;
            this.INPUT_textbox.Size = new System.Drawing.Size(429, 28);
            this.INPUT_textbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(149, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(478, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // READ_button
            // 
            this.READ_button.Location = new System.Drawing.Point(507, 92);
            this.READ_button.Name = "READ_button";
            this.READ_button.Size = new System.Drawing.Size(120, 32);
            this.READ_button.TabIndex = 3;
            this.READ_button.Text = "Read Xlsx";
            this.READ_button.UseVisualStyleBackColor = true;
            this.READ_button.Click += new System.EventHandler(this.READ_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 95);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.READ_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.INPUT_textbox);
            this.Controls.Add(this.INPUT_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button INPUT_button;
        private System.Windows.Forms.TextBox INPUT_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button READ_button;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

