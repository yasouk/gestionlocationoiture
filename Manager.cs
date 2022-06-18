using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gestionlocationoiture
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cars cr = new Cars();
            cr.Show();
            Visible = false;
        }
    }
}
