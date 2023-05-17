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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userTasks.Add(new Task("Сходить в магазин","Купить баклажан-убийцу"));
            userTasks.Add(new Task("Войти в тайное общество","Пароль рыжий воланчик"));
            userTasks.Add(new Task("Заказать еды","С алиэкспресс"));
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

        private void UpdatePanelTasks() 
        {
            panelTasks.Controls.Clear();

            foreach (var element in userTasks)
            {
                new taskTile(panelTasks, element.title, element.text);
            }
        }

    }
}
