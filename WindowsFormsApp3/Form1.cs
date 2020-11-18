using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "choice 1a";
                comboBox2.Items.Clear();

                comboBox2.Items.Add(("Charles"));
                comboBox2.Items.Add(("Ruth"));
                comboBox2.Items.Add(("Sophie"));

                switch(comboBox2.SelectedIndex)
                {
                    case 0: label2.Text = "choice1b";
                        MessageBox.Show("ola");
                        break;
                }

                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "choice 1b";
                comboBox2.Items.Clear();
                comboBox2.Items.Add(("Xalxas"));
                comboBox2.Items.Add(("Peter"));
                comboBox2.Items.Add(("Mario"));

                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        label2.Text = "choice1b";
                        MessageBox.Show("ola");
                        break;
                }
            }
            else
            {
                label1.Text = "choice 1c";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

