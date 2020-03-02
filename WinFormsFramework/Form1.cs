using BLL.Interfaces;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFramework
{
    public partial class Form1 : Form
    {
        IProbService Service;
        public Form1(IProbService service)
        {
            Service = service;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Service.NewGeneratedSample();
        }

        private async void button_update_Click(object sender, EventArgs e)
        {
            //userBindingSource.DataSource = Service.GetUsers();
            var data =  await Service.GetGeneratedSamples();
            generatedSampleBindingSource.DataSource = data;
        } 

        private async void button_delete_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            await Service.DeleteGeneratedSample(id);
        }
    }
}
