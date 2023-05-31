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

    public partial class Form1 : Form
    {

        List<Task> userTasks = new List<Task> { };
        bool showCompleted = false;
        bool showCurrent = true;

        Bitmap checkedBoxIcon = toDo_v2.Properties.Resources.img_checked;
        Bitmap uncheckedBoxIcon = toDo_v2.Properties.Resources.img_unchecked;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Exception ex = DBModule.Connect();
            if (ex != null)
                MessageBox.Show("НЕ удалось подключиться к ДБ:\n" + ex.Message);


            buttonResfesh_Click(sender, e);


        }

        private void buttonAddNewTask_Click(object sender, EventArgs e)
        {
            AddNewTaskForm ntf = new AddNewTaskForm();
            DialogResult result = ntf.ShowDialog();

            if (result == DialogResult.OK)
            {
                Task t = new Task(ntf.title, ntf.text);
                userTasks.Add(t);
                DBModule.AddNew(t);
                UpdatePanelTasks();
            }

        }

        public void UpdatePanelTasks()
        {
            panelTasks.Controls.Clear();

            foreach (var element in userTasks)
            {
                if (element.isDone && !showCompleted)
                    continue;

                if (!element.isDone && !showCurrent)
                    continue;

                taskTile tt = new taskTile(panelTasks, element.title, element.text, element.isDone);
                tt.DeleteNotify += deleteHandler;
                tt.DoneNotify += doneHandler;
            }
        }

        private void doneHandler(string name)
        {
            DialogResult result = MessageBox.Show(
        "Выберите один из вариантов",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);

            if (result != DialogResult.Yes)
                return;

            for (int i = 0; i < userTasks.Count; i++)
            {
                if (name == userTasks[i].text)
                {
                    userTasks[i].isDone = true;
                    break;
                }
            }
            UpdatePanelTasks();
        }

        private void deleteHandler(string name)
        {

            DialogResult result = MessageBox.Show(
     "Выберите один из вариантов",
     "Сообщение",
     MessageBoxButtons.YesNo,
     MessageBoxIcon.Information);

            if (result != DialogResult.Yes)
                return;


            for (int i = 0; i < userTasks.Count; i++)
            {
                if (name == userTasks[i].text)
                {
                    userTasks.RemoveAt(i);
                    break;
                }
            }
            UpdatePanelTasks();
        }

        private void buttonShowCurrent_Click(object sender, EventArgs e)
        {
            if (showCurrent)
            {
                buttonShowCurrent.Image = uncheckedBoxIcon;
                showCurrent = false;
            }
            else
            {
                buttonShowCurrent.Image = checkedBoxIcon;
                showCurrent = true;
            }

            UpdatePanelTasks();
        }

        private void buttonShowCompteted_Click(object sender, EventArgs e)
        {
            if (showCompleted)
            {
                buttonShowCompteted.Image = uncheckedBoxIcon;
                showCompleted = false;
            }
            else
            {
                buttonShowCompteted.Image = checkedBoxIcon;
                showCompleted = true;
            }
            UpdatePanelTasks();
        }

        private void buttonSortByTime_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userTasks.Count; i++)
            {
                int min = i;
                for (int j = i; j < userTasks.Count; j++)
                {
                    if (userTasks[j].timeStamp < userTasks[min].timeStamp)
                        min = j;
                }

                Task swap = userTasks[i];
                userTasks[i] = userTasks[min];
                userTasks[min] = swap;
            }

            UpdatePanelTasks();
        }

        private void buttonResfesh_Click(object sender, EventArgs e)
        {
            if (DBModule.connection.State == ConnectionState.Open)
                userTasks = DBModule.getAllTasks();

            UpdatePanelTasks();
        }
    }
}
