using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AikonCWD_W10S_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sistema_Click(object sender, EventArgs e)
        {
            new Forms.Sistema().ShowDialog();
        }

        private void btn_rendimiento_Click(object sender, EventArgs e)
        {
            new Forms.Rendimiento().ShowDialog();

        }

        private void btn_ssd_Click(object sender, EventArgs e)
        {
            new Forms.SSD().ShowDialog();

        }

        private void btn_metroapps_Click(object sender, EventArgs e)
        {
            new Forms.MetroApps().ShowDialog();

        }

        private void btn_microsoft_Click(object sender, EventArgs e)
        {
            new Forms.Microsoft().ShowDialog();

        }

        private void btn_restauracion_Click(object sender, EventArgs e)
        {
            new Forms.Restauracion().ShowDialog();

        }

        private void link_aikon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aikoncwd/win10script");
        }

        private void link_emi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emimontesdeoca/AikonCWD-W10S-GUI");
        }
    }
}
