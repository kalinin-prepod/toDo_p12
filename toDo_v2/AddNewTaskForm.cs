using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDo_v2
{
    public partial class AddNewTaskForm : Form
    {
        public string title;
        public string text;
        public string color;
        public AddNewTaskForm()
        {
            InitializeComponent();
            buttonAdd.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            title = textBoxTitle.Text;
            text = textBoxText.Text;
            color = (string)comboBoxColor.SelectedItem;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Length == 0)
                buttonAdd.Enabled = false;
            else
                buttonAdd.Enabled = true;
        }

       
       
    }
}
