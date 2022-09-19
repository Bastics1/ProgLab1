namespace Prog_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double BarLength = Convert.ToDouble(barLengthTB.Text);
                double EdgeLength1 = Convert.ToDouble(edgeLengthTB1.Text);
                double EdgeLength2 = Convert.ToDouble(edgeLengthTB2.Text);
                double CylinderLength = Convert.ToDouble(cylinderLengthTB.Text);
                double CylinderRadius = Convert.ToDouble(cylinderRadiusTB.Text);
                if (BarLength != 0 && EdgeLength1 != 0 && EdgeLength2 != 0 && CylinderLength != 0 && CylinderRadius != 0)
                {
                    if (CylinderRadius <= EdgeLength1 / 2 && CylinderRadius <= EdgeLength2 / 2 && CylinderLength <= BarLength)
                    {
                        double pi = Math.PI;
                        double VBar = Math.Round(BarLength * EdgeLength1 * EdgeLength2, 3);
                        double VCylinder = Math.Round(pi * Math.Pow(CylinderRadius,2) * CylinderLength, 3);
                        double LostPercent = Math.Round(100 - ((VCylinder * 100) / VBar), 3);
                        percentTB.Text = Convert.ToString(LostPercent);
                        vBarTB.Text = Convert.ToString(VBar);
                        vCylinderTB.Text = Convert.ToString(VCylinder);
                        
                    }
                    else
                    {
                        MessageBox.Show("Введены некорректные значения для цилиндра.");
                    }
                } else
                {
                    MessageBox.Show("Введены некорректные значения. Уберите нули");
                }
            } catch (FormatException) {
                MessageBox.Show("Введите корректные значения.");
            }
           
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            barLengthTB.Clear();
            edgeLengthTB1.Clear();
            edgeLengthTB2.Clear();
            cylinderLengthTB.Clear();
            cylinderRadiusTB.Clear();
            percentTB.Clear();
            vBarTB.Clear();
            vCylinderTB.Clear();
        }

        private void barLengthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                    if (((sender as TextBox).Text.IndexOf(',') != -1) || (sender as TextBox).Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}