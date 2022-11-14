using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarWF.Models;

namespace CarWF
{
    public partial class Form1 : Form
    {
        private LogicKochetkovNuget.LogicCars<Car> Cars;
        private readonly BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Cars= new LogicKochetkovNuget.LogicCars<Car>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = Cars.GetAll();
            dataGridView1.DataSource = bindingSource;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это моя прога!", "О программе ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddtoolStripButton1_Click(object sender, EventArgs e)
        {
            var infoform = new CarsInfoForm();
            infoform.Text = "Добавление Машины";
            if(infoform.ShowDialog(this)==DialogResult.OK)
            {
                infoform.Target.Id = Guid.NewGuid();
                Cars.AddCar(infoform.Target);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var car = (Car)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (dataGridView1.Columns[e.ColumnIndex].Name== "MarkColumn")
            {
                var val = (MarkCars)e.Value;
                switch (val)
                {
                    case (MarkCars.HyundaiCreta):
                        e.Value = "Хендай Крета";
                        break;
                    case (MarkCars.LadaVesta):
                        e.Value = "Лада Веста";
                        break;
                    case (MarkCars.MitsubishiOutlander):
                        e.Value = "Митсубиси Ландер";
                        break;
                }
            }

            if(dataGridView1.Columns[e.ColumnIndex].Name == "PowerReserveColumn" && car.AvgFuelForHour!=0)
            {

                e.Value = Math.Round((car.Fuel / car.AvgFuelForHour),2);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "RentalAmountColumn" && car.AvgFuelForHour != 0)
            {
                e.Value = Math.Round((car.Fuel / car.AvgFuelForHour)*car.PriseRent,2);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ChangetoolStripButton3.Enabled = DeletetoolStripButton2.Enabled = dataGridView1.SelectedRows.Count > 0;
            ChangeToolStripMenuItem.Enabled = DeleteToolStripMenuItem.Enabled= dataGridView1.SelectedRows.Count > 0;
        }

        private void DeletetoolStripButton2_Click(object sender, EventArgs e)
        {
            var data = (Car)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {data.Mark}  {data.GosNumber} ?", "Удаление Записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cars.DeleteCar(data);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void ChangetoolStripButton3_Click(object sender, EventArgs e)
        {
            var data = (Car)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var infoform = new CarsInfoForm(data);
            infoform.Text = "Редактирование Автомобиля";
            if (infoform.ShowDialog(this) == DialogResult.OK)
            {
                Cars.ChangeCar(dataGridView1.SelectedRows[0].Index, infoform.Target);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangetoolStripButton3.PerformClick();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "ProbegColumn")
            {
                e.PaintBackground(e.CellBounds, true);
                var val = decimal.Parse(e.Value.ToString());
                var width = (float)(val/50.0m);

                if (val < 1500)
                {
                    e.Graphics.FillRectangle(Brushes.Green, e.CellBounds.X,
                        e.CellBounds.Y,
                        width,
                        e.CellBounds.Height);
                }
                else if (val < 3000)
                {
                    e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds.X,
                       e.CellBounds.Y,
                       width,
                       e.CellBounds.Height);
                }
                else 
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.CellBounds.X,
                       e.CellBounds.Y,
                       width,
                       e.CellBounds.Height);
                }
                e.Handled = true;
            }
        }

        public void CalculateStats()
        {
            AllCarsStripStatusLabel1.Text = Cars.GetAll().Count.ToString();
            CriticalStripStatusLabel1.Text = "Критический запас хода: " + Cars.GetAll().Where(x=>x.PowerReserve<7).Count();
        }
    }
}