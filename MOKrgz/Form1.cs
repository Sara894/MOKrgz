using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                Int32 r = Int32.Parse(textBox3.Text);
                //1 находим НОД чисел x y - коэффициентов перед X и Y
                //2 если НОД не равен 1 то делим на это число
                //3 если НОД не равен 1 то уравнение не решаемое в целых числах
                Form2 f2 = new Form2();
                f2.Show();
             }
             catch (System.FormatException)
             {
                ErrorForm errorForm = new ErrorForm();
                errorForm.Show();
             }

}
    }
}
