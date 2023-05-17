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
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskTile tile = new taskTile(panelTasks,"Заголовок1","Текст задания1");
            taskTile tile1 = new taskTile(panelTasks,"Заголовок2","Текст задания2");
            taskTile tile2 = new taskTile(panelTasks,"Заголовок3","Текст задания3");
            taskTile tile3 = new taskTile(panelTasks,"Заголовок4","Текст задания4");
            taskTile tile4 = new taskTile(panelTasks,"Заголовок5","Текст задания5");

        }

       
    }
}
