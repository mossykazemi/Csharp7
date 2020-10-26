using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Please Wait ...";
            string name = await SayHello();
            label1.Text = "Hey " + name;
        }

        async Task<string> GetName()
        {
            await Task.Delay(5000);
            return "Mostafa Kazemi";
        }

        ValueTask<string> SayHello()
        {
            return new ValueTask<string>(GetName());
        }
    }
}
