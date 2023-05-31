
namespace toDo_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonSortByName = new System.Windows.Forms.Button();
            this.buttonSortByTime = new System.Windows.Forms.Button();
            this.buttonShowCompteted = new System.Windows.Forms.Button();
            this.buttonShowCurrent = new System.Windows.Forms.Button();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonAddNewTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResfesh = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLeft.Controls.Add(this.buttonSortByName);
            this.panelLeft.Controls.Add(this.buttonSortByTime);
            this.panelLeft.Controls.Add(this.buttonShowCompteted);
            this.panelLeft.Controls.Add(this.buttonShowCurrent);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(185, 350);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonSortByName
            // 
            this.buttonSortByName.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSortByName.FlatAppearance.BorderSize = 0;
            this.buttonSortByName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortByName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByName.Image = global::toDo_v2.Properties.Resources.img_unchecked;
            this.buttonSortByName.Location = new System.Drawing.Point(0, 144);
            this.buttonSortByName.Name = "buttonSortByName";
            this.buttonSortByName.Size = new System.Drawing.Size(185, 48);
            this.buttonSortByName.TabIndex = 6;
            this.buttonSortByName.Text = "Sort by Name";
            this.buttonSortByName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSortByName.UseVisualStyleBackColor = true;
            // 
            // buttonSortByTime
            // 
            this.buttonSortByTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSortByTime.FlatAppearance.BorderSize = 0;
            this.buttonSortByTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonSortByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortByTime.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByTime.Image = global::toDo_v2.Properties.Resources.img_unchecked;
            this.buttonSortByTime.Location = new System.Drawing.Point(0, 96);
            this.buttonSortByTime.Name = "buttonSortByTime";
            this.buttonSortByTime.Size = new System.Drawing.Size(185, 48);
            this.buttonSortByTime.TabIndex = 5;
            this.buttonSortByTime.Text = "Sort by time";
            this.buttonSortByTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSortByTime.UseVisualStyleBackColor = true;
            this.buttonSortByTime.Click += new System.EventHandler(this.buttonSortByTime_Click);
            // 
            // buttonShowCompteted
            // 
            this.buttonShowCompteted.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowCompteted.FlatAppearance.BorderSize = 0;
            this.buttonShowCompteted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonShowCompteted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCompteted.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCompteted.Image = global::toDo_v2.Properties.Resources.img_unchecked;
            this.buttonShowCompteted.Location = new System.Drawing.Point(0, 48);
            this.buttonShowCompteted.Name = "buttonShowCompteted";
            this.buttonShowCompteted.Size = new System.Drawing.Size(185, 48);
            this.buttonShowCompteted.TabIndex = 4;
            this.buttonShowCompteted.Text = "Show Completed";
            this.buttonShowCompteted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowCompteted.UseVisualStyleBackColor = true;
            this.buttonShowCompteted.Click += new System.EventHandler(this.buttonShowCompteted_Click);
            // 
            // buttonShowCurrent
            // 
            this.buttonShowCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowCurrent.FlatAppearance.BorderSize = 0;
            this.buttonShowCurrent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonShowCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCurrent.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCurrent.Image = global::toDo_v2.Properties.Resources.img_checked;
            this.buttonShowCurrent.Location = new System.Drawing.Point(0, 0);
            this.buttonShowCurrent.Name = "buttonShowCurrent";
            this.buttonShowCurrent.Size = new System.Drawing.Size(185, 48);
            this.buttonShowCurrent.TabIndex = 3;
            this.buttonShowCurrent.Text = "Show Current";
            this.buttonShowCurrent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowCurrent.UseVisualStyleBackColor = true;
            this.buttonShowCurrent.Click += new System.EventHandler(this.buttonShowCurrent_Click);
            // 
            // panelTasks
            // 
            this.panelTasks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasks.Location = new System.Drawing.Point(185, 100);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(615, 350);
            this.panelTasks.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::toDo_v2.Properties.Resources.bg11;
            this.panelTop.Controls.Add(this.buttonResfesh);
            this.panelTop.Controls.Add(this.buttonAddNewTask);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 0;
            // 
            // buttonAddNewTask
            // 
            this.buttonAddNewTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewTask.BackgroundImage = global::toDo_v2.Properties.Resources.add_icon;
            this.buttonAddNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNewTask.FlatAppearance.BorderSize = 0;
            this.buttonAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewTask.Location = new System.Drawing.Point(139, 38);
            this.buttonAddNewTask.Name = "buttonAddNewTask";
            this.buttonAddNewTask.Size = new System.Drawing.Size(30, 30);
            this.buttonAddNewTask.TabIndex = 1;
            this.buttonAddNewTask.UseVisualStyleBackColor = false;
            this.buttonAddNewTask.Click += new System.EventHandler(this.buttonAddNewTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Tasks";
            // 
            // buttonResfesh
            // 
            this.buttonResfesh.Location = new System.Drawing.Point(670, 38);
            this.buttonResfesh.Name = "buttonResfesh";
            this.buttonResfesh.Size = new System.Drawing.Size(75, 41);
            this.buttonResfesh.TabIndex = 2;
            this.buttonResfesh.Text = "Refresh";
            this.buttonResfesh.UseVisualStyleBackColor = true;
            this.buttonResfesh.Click += new System.EventHandler(this.buttonResfesh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTasks);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonShowCurrent;
        private System.Windows.Forms.Button buttonSortByName;
        private System.Windows.Forms.Button buttonSortByTime;
        private System.Windows.Forms.Button buttonShowCompteted;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.Button buttonAddNewTask;
        private System.Windows.Forms.Button buttonResfesh;
    }
}

