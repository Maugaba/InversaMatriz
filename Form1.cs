using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculodelainversadeunamatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReducir_Click(object sender, EventArgs e)
        {
            //Matriz 3*6
            decimal[,] matriz = new decimal[3, 6];
            decimal[,] matriz1 = new decimal[3, 6];
            matriz[0, 0] = Convert.ToDecimal(textBoxA1.Text);
            matriz[0, 1] = Convert.ToDecimal(textBoxA2.Text);
            matriz[0, 2] = Convert.ToDecimal(textBoxA3.Text);
            matriz[0, 3] = Convert.ToDecimal(textBoxI1.Text);
            matriz[0, 4] = Convert.ToDecimal(textBoxI2.Text);
            matriz[0, 5] = Convert.ToDecimal(textBoxI3.Text);

            matriz[1, 0] = Convert.ToDecimal(textBoxA4.Text);
            matriz[1, 1] = Convert.ToDecimal(textBoxA5.Text);
            matriz[1, 2] = Convert.ToDecimal(textBoxA6.Text);
            matriz[1, 3] = Convert.ToDecimal(textBoxI4.Text);
            matriz[1, 4] = Convert.ToDecimal(textBoxI5.Text);
            matriz[1, 5] = Convert.ToDecimal(textBoxI6.Text);

            matriz[2, 0] = Convert.ToDecimal(textBoxA7.Text);
            matriz[2, 1] = Convert.ToDecimal(textBoxA8.Text);
            matriz[2, 2] = Convert.ToDecimal(textBoxA9.Text);
            matriz[2, 3] = Convert.ToDecimal(textBoxI7.Text);
            matriz[2, 4] = Convert.ToDecimal(textBoxI8.Text);
            matriz[2, 5] = Convert.ToDecimal(textBoxI9.Text);

            if (!(matriz[0,0] == 1))
            {
                decimal val = 1/matriz[0,0];
                matriz[0, 0] = matriz[0, 0] * val;
                matriz[0, 1] = matriz[0, 1] * val;
                matriz[0, 2] = matriz[0, 2] * val;
                matriz[0, 3] = matriz[0, 3] * val;
                matriz[0, 4] = matriz[0, 4] * val;
                matriz[0, 5] = matriz[0, 5] * val;
            }

            decimal val1 = matriz[1, 0] * -1;
            matriz[1, 0] = matriz[1, 0] + val1 * matriz[0, 0];
            matriz[1, 1] = matriz[1, 1] + val1 * matriz[0, 1];
            matriz[1, 2] = matriz[1, 2] + val1 * matriz[0, 2];
            matriz[1, 3] = matriz[1, 3] + val1 * matriz[0, 3];
            matriz[1, 4] = matriz[1, 4] + val1 * matriz[0, 4];
            matriz[1, 5] = matriz[1, 5] + val1 * matriz[0, 5];

            decimal val2 = matriz[2, 0] * -1;
            matriz[2, 0] = matriz[2, 0] + val2 * matriz[0, 0];
            matriz[2, 1] = matriz[2, 1] + val2 * matriz[0, 1];
            matriz[2, 2] = matriz[2, 2] + val2 * matriz[0, 2];
            matriz[2, 3] = matriz[2, 3] + val2 * matriz[0, 3];
            matriz[2, 4] = matriz[2, 4] + val2 * matriz[0, 4];
            matriz[2, 5] = matriz[2, 5] + val2 * matriz[0, 5];

            if (!(matriz[1, 1] == 1))
            {
                decimal val3 = 1 / matriz[1, 1];
                matriz[1, 0] = matriz[1, 0] * val3;
                matriz[1, 1] = matriz[1, 1] * val3;
                matriz[1, 2] = matriz[1, 2] * val3;
                matriz[1, 3] = matriz[1, 3] * val3;
                matriz[1, 4] = matriz[1, 4] * val3;
                matriz[1, 5] = matriz[1, 5] * val3;
            }

            decimal val4 = matriz[2, 1] * -1;
            matriz[2, 0] = matriz[2, 0] + val4 * matriz[1, 0];
            matriz[2, 1] = matriz[2, 1] + val4 * matriz[1, 1];
            matriz[2, 2] = matriz[2, 2] + val4 * matriz[1, 2];
            matriz[2, 3] = matriz[2, 3] + val4 * matriz[1, 3];
            matriz[2, 4] = matriz[2, 4] + val4 * matriz[1, 4];
            matriz[2, 5] = matriz[2, 5] + val4 * matriz[1, 5];

            if (!(matriz[2, 2] == 1))
            {
                decimal val5 = 1 / matriz[2, 2];
                matriz[2, 0] = matriz[2, 0] * val5;
                matriz[2, 1] = matriz[2, 1] * val5;
                matriz[2, 2] = matriz[2, 2] * val5;
                matriz[2, 3] = matriz[2, 3] * val5;
                matriz[2, 4] = matriz[2, 4] * val5;
                matriz[2, 5] = matriz[2, 5] * val5;
            }

            decimal val6 = matriz[0, 1] * -1;
            matriz[0, 0] = matriz[0, 0] + val6 * matriz[1, 0];
            matriz[0, 1] = matriz[0, 1] + val6 * matriz[1, 1];
            matriz[0, 2] = matriz[0, 2] + val6 * matriz[1, 2];
            matriz[0, 3] = matriz[0, 3] + val6 * matriz[1, 3];
            matriz[0, 4] = matriz[0, 4] + val6 * matriz[1, 4];
            matriz[0, 5] = matriz[0, 5] + val6 * matriz[1, 5];

            decimal val7 = matriz[0, 2] * -1;
            matriz[0, 0] = matriz[0, 0] + val7 * matriz[2, 0];
            matriz[0, 1] = matriz[0, 1] + val7 * matriz[2, 1];
            matriz[0, 2] = matriz[0, 2] + val7 * matriz[2, 2];
            matriz[0, 3] = matriz[0, 3] + val7 * matriz[2, 3];
            matriz[0, 4] = matriz[0, 4] + val7 * matriz[2, 4];
            matriz[0, 5] = matriz[0, 5] + val7 * matriz[2, 5];

            decimal val8 = matriz[1, 2] * -1;
            matriz[1, 0] = matriz[1, 0] + val8 * matriz[2, 0];
            matriz[1, 1] = matriz[1, 1] + val8 * matriz[2, 1];
            matriz[1, 2] = matriz[1, 2] + val8 * matriz[2, 2];
            matriz[1, 3] = matriz[1, 3] + val8 * matriz[2, 3];
            matriz[1, 4] = matriz[1, 4] + val8 * matriz[2, 4];
            matriz[1, 5] = matriz[1, 5] + val8 * matriz[2, 5];





            textBoxII1.Text = matriz[0, 0].ToString();
            textBoxII2.Text = matriz[0, 1].ToString();
            textBoxII3.Text = matriz[0, 2].ToString();
            textBoxAA1.Text = matriz[0, 3].ToString();
            textBoxAA2.Text = matriz[0, 4].ToString();
            textBoxAA3.Text = matriz[0, 5].ToString();

            textBoxII4.Text = matriz[1, 0].ToString();
            textBoxII5.Text = matriz[1, 1].ToString();
            textBoxII6.Text = matriz[1, 2].ToString();
            textBoxAA4.Text = matriz[1, 3].ToString();
            textBoxAA5.Text = matriz[1, 4].ToString();
            textBoxAA6.Text = matriz[1, 5].ToString();

            textBoxII7.Text = matriz[2, 0].ToString();
            textBoxII8.Text = matriz[2, 1].ToString();
            textBoxII9.Text = matriz[2, 2].ToString();
            textBoxAA7.Text = matriz[2, 3].ToString();
            textBoxAA8.Text = matriz[2, 4].ToString();
            textBoxAA9.Text = matriz[2, 5].ToString();
        }
    }
}
