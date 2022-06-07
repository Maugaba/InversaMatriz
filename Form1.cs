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
        decimal[,] matriz1;
        decimal[,] matriz2;
        decimal[,] matriz3;
        decimal[,] matriz4;
        decimal[,] matriz5;
        decimal[,] matriz6;
        decimal[,] matriz7;
        decimal[,] matriz8;
        decimal[,] matriz9;
        string a, b, c, d, f, g, h, i, j;

        private void textBoxA3_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReducir_Click(object sender, EventArgs e)
        {
            textBoxAAA1.Text = "";
            textBoxAAA2.Text = "";
            textBoxAAA3.Text = "";
            textBoxAAA4.Text = "";
            textBoxAAA5.Text = "";
            textBoxAAA6.Text = "";
            textBoxAAA7.Text = "";
            textBoxAAA8.Text = "";
            textBoxAAA9.Text = "";
            textBoxIII1.Text = "";
            textBoxIII2.Text = "";
            textBoxIII3.Text = "";
            textBoxIII4.Text = "";
            textBoxIII5.Text = "";
            textBoxIII6.Text = "";
            textBoxIII7.Text = "";
            textBoxIII8.Text = "";
            textBoxIII9.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Text = "";

            comboBox1.Enabled = true;
            buttonvisualizar.Enabled = true;
            
            //Matriz 3*6
            decimal[,] matriz = new decimal[3, 6];

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

            //Paso1
            if (!(matriz[0,0] == 1))
            {
                decimal val = 1/matriz[0,0];
                a = "Posicion (1,1) --> Renglon1 * 1/" + matriz[0, 0];
                matriz[0, 0] = matriz[0, 0] * val;
                matriz[0, 1] = matriz[0, 1] * val;
                matriz[0, 2] = matriz[0, 2] * val;
                matriz[0, 3] = matriz[0, 3] * val;
                matriz[0, 4] = matriz[0, 4] * val;
                matriz[0, 5] = matriz[0, 5] * val;
                
            }
            else
            {
                a = "Posicion (1,1) --> Renglon1";
            }
            comboBox1.Items.Add(a);
            matriz1 = matriz.Clone() as decimal[,];
            

            //Paso2
            decimal val1 = matriz[1, 0] * -1;
            b = "Posicion (2,1) --> Renglon2 + (-" + matriz[1, 0] + "*Renglon1)";
            matriz[1, 0] = matriz[1, 0] + val1 * matriz[0, 0];
            matriz[1, 1] = matriz[1, 1] + val1 * matriz[0, 1];
            matriz[1, 2] = matriz[1, 2] + val1 * matriz[0, 2];
            matriz[1, 3] = matriz[1, 3] + val1 * matriz[0, 3];
            matriz[1, 4] = matriz[1, 4] + val1 * matriz[0, 4];
            matriz[1, 5] = matriz[1, 5] + val1 * matriz[0, 5];

            matriz2 = matriz.Clone() as decimal[,];
            
            comboBox1.Items.Add(b);

            //Paso3
            decimal val2 = matriz[2, 0] * -1;
            c = "Posicion (3,1) --> Renglon3 + (-" + matriz[2, 0] + "*Renglon1)";
            matriz[2, 0] = matriz[2, 0] + val2 * matriz[0, 0];
            matriz[2, 1] = matriz[2, 1] + val2 * matriz[0, 1];
            matriz[2, 2] = matriz[2, 2] + val2 * matriz[0, 2];
            matriz[2, 3] = matriz[2, 3] + val2 * matriz[0, 3];
            matriz[2, 4] = matriz[2, 4] + val2 * matriz[0, 4];
            matriz[2, 5] = matriz[2, 5] + val2 * matriz[0, 5];

            matriz3 = matriz.Clone() as decimal[,];
            
            comboBox1.Items.Add(c);

            //Paso4
            if (!(matriz[1, 1] == 1))
            {
                decimal val3 = 1 / matriz[1, 1];
                d = "Posicion (2,2) --> Renglon2 * 1/" + matriz[1, 1];
                matriz[1, 0] = matriz[1, 0] * val3;
                matriz[1, 1] = matriz[1, 1] * val3;
                matriz[1, 2] = matriz[1, 2] * val3;
                matriz[1, 3] = matriz[1, 3] * val3;
                matriz[1, 4] = matriz[1, 4] * val3;
                matriz[1, 5] = matriz[1, 5] * val3;
                
            }
            else
            {
                d = "Posicion (2,2) --> Renglon2";
            }
            comboBox1.Items.Add(d);
            matriz4 = matriz.Clone() as decimal[,];
            

            //Paso5
            decimal val4 = matriz[2, 1] * -1;
            f = "Posicion (3,2) --> Renglon3 + (-" + matriz[2, 1] + "*Renglon2)";
            matriz[2, 0] = matriz[2, 0] + val4 * matriz[1, 0];
            matriz[2, 1] = matriz[2, 1] + val4 * matriz[1, 1];
            matriz[2, 2] = matriz[2, 2] + val4 * matriz[1, 2];
            matriz[2, 3] = matriz[2, 3] + val4 * matriz[1, 3];
            matriz[2, 4] = matriz[2, 4] + val4 * matriz[1, 4];
            matriz[2, 5] = matriz[2, 5] + val4 * matriz[1, 5];

            matriz5 = matriz.Clone() as decimal[,];
            
            comboBox1.Items.Add(f);

            //Paso6
            if (!(matriz[2, 2] == 1))
            {
                decimal val5 = 1 / matriz[2, 2];
                g = "Posicion (3,3) --> Renglon3 * 1/" + matriz[2, 2];
                matriz[2, 0] = matriz[2, 0] * val5;
                matriz[2, 1] = matriz[2, 1] * val5;
                matriz[2, 2] = matriz[2, 2] * val5;
                matriz[2, 3] = matriz[2, 3] * val5;
                matriz[2, 4] = matriz[2, 4] * val5;
                matriz[2, 5] = matriz[2, 5] * val5;
                 
            }
            else
            {
                g = "Posicion (3,3) --> Renglon3";
            }
            comboBox1.Items.Add(g);
            matriz6 = matriz.Clone() as decimal[,];

            //Paso7
            decimal val8 = matriz[1, 2] * -1;
            j = "Posicion (2,3) --> Renglon2 + (-" + matriz[1, 2] + "*Renglon3)";
            matriz[1, 0] = matriz[1, 0] + val8 * matriz[2, 0];
            matriz[1, 1] = matriz[1, 1] + val8 * matriz[2, 1];
            matriz[1, 2] = matriz[1, 2] + val8 * matriz[2, 2];
            matriz[1, 3] = matriz[1, 3] + val8 * matriz[2, 3];
            matriz[1, 4] = matriz[1, 4] + val8 * matriz[2, 4];
            matriz[1, 5] = matriz[1, 5] + val8 * matriz[2, 5];

            matriz9 = matriz.Clone() as decimal[,];

            comboBox1.Items.Add(j);

            //Paso8
            decimal val7 = matriz[0, 2] * -1;
            i = "Posicion (1,3) --> Renglon1 + (-" + matriz[0, 2] + "*Renglon3)";
            matriz[0, 0] = matriz[0, 0] + val7 * matriz[2, 0];
            matriz[0, 1] = matriz[0, 1] + val7 * matriz[2, 1];
            matriz[0, 2] = matriz[0, 2] + val7 * matriz[2, 2];
            matriz[0, 3] = matriz[0, 3] + val7 * matriz[2, 3];
            matriz[0, 4] = matriz[0, 4] + val7 * matriz[2, 4];
            matriz[0, 5] = matriz[0, 5] + val7 * matriz[2, 5];

            matriz8 = matriz.Clone() as decimal[,];
            
            comboBox1.Items.Add(i);

            

            //Paso9
            decimal val6 = matriz[0, 1] * -1;
            h = "Posicion (1,2) --> Renglon1 + (-" + matriz[0, 1] + "*Renglon2)";
            matriz[0, 0] = matriz[0, 0] + val6 * matriz[1, 0];
            matriz[0, 1] = matriz[0, 1] + val6 * matriz[1, 1];
            matriz[0, 2] = matriz[0, 2] + val6 * matriz[1, 2];
            matriz[0, 3] = matriz[0, 3] + val6 * matriz[1, 3];
            matriz[0, 4] = matriz[0, 4] + val6 * matriz[1, 4];
            matriz[0, 5] = matriz[0, 5] + val6 * matriz[1, 5];

            matriz7 = matriz.Clone() as decimal[,];

            comboBox1.Items.Add(h);



            textBoxII1.Text = Convert.ToInt32(matriz[0, 0]).ToString();
            textBoxII2.Text = Convert.ToInt32(matriz[0, 1]).ToString();
            textBoxII3.Text = Convert.ToInt32(matriz[0, 2]).ToString();
            textBoxAA1.Text = decimal.Round(matriz[0, 3], 3).ToString();
            textBoxAA2.Text = decimal.Round(matriz[0, 4], 3).ToString();
            textBoxAA3.Text = decimal.Round(matriz[0, 5], 3).ToString();

            textBoxII4.Text = Convert.ToInt32(matriz[1, 0]).ToString();
            textBoxII5.Text = Convert.ToInt32(matriz[1, 1]).ToString();
            textBoxII6.Text = Convert.ToInt32(matriz[1, 2]).ToString();
            textBoxAA4.Text = decimal.Round(matriz[1, 3], 3).ToString();
            textBoxAA5.Text = decimal.Round(matriz[1, 4], 3).ToString();
            textBoxAA6.Text = decimal.Round(matriz[1, 5], 3).ToString();

            textBoxII7.Text = Convert.ToInt32(matriz[2, 0]).ToString();
            textBoxII8.Text = Convert.ToInt32(matriz[2, 1]).ToString();
            textBoxII9.Text = Convert.ToInt32(matriz[2, 2]).ToString();
            textBoxAA7.Text = decimal.Round(matriz[2, 3], 3).ToString();
            textBoxAA8.Text = decimal.Round(matriz[2, 4], 3).ToString();
            textBoxAA9.Text = decimal.Round(matriz[2, 5], 3).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == a)
            {
                textBoxIII1.Text = matriz1[0, 0].ToString();
                textBoxIII2.Text = matriz1[0, 1].ToString();
                textBoxIII3.Text = matriz1[0, 2].ToString();
                textBoxAAA1.Text = matriz1[0, 3].ToString();
                textBoxAAA2.Text = matriz1[0, 4].ToString();
                textBoxAAA3.Text = matriz1[0, 5].ToString();

                textBoxIII4.Text = matriz1[1, 0].ToString();
                textBoxIII5.Text = matriz1[1, 1].ToString();
                textBoxIII6.Text = matriz1[1, 2].ToString();
                textBoxAAA4.Text = matriz1[1, 3].ToString();
                textBoxAAA5.Text = matriz1[1, 4].ToString();
                textBoxAAA6.Text = matriz1[1, 5].ToString();

                textBoxIII7.Text = matriz1[2, 0].ToString();
                textBoxIII8.Text = matriz1[2, 1].ToString();
                textBoxIII9.Text = matriz1[2, 2].ToString();
                textBoxAAA7.Text = matriz1[2, 3].ToString();
                textBoxAAA8.Text = matriz1[2, 4].ToString();
                textBoxAAA9.Text = matriz1[2, 5].ToString();
            }
           
            if (comboBox1.Text == b) 
            {
                textBoxIII1.Text = matriz2[0, 0].ToString();
                textBoxIII2.Text = matriz2[0, 1].ToString();
                textBoxIII3.Text = matriz2[0, 2].ToString();
                textBoxAAA1.Text = matriz2[0, 3].ToString();
                textBoxAAA2.Text = matriz2[0, 4].ToString();
                textBoxAAA3.Text = matriz2[0, 5].ToString();

                textBoxIII4.Text = matriz2[1, 0].ToString();
                textBoxIII5.Text = matriz2[1, 1].ToString();
                textBoxIII6.Text = matriz2[1, 2].ToString();
                textBoxAAA4.Text = matriz2[1, 3].ToString();
                textBoxAAA5.Text = matriz2[1, 4].ToString();
                textBoxAAA6.Text = matriz2[1, 5].ToString();

                textBoxIII7.Text = matriz2[2, 0].ToString();
                textBoxIII8.Text = matriz2[2, 1].ToString();
                textBoxIII9.Text = matriz2[2, 2].ToString();
                textBoxAAA7.Text = matriz2[2, 3].ToString();
                textBoxAAA8.Text = matriz2[2, 4].ToString();
                textBoxAAA9.Text = matriz2[2, 5].ToString();
            }
            if (comboBox1.Text == c) 
            {
                textBoxIII1.Text = matriz3[0, 0].ToString();
                textBoxIII2.Text = matriz3[0, 1].ToString();
                textBoxIII3.Text = matriz3[0, 2].ToString();
                textBoxAAA1.Text = matriz3[0, 3].ToString();
                textBoxAAA2.Text = matriz3[0, 4].ToString();
                textBoxAAA3.Text = matriz3[0, 5].ToString();

                textBoxIII4.Text = matriz3[1, 0].ToString();
                textBoxIII5.Text = matriz3[1, 1].ToString();
                textBoxIII6.Text = matriz3[1, 2].ToString();
                textBoxAAA4.Text = matriz3[1, 3].ToString();
                textBoxAAA5.Text = matriz3[1, 4].ToString();
                textBoxAAA6.Text = matriz3[1, 5].ToString();

                textBoxIII7.Text = matriz3[2, 0].ToString();
                textBoxIII8.Text = matriz3[2, 1].ToString();
                textBoxIII9.Text = matriz3[2, 2].ToString();
                textBoxAAA7.Text = matriz3[2, 3].ToString();
                textBoxAAA8.Text = matriz3[2, 4].ToString();
                textBoxAAA9.Text = matriz3[2, 5].ToString();
            }
            if (comboBox1.Text == d) 
            {
                textBoxIII1.Text = matriz4[0, 0].ToString();
                textBoxIII2.Text = matriz4[0, 1].ToString();
                textBoxIII3.Text = matriz4[0, 2].ToString();
                textBoxAAA1.Text = matriz4[0, 3].ToString();
                textBoxAAA2.Text = matriz4[0, 4].ToString();
                textBoxAAA3.Text = matriz4[0, 5].ToString();

                textBoxIII4.Text = matriz4[1, 0].ToString();
                textBoxIII5.Text = matriz4[1, 1].ToString();
                textBoxIII6.Text = matriz4[1, 2].ToString();
                textBoxAAA4.Text = matriz4[1, 3].ToString();
                textBoxAAA5.Text = matriz4[1, 4].ToString();
                textBoxAAA6.Text = matriz4[1, 5].ToString();

                textBoxIII7.Text = matriz4[2, 0].ToString();
                textBoxIII8.Text = matriz4[2, 1].ToString();
                textBoxIII9.Text = matriz4[2, 2].ToString();
                textBoxAAA7.Text = matriz4[2, 3].ToString();
                textBoxAAA8.Text = matriz4[2, 4].ToString();
                textBoxAAA9.Text = matriz4[2, 5].ToString();
            }
            
            if (comboBox1.Text == f) 
            {
                textBoxIII1.Text = matriz5[0, 0].ToString();
                textBoxIII2.Text = matriz5[0, 1].ToString();
                textBoxIII3.Text = matriz5[0, 2].ToString();
                textBoxAAA1.Text = matriz5[0, 3].ToString();
                textBoxAAA2.Text = matriz5[0, 4].ToString();
                textBoxAAA3.Text = matriz5[0, 5].ToString();

                textBoxIII4.Text = matriz5[1, 0].ToString();
                textBoxIII5.Text = matriz5[1, 1].ToString();
                textBoxIII6.Text = matriz5[1, 2].ToString();
                textBoxAAA4.Text = matriz5[1, 3].ToString();
                textBoxAAA5.Text = matriz5[1, 4].ToString();
                textBoxAAA6.Text = matriz5[1, 5].ToString();

                textBoxIII7.Text = matriz5[2, 0].ToString();
                textBoxIII8.Text = matriz5[2, 1].ToString();
                textBoxIII9.Text = matriz5[2, 2].ToString();
                textBoxAAA7.Text = matriz5[2, 3].ToString();
                textBoxAAA8.Text = matriz5[2, 4].ToString();
                textBoxAAA9.Text = matriz5[2, 5].ToString();
            }
            if (comboBox1.Text == g)
            {
                textBoxIII1.Text = matriz6[0, 0].ToString();
                textBoxIII2.Text = matriz6[0, 1].ToString();
                textBoxIII3.Text = matriz6[0, 2].ToString();
                textBoxAAA1.Text = matriz6[0, 3].ToString();
                textBoxAAA2.Text = matriz6[0, 4].ToString();
                textBoxAAA3.Text = matriz6[0, 5].ToString();

                textBoxIII4.Text = matriz6[1, 0].ToString();
                textBoxIII5.Text = matriz6[1, 1].ToString();
                textBoxIII6.Text = matriz6[1, 2].ToString();
                textBoxAAA4.Text = matriz6[1, 3].ToString();
                textBoxAAA5.Text = matriz6[1, 4].ToString();
                textBoxAAA6.Text = matriz6[1, 5].ToString();

                textBoxIII7.Text = matriz6[2, 0].ToString();
                textBoxIII8.Text = matriz6[2, 1].ToString();
                textBoxIII9.Text = matriz6[2, 2].ToString();
                textBoxAAA7.Text = matriz6[2, 3].ToString();
                textBoxAAA8.Text = matriz6[2, 4].ToString();
                textBoxAAA9.Text = matriz6[2, 5].ToString();
            }
            
            if (comboBox1.Text == h) 
            {
                textBoxIII1.Text = matriz7[0, 0].ToString();
                textBoxIII2.Text = matriz7[0, 1].ToString();
                textBoxIII3.Text = matriz7[0, 2].ToString();
                textBoxAAA1.Text = matriz7[0, 3].ToString();
                textBoxAAA2.Text = matriz7[0, 4].ToString();
                textBoxAAA3.Text = matriz7[0, 5].ToString();

                textBoxIII4.Text = matriz7[1, 0].ToString();
                textBoxIII5.Text = matriz7[1, 1].ToString();
                textBoxIII6.Text = matriz7[1, 2].ToString();
                textBoxAAA4.Text = matriz7[1, 3].ToString();
                textBoxAAA5.Text = matriz7[1, 4].ToString();
                textBoxAAA6.Text = matriz7[1, 5].ToString();

                textBoxIII7.Text = matriz7[2, 0].ToString();
                textBoxIII8.Text = matriz7[2, 1].ToString();
                textBoxIII9.Text = matriz7[2, 2].ToString();
                textBoxAAA7.Text = matriz7[2, 3].ToString();
                textBoxAAA8.Text = matriz7[2, 4].ToString();
                textBoxAAA9.Text = matriz7[2, 5].ToString();
            }
            if (comboBox1.Text == i)
            {
                textBoxIII1.Text = matriz8[0, 0].ToString();
                textBoxIII2.Text = matriz8[0, 1].ToString();
                textBoxIII3.Text = matriz8[0, 2].ToString();
                textBoxAAA1.Text = matriz8[0, 3].ToString();
                textBoxAAA2.Text = matriz8[0, 4].ToString();
                textBoxAAA3.Text = matriz8[0, 5].ToString();

                textBoxIII4.Text = matriz8[1, 0].ToString();
                textBoxIII5.Text = matriz8[1, 1].ToString();
                textBoxIII6.Text = matriz8[1, 2].ToString();
                textBoxAAA4.Text = matriz8[1, 3].ToString();
                textBoxAAA5.Text = matriz8[1, 4].ToString();
                textBoxAAA6.Text = matriz8[1, 5].ToString();

                textBoxIII7.Text = matriz8[2, 0].ToString();
                textBoxIII8.Text = matriz8[2, 1].ToString();
                textBoxIII9.Text = matriz8[2, 2].ToString();
                textBoxAAA7.Text = matriz8[2, 3].ToString();
                textBoxAAA8.Text = matriz8[2, 4].ToString();
                textBoxAAA9.Text = matriz8[2, 5].ToString();
            }
            if (comboBox1.Text == j)
            {
                textBoxIII1.Text = matriz9[0, 0].ToString();
                textBoxIII2.Text = matriz9[0, 1].ToString();
                textBoxIII3.Text = matriz9[0, 2].ToString();
                textBoxAAA1.Text = matriz9[0, 3].ToString();
                textBoxAAA2.Text = matriz9[0, 4].ToString();
                textBoxAAA3.Text = matriz9[0, 5].ToString();

                textBoxIII4.Text = matriz9[1, 0].ToString();
                textBoxIII5.Text = matriz9[1, 1].ToString();
                textBoxIII6.Text = matriz9[1, 2].ToString();
                textBoxAAA4.Text = matriz9[1, 3].ToString();
                textBoxAAA5.Text = matriz9[1, 4].ToString();
                textBoxAAA6.Text = matriz9[1, 5].ToString();

                textBoxIII7.Text = matriz9[2, 0].ToString();
                textBoxIII8.Text = matriz9[2, 1].ToString();
                textBoxIII9.Text = matriz9[2, 2].ToString();
                textBoxAAA7.Text = matriz9[2, 3].ToString();
                textBoxAAA8.Text = matriz9[2, 4].ToString();
                textBoxAAA9.Text = matriz9[2, 5].ToString();
            }
        }
    }
}
