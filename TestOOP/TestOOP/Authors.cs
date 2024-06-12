using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal class Authors
    {
        private string Name;
        Authors[] NameItem;
        

        public Authors(string name,int i)
        {
            Name = name;
            NameItem = new Authors[i];
            i++;
        }

        public void AddAuthor(Authors b)
        {
            for(int i = 0; i < NameItem.Length; i++)
            {
                if (NameItem == null)
                {
                    NameItem[i] = b;
                }
            }
          
        }

        public void Print()
        {
            string info = "____________\n" +
                "Author: "+Name+"\n"+
                "____________________";
            Console.WriteLine(info);
            foreach(Authors b in NameItem)
            {
               if(b != null)
                {
                    break;
                }
               Console.WriteLine(b);
            }
        }

    }
}
