using System;
using System.Drawing;
using System.Windows.Forms;
using CarWF.Models;

namespace CarWF
{
    public partial class CarsInfoForm : Form
    {
        private readonly  Car cr;
        public CarsInfoForm()
        {
            InitializeComponent();
            FillMark();
            cr = new Car
            {
                Mark = MarkCars.LadaVesta
            };
          comboBoxMark.SelectedItem = cr.Mark;
        }

        public CarsInfoForm(Car cars) :this()
        {
            comboBoxMark.SelectedItem = cars.Mark;
            maskedNomer.Text = cars.GosNumber;
            numericProbeg.Value = cars.Probeg;
            numericPrice.Value = cars.PriseRent;
            numericFill.Value = cars.Fuel;
            numericHour.Value = cars.AvgFuelForHour;
        }
        public Car Target => cr;
        private void FillMark()
        {
            foreach (MarkCars item in Enum.GetValues(typeof(MarkCars)))
            {
                comboBoxMark.Items.Add(item);
            }
        }

        private void GendercomboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is MarkCars mark) 
                    {
                        string text="";
                        switch (mark)
                        {
                            case (MarkCars.HyundaiCreta):
                                text = "Хендай Крета";
                                break;
                            case (MarkCars.LadaVesta):
                                text = "Лада Веста";
                                break;
                            case (MarkCars.MitsubishiOutlander):
                                text = "Митсубиси Ландер";
                                break;
                        }

                        e.Graphics.DrawString(text,
                                            parent.Font,
                                            brush,
                                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }

        private void numericProbeg_Validated(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if(num.Text=="")
            {
                num.Text = "1,00";
            }
        }

        private void numericProbeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            char c = e.KeyChar;
            if(!Char.IsDigit(c) && c!=8 && c!=44)
            {
                e.Handled = true;   
            }
        }

        private void maskedNomer_TextChanged(object sender, EventArgs e)
        {
            if(maskedNomer.Text.Length==10)
            {
                Savebutton1.Enabled = true;
            }
            else
            {
                Savebutton1.Enabled = false;    
            }
            cr.GosNumber= maskedNomer.Text;
        }

        private void comboBoxMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            cr.Mark=(MarkCars)comboBoxMark.SelectedIndex;
        }

        private void numericProbeg_ValueChanged(object sender, EventArgs e)
        {
            cr.Probeg = numericProbeg.Value;
        }

        private void numericHour_ValueChanged(object sender, EventArgs e)
        {
            cr.AvgFuelForHour= numericHour.Value;
        }

        private void numericFill_ValueChanged(object sender, EventArgs e)
        {
            cr.Fuel= numericFill.Value;
        }

        private void numericPrice_ValueChanged(object sender, EventArgs e)
        {
            cr.PriseRent= numericPrice.Value;  
        }
    }
}
