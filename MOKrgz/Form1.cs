using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MOKrgz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //при нажатии на кнопку Решить уравнение
                Int32 x = Int32.Parse(textBox1.Text);
                Int32 y = Int32.Parse(textBox2.Text);
                Int32 c = Int32.Parse(textBox3.Text);
                Int32 nod = MOKrgz.NumberAlgo.gcd(x, y);
                //1 находим НОД чисел x y - коэффициентов перед X и Y
                //2 если НОД не равен 1 то делим на это число
                //3 если НОД не равен 1 то уравнение не решаемое в целых числах
                if (c % nod != 0)
                {//нерешаемое уравнение
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else// если решаемое то решаем
                {
                    x /= nod;
                    y /= nod;
                    c /= nod;
                    int[] arr = MOKrgz.NumberAlgo.diof(x, y, c);
                    Decision dec = new Decision(arr);
                    dec.Show();

                }
               
                
             }
             catch (System.FormatException)
             {
                ErrorForm errorForm = new ErrorForm();
                errorForm.Show();
             }

}
    }
}
