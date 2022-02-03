using DataContract;
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

namespace IHM
{
    public partial class Form1 : Form, IMeteoServiceCallBack
    {

        IMeteoService proxy;
        public Form1()
        {
            InitializeComponent();
            var factory = new DuplexChannelFactory<IMeteoService>(this, "MyEP");
            proxy = factory.CreateChannel();
        }

        public void WeatherReceived(List<CityTemperature> cities)
        {
            dataGridView1.Invoke((MethodInvoker)delegate
            {
                dataGridView1.DataSource = cities;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proxy.GetCityTemperatureList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.GetTemperature("Toulouse").ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proxy.AskForTemperatures();
        }
    }
}
