using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDo_v2
{
    public class Task
    {
        public string title;
        public string text;
        public string color;

        public bool isDone;
        public int timeStamp;

        public Task(string title, string text) 
        {
            this.title = title;
            this.text = text;

            this.isDone = false;
            this.timeStamp = (int)DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        }


    }
}
