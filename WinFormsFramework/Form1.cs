using BLL.Interfaces;
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Service.NewGeneratedSample();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //userBindingSource.DataSource = Service.GetUsers();
            generatedSampleBindingSource.DataSource = Service.GetGeneratedSamples();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            Service.DeleteGeneratedSample(id);
        }
    }
}
