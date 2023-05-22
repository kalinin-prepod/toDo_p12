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
            userTasks.Add(new Task("Сходить в магазин","Купить баклажан-убийцу"));
            userTasks.Add(new Task("Войти в тайное общество","Пароль рыжий воланчик"));
            userTasks.Add(new Task("Заказать еды","С алиэкспресс"));
            userTasks.Add(new Task("сделано 1", "С алиэкспресс"));            
            userTasks.Add(new Task("сделано 2", "С алиэкспресс"));
            userTasks[3].isDone = true;
            userTasks[4].isDone = true;

            userTasks[0].timeStamp = 200;
            userTasks[1].timeStamp = 300;
            userTasks[2].timeStamp = 100;
            userTasks[3].timeStamp = 400;
            userTasks[4].timeStamp = 500;

            UpdatePanelTasks();

           
        }

        private void buttonAddNewTask_Click(object sender, EventArgs e)
        {
            AddNewTaskForm ntf = new AddNewTaskForm();
            DialogResult result = ntf.ShowDialog();

            if (result == DialogResult.OK) 
            {
                userTasks.Add(new Task(ntf.title, ntf.text));
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

                new taskTile(panelTasks, element.title, element.text);          
            }
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
    }
}
