using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pproga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Выбор завершен";
        }

        private void dateTimePicker1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Производится выбор";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Text);
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text= "Клик";
            label3.Text = "Клик"; 
            label4.Text = "Клик"; 
            label5.Text = "Клик";
        }

        private void flowLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "Клик Клик";
            label3.Text = "Клик Клик";
            label4.Text = "Клик Клик";
            label5.Text = "Клик Клик";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            textBox1.Text = "";
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = "youtube.com";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public event EventHandler HelpRequest;
    }
}
