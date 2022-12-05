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
    public partial class Decision : Form
    {
        public Decision()
        {
            InitializeComponent();
        }
        public Decision(int[] arr)
        {
            InitializeComponent();
            string x = arr[2].ToString()+"+ ("+ arr[1].ToString()+"*k)";
            string y = arr[3].ToString() + "- (" + arr[0].ToString() + "*k)";
            listBox1.Items.Add(x);
            listBox2.Items.Add(y);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
