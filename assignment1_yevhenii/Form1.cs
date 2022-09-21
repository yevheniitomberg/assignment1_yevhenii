using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_yevhenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.header_label.Text = "Click somewhere";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.country_name_label.Text = "UKRAINE";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.country_name_label.Text = "ESTONIA";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.country_name_label.Text = "USA";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.country_name_label.Text = "BRITAIN";
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.country_name_label.Text = "";
        }
    }
}
