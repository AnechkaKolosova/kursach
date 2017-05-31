namespace WindowsFormsApplication5
{
    partial class Buy
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.купитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.продатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.allFlatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.allFlatsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Хрущовка",
            "Панельный",
            "Новострой"});
			this.comboBox1.Location = new System.Drawing.Point(478, 101);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(188, 33);
			this.comboBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Параметры поиска";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Город";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Киев",
            "Харьков"});
			this.comboBox2.Location = new System.Drawing.Point(92, 101);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(215, 33);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(92, 160);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(215, 33);
			this.comboBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Район";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(347, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Тип дома";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(322, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Кол-во комнат";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.comboBox4.Location = new System.Drawing.Point(486, 157);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(180, 33);
			this.comboBox4.TabIndex = 9;
			this.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(689, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 25);
			this.label6.TabIndex = 10;
			this.label6.Text = "Этаж";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(936, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 25);
			this.label7.TabIndex = 11;
			this.label7.Text = "от";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(1023, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 25);
			this.label8.TabIndex = 12;
			this.label8.Text = "до";
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15"});
			this.comboBox5.Location = new System.Drawing.Point(922, 106);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(67, 33);
			this.comboBox5.TabIndex = 13;
			this.comboBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox5_KeyPress);
			// 
			// comboBox6
			// 
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
			this.comboBox6.Location = new System.Drawing.Point(1010, 106);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(67, 33);
			this.comboBox6.TabIndex = 14;
			// 
			// comboBox7
			// 
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Items.AddRange(new object[] {
            "10"});
			this.comboBox7.Location = new System.Drawing.Point(922, 154);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(67, 33);
			this.comboBox7.TabIndex = 15;
			// 
			// comboBox8
			// 
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(1010, 154);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(67, 33);
			this.comboBox8.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(689, 157);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(218, 25);
			this.label9.TabIndex = 19;
			this.label9.Text = "Жил. площадь(кв.м.)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1121, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(396, 94);
			this.button1.TabIndex = 21;
			this.button1.Text = "ПОИСК";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dataGridView1.Location = new System.Drawing.Point(12, 269);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 33;
			this.dataGridView1.Size = new System.Drawing.Size(1500, 430);
			this.dataGridView1.TabIndex = 22;
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Город";
			this.Column1.MinimumWidth = 10;
			this.Column1.Name = "Column1";
			this.Column1.Width = 150;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Район";
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Тип квартиры";
			this.Column3.MinimumWidth = 10;
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Кол-во комнат";
			this.Column4.Name = "Column4";
			this.Column4.Width = 85;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Этаж";
			this.Column5.Name = "Column5";
			this.Column5.Width = 85;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Жил.площадь";
			this.Column6.Name = "Column6";
			this.Column6.Width = 85;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.купитьToolStripMenuItem,
            this.продатьToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1630, 40);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// главнаяToolStripMenuItem
			// 
			this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
			this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
			this.главнаяToolStripMenuItem.Text = "Главная";
			this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
			// 
			// купитьToolStripMenuItem
			// 
			this.купитьToolStripMenuItem.Name = "купитьToolStripMenuItem";
			this.купитьToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
			this.купитьToolStripMenuItem.Text = "Купить";
			this.купитьToolStripMenuItem.Click += new System.EventHandler(this.купитьToolStripMenuItem_Click);
			// 
			// продатьToolStripMenuItem
			// 
			this.продатьToolStripMenuItem.Name = "продатьToolStripMenuItem";
			this.продатьToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
			this.продатьToolStripMenuItem.Text = "Продать";
			this.продатьToolStripMenuItem.Click += new System.EventHandler(this.продатьToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(689, 215);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 25);
			this.label10.TabIndex = 24;
			this.label10.Text = "Цена";
			// 
			// comboBox9
			// 
			this.comboBox9.FormattingEnabled = true;
			this.comboBox9.Items.AddRange(new object[] {
            "10"});
			this.comboBox9.Location = new System.Drawing.Point(922, 207);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(67, 33);
			this.comboBox9.TabIndex = 25;
			// 
			// comboBox10
			// 
			this.comboBox10.FormattingEnabled = true;
			this.comboBox10.Items.AddRange(new object[] {
            "10"});
			this.comboBox10.Location = new System.Drawing.Point(1010, 207);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(67, 33);
			this.comboBox10.TabIndex = 26;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1523, 71);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 82);
			this.button2.TabIndex = 27;
			this.button2.Text = "Подключить базу";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1121, 188);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(396, 52);
			this.button3.TabIndex = 28;
			this.button3.Text = "Ко всем квартирам";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Buy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1630, 699);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox10);
			this.Controls.Add(this.comboBox9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.comboBox8);
			this.Controls.Add(this.comboBox7);
			this.Controls.Add(this.comboBox6);
			this.Controls.Add(this.comboBox5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1656, 1000);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1656, 770);
			this.Name = "Buy";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buy";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.allFlatsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem купитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.BindingSource allFlatsBindingSource;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button3;
	}
}