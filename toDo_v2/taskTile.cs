using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace toDo_v2
{
    
    public class taskTile
    {
        private Panel panel;
        private Button buttonDone;
        private Button buttonDelete;
        private Label labelTitle;
        private Label labelText;

        public  taskTile() 
        { }
        public taskTile(Panel parentPanel, string title, string text)
        {
            this.panel = new Panel();
            this.labelText = new Label();
            this.labelTitle = new Label();
            this.buttonDelete = new Button();
            this.buttonDone = new Button();

            parentPanel.Controls.Add(panel);
            this.panel.Controls.Add(labelText);
            this.panel.Controls.Add(labelTitle);
            this.panel.Controls.Add(buttonDone);
            this.panel.Controls.Add(buttonDelete);

            //панель текущего таска
            this.panel.BackColor = Color.Transparent;
            this.panel.Dock = DockStyle.Top;
            this.panel.Size = new Size(0, 70);


            //labelText
            this.labelText.BackColor = Color.Transparent;
            this.labelText.Dock = DockStyle.Top;
            this.labelText.Font = new Font("Bahnschrift SemiLight SemiConde", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Name = "labelText";
            this.labelText.Size = new Size(47, 20);
            this.labelText.Text = text;

            //labelTitile
            this.labelTitle.BackColor = Color.Transparent;
            this.labelTitle.Dock = DockStyle.Top;
            this.labelTitle.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(47, 20);
            this.labelTitle.Text = title;


            // buttonDone
            // 
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = global::toDo_v2.Properties.Resources.done;
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(81, 350);
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new EventHandler(this.MarkAsDone);


            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::toDo_v2.Properties.Resources.icons8_x_48;
            this.buttonDelete.Name = "buttonDone";
            this.buttonDelete.Size = new System.Drawing.Size(81, 350);
            this.buttonDelete.UseVisualStyleBackColor = true;

        
        }

        
        private void DeleteTask(object sender, EventArgs e)
        {
          
        }

        private void MarkAsDone(object sender, EventArgs e)
        {
            MessageBox.Show("нажато отметить");
        }

    }
}
