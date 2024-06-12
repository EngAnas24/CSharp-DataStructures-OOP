using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class LinQ
    {
        public int Id;
        public string Name;

      

     
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<LinQ> linQs = new List<LinQ>{
            new LinQ { Id = 1,Name="Anas"},
            new LinQ { Id = 2,Name="Ahmed"}

            };

            LinQ linQ = new LinQ();
            linQ.Id = 1;
            linQ.Name = "Ali";
            linQs.Add(linQ);
          
            foreach (var test in linQs)
            {
                Console.WriteLine(test.Name);
            }
            Console.ReadLine();
         }
    }
}
