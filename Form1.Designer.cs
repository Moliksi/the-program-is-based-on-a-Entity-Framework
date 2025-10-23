namespace WinEntityKozlow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПродуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПродуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.применитьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаОтАДоЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаОтЯДоАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.равноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.содержитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.отменитьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьДанныеВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьДанныеВWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётОКатегорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(356, 326);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(736, 94);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(486, 326);
            this.dataGridView2.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Список категорий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Список продуктов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПродуктToolStripMenuItem,
            this.добавитьКатегориюToolStripMenuItem,
            this.удалитьКатегориюToolStripMenuItem,
            this.удалитьПродуктToolStripMenuItem,
            this.применитьФильтрToolStripMenuItem,
            this.фильтрToolStripMenuItem,
            this.экспортироватьДанныеВExcelToolStripMenuItem,
            this.экспортироватьДанныеВWordToolStripMenuItem,
            this.отчётОКатегорииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1914, 35);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПродуктToolStripMenuItem
            // 
            this.добавитьПродуктToolStripMenuItem.Name = "добавитьПродуктToolStripMenuItem";
            this.добавитьПродуктToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.добавитьПродуктToolStripMenuItem.Text = "Добавить продукт";
            this.добавитьПродуктToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьПродуктToolStripMenuItem_Click);
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКатегориюToolStripMenuItem_Click);
            // 
            // удалитьКатегориюToolStripMenuItem
            // 
            this.удалитьКатегориюToolStripMenuItem.Name = "удалитьКатегориюToolStripMenuItem";
            this.удалитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.удалитьКатегориюToolStripMenuItem.Text = "Удалить категорию";
            this.удалитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.удалитьКатегориюToolStripMenuItem_Click);
            // 
            // удалитьПродуктToolStripMenuItem
            // 
            this.удалитьПродуктToolStripMenuItem.Name = "удалитьПродуктToolStripMenuItem";
            this.удалитьПродуктToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.удалитьПродуктToolStripMenuItem.Text = "Удалить продукт";
            this.удалитьПродуктToolStripMenuItem.Click += new System.EventHandler(this.удалитьПродуктToolStripMenuItem_Click);
            // 
            // применитьФильтрToolStripMenuItem
            // 
            this.применитьФильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаОтАДоЯToolStripMenuItem,
            this.сортировкаОтЯДоАToolStripMenuItem});
            this.применитьФильтрToolStripMenuItem.Name = "применитьФильтрToolStripMenuItem";
            this.применитьФильтрToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.применитьФильтрToolStripMenuItem.Text = "Сортировка";
            // 
            // сортировкаОтАДоЯToolStripMenuItem
            // 
            this.сортировкаОтАДоЯToolStripMenuItem.Name = "сортировкаОтАДоЯToolStripMenuItem";
            this.сортировкаОтАДоЯToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.сортировкаОтАДоЯToolStripMenuItem.Text = "Сортировка от А до Я";
            this.сортировкаОтАДоЯToolStripMenuItem.Click += new System.EventHandler(this.сортировкаОтАДоЯToolStripMenuItem_Click);
            // 
            // сортировкаОтЯДоАToolStripMenuItem
            // 
            this.сортировкаОтЯДоАToolStripMenuItem.Name = "сортировкаОтЯДоАToolStripMenuItem";
            this.сортировкаОтЯДоАToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.сортировкаОтЯДоАToolStripMenuItem.Text = "Сортировка от Я до А";
            this.сортировкаОтЯДоАToolStripMenuItem.Click += new System.EventHandler(this.сортировкаОтЯДоАToolStripMenuItem_Click);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.равноToolStripMenuItem,
            this.содержитToolStripMenuItem,
            this.отменитьФильтрToolStripMenuItem});
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // равноToolStripMenuItem
            // 
            this.равноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.равноToolStripMenuItem.Name = "равноToolStripMenuItem";
            this.равноToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.равноToolStripMenuItem.Text = "равно";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_Leave);
            // 
            // содержитToolStripMenuItem
            // 
            this.содержитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.содержитToolStripMenuItem.Name = "содержитToolStripMenuItem";
            this.содержитToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.содержитToolStripMenuItem.Text = "содержит";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // отменитьФильтрToolStripMenuItem
            // 
            this.отменитьФильтрToolStripMenuItem.Name = "отменитьФильтрToolStripMenuItem";
            this.отменитьФильтрToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.отменитьФильтрToolStripMenuItem.Text = "отменить фильтр";
            this.отменитьФильтрToolStripMenuItem.Click += new System.EventHandler(this.отменитьФильтрToolStripMenuItem_Click);
            // 
            // экспортироватьДанныеВExcelToolStripMenuItem
            // 
            this.экспортироватьДанныеВExcelToolStripMenuItem.Name = "экспортироватьДанныеВExcelToolStripMenuItem";
            this.экспортироватьДанныеВExcelToolStripMenuItem.Size = new System.Drawing.Size(286, 29);
            this.экспортироватьДанныеВExcelToolStripMenuItem.Text = "Экспортировать данные в Excel";
            this.экспортироватьДанныеВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьДанныеВExcelToolStripMenuItem_Click);
            // 
            // экспортироватьДанныеВWordToolStripMenuItem
            // 
            this.экспортироватьДанныеВWordToolStripMenuItem.Name = "экспортироватьДанныеВWordToolStripMenuItem";
            this.экспортироватьДанныеВWordToolStripMenuItem.Size = new System.Drawing.Size(292, 29);
            this.экспортироватьДанныеВWordToolStripMenuItem.Text = "Экспортировать данные в Word";
            this.экспортироватьДанныеВWordToolStripMenuItem.Click += new System.EventHandler(this.ЭкспортироватьДанныеВWordToolStripMenuItem_Click);
            // 
            // отчётОКатегорииToolStripMenuItem
            // 
            this.отчётОКатегорииToolStripMenuItem.Name = "отчётОКатегорииToolStripMenuItem";
            this.отчётОКатегорииToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.отчётОКатегорииToolStripMenuItem.Text = "Отчёт о категории";
            this.отчётОКатегорииToolStripMenuItem.Click += new System.EventHandler(this.ОтчётОКатегорииToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 557);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПродуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПродуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem применитьФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаОтАДоЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаОтЯДоАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem равноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержитToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem отменитьФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьДанныеВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьДанныеВWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётОКатегорииToolStripMenuItem;
    }
}

