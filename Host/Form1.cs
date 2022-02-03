using Services;
using ServicesContract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form1 : Form
    {
        private ServiceHost sh = new ServiceHost(typeof(MeteoService));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sh.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sh!=null)
            {
                sh.Close();
            }
        }
    }
}
