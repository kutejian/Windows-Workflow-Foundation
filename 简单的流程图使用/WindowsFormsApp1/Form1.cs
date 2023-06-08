using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public WorkflowApplication workflow;
        private void button3_Click(object sender, EventArgs e)
        {
            string reason = textBox3.Text;
            int money = int.Parse(textBox4.Text);

            Activity activity1 = new Activity1();
            workflow = new WorkflowApplication(activity1, new Dictionary<string, object>()
            {
                { "R2", reason }, { "M2", money }
            });
            workflow.Run();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isa =  radioButton1.Checked ? true:false;

            workflow.ResumeBookmark("Approvel", isa);        
        }
    }
}
