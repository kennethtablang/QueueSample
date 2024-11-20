using System;
using System.Collections;
using System.Windows.Forms;

namespace QueueSample
{
    public partial class Form1 : Form
    {
        Queue kwewe;
        public Form1()
        {
            InitializeComponent();
            kwewe = new Queue(); //

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            kwewe.Enqueue(txtInput.Text);
            lvDisplay.Items.Clear();
            foreach(Object obj in kwewe)
            {
                lvDisplay.Items.Add(obj.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            kwewe.Dequeue();
            lvDisplay.Items.Clear();
            foreach (Object obj in kwewe)
            {
                lvDisplay.Items.Add(obj.ToString());
            }
        }
    }
}
