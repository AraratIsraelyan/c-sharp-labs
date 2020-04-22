using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Part_2___task_3_TimerEvents
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }
        public int count = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
           
            label1.Text = count.ToString();
            count += 1;
            
            progressBar1.Value += 1;
            if (progressBar1.Value >= 10) t.Stop();
            
            if (count >= 10)
            {
                t.Stop();
                label1.Text = "Отчёт завершён";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick +=new EventHandler(timer_Tick);
            t.Start();
            progressBar1.Maximum = 10;
            //throw new System.NotImplementedException();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
    
}