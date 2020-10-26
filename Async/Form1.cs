using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
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
            int count = await ProccessFile();
            label1.Text = count + "Characters";
        }

        int GetCharacterCount()
        {
            int count = 0;

            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        async Task<int> ProccessFile()
        {
            Task<int> task = new Task<int>(GetCharacterCount);
            task.Start();

            return await task;
        }
    }
}
