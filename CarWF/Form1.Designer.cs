namespace CarWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DeletetoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ChangetoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AllCarsStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CriticalStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerReserveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbegColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgFuelForHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriseRentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.ChangeToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddtoolStripButton1_Click);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Enabled = false;
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            this.ChangeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            this.ChangeToolStripMenuItem.DoubleClick += new System.EventHandler(this.ChangetoolStripButton3_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripButton2_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MinToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MinToolStripMenuItem
            // 
            this.MinToolStripMenuItem.Name = "MinToolStripMenuItem";
            this.MinToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.MinToolStripMenuItem.Text = "О программе";
            this.MinToolStripMenuItem.Click += new System.EventHandler(this.MinToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddtoolStripButton1,
            this.DeletetoolStripButton2,
            this.ChangetoolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(993, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddtoolStripButton1
            // 
            this.AddtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("AddtoolStripButton1.Image")));
            this.AddtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddtoolStripButton1.Name = "AddtoolStripButton1";
            this.AddtoolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.AddtoolStripButton1.Text = "Добавить";
            this.AddtoolStripButton1.Click += new System.EventHandler(this.AddtoolStripButton1_Click);
            // 
            // DeletetoolStripButton2
            // 
            this.DeletetoolStripButton2.Enabled = false;
            this.DeletetoolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("DeletetoolStripButton2.Image")));
            this.DeletetoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletetoolStripButton2.Name = "DeletetoolStripButton2";
            this.DeletetoolStripButton2.Size = new System.Drawing.Size(71, 22);
            this.DeletetoolStripButton2.Text = "Удалить";
            this.DeletetoolStripButton2.Click += new System.EventHandler(this.DeletetoolStripButton2_Click);
            // 
            // ChangetoolStripButton3
            // 
            this.ChangetoolStripButton3.Enabled = false;
            this.ChangetoolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ChangetoolStripButton3.Image")));
            this.ChangetoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangetoolStripButton3.Name = "ChangetoolStripButton3";
            this.ChangetoolStripButton3.Size = new System.Drawing.Size(81, 22);
            this.ChangetoolStripButton3.Text = "Изменить";
            this.ChangetoolStripButton3.Click += new System.EventHandler(this.ChangetoolStripButton3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllCarsStripStatusLabel1,
            this.CriticalStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AllCarsStripStatusLabel1
            // 
            this.AllCarsStripStatusLabel1.AutoSize = false;
            this.AllCarsStripStatusLabel1.Name = "AllCarsStripStatusLabel1";
            this.AllCarsStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.AllCarsStripStatusLabel1.Text = "0";
            // 
            // CriticalStripStatusLabel1
            // 
            this.CriticalStripStatusLabel1.AutoSize = false;
            this.CriticalStripStatusLabel1.Name = "CriticalStripStatusLabel1";
            this.CriticalStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            this.CriticalStripStatusLabel1.Text = "Критический запас хода: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarkColumn,
            this.PowerReserveColumn,
            this.NomerColumn,
            this.ProbegColumn,
            this.FuelColumn,
            this.AvgFuelForHourColumn,
            this.PriseRentColumn,
            this.RentalAmountColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(993, 448);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MarkColumn
            // 
            this.MarkColumn.DataPropertyName = "Mark";
            this.MarkColumn.HeaderText = "Марка Авто";
            this.MarkColumn.Name = "MarkColumn";
            this.MarkColumn.ReadOnly = true;
            // 
            // PowerReserveColumn
            // 
            this.PowerReserveColumn.DataPropertyName = "PowerReserve";
            this.PowerReserveColumn.HeaderText = "Запас хода топлива";
            this.PowerReserveColumn.Name = "PowerReserveColumn";
            this.PowerReserveColumn.ReadOnly = true;
            this.PowerReserveColumn.Width = 130;
            // 
            // NomerColumn
            // 
            this.NomerColumn.DataPropertyName = "GosNumber";
            this.NomerColumn.HeaderText = "Гос. Номер";
            this.NomerColumn.Name = "NomerColumn";
            this.NomerColumn.ReadOnly = true;
            this.NomerColumn.Width = 130;
            // 
            // ProbegColumn
            // 
            this.ProbegColumn.DataPropertyName = "Probeg";
            this.ProbegColumn.HeaderText = "Пробег";
            this.ProbegColumn.Name = "ProbegColumn";
            this.ProbegColumn.ReadOnly = true;
            this.ProbegColumn.Width = 130;
            // 
            // FuelColumn
            // 
            this.FuelColumn.DataPropertyName = "Fuel";
            this.FuelColumn.HeaderText = "Текущий объем топлива";
            this.FuelColumn.Name = "FuelColumn";
            this.FuelColumn.ReadOnly = true;
            // 
            // AvgFuelForHourColumn
            // 
            this.AvgFuelForHourColumn.DataPropertyName = "AvgFuelForHour";
            this.AvgFuelForHourColumn.HeaderText = "Расход топлива за час";
            this.AvgFuelForHourColumn.Name = "AvgFuelForHourColumn";
            this.AvgFuelForHourColumn.ReadOnly = true;
            // 
            // PriseRentColumn
            // 
            this.PriseRentColumn.DataPropertyName = "PriseRent";
            this.PriseRentColumn.HeaderText = "Стоимость Аренды(мин.)";
            this.PriseRentColumn.Name = "PriseRentColumn";
            this.PriseRentColumn.ReadOnly = true;
            this.PriseRentColumn.Width = 130;
            // 
            // RentalAmountColumn
            // 
            this.RentalAmountColumn.DataPropertyName = "RentalAmount";
            this.RentalAmountColumn.HeaderText = "Сумма аренды";
            this.RentalAmountColumn.Name = "RentalAmountColumn";
            this.RentalAmountColumn.ReadOnly = true;
            this.RentalAmountColumn.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1009, 558);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1009, 558);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddtoolStripButton1;
        private System.Windows.Forms.ToolStripButton DeletetoolStripButton2;
        private System.Windows.Forms.ToolStripButton ChangetoolStripButton3;
        private System.Windows.Forms.ToolStripStatusLabel AllCarsStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel CriticalStripStatusLabel1;
        private DataGridViewTextBoxColumn MarkColumn;
        private DataGridViewTextBoxColumn PowerReserveColumn;
        private DataGridViewTextBoxColumn NomerColumn;
        private DataGridViewTextBoxColumn ProbegColumn;
        private DataGridViewTextBoxColumn FuelColumn;
        private DataGridViewTextBoxColumn AvgFuelForHourColumn;
        private DataGridViewTextBoxColumn PriseRentColumn;
        private DataGridViewTextBoxColumn RentalAmountColumn;
    }
}

