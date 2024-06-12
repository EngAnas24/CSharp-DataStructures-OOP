using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exmple1
{
    internal class Animal
    {
        private string name;
        private string faction;
        private int animals_nums;

      

        public void Check()
        {
            Console.WriteLine("How many animal do u want : ");
            animals_nums = int.Parse(Console.ReadLine());   
            for(int i = 1; i <= animals_nums; i++)
            {
                if (animals_nums > 0)
                {
                    Console.WriteLine(i+".Enter the name of animal");
                    name = Console.ReadLine();
                    Console.WriteLine(i+".Enter the faction of animal");
                    faction = Console.ReadLine();
                    Console.WriteLine(ToString());
                }
                else
                {
                    Console.WriteLine("u entered a wrong number ");
                    break;
                }
                    
            }


        }
                

        public override string ToString()
        {
                       

            return "your anmial is : "+name.ToString()+" it's faction : "+faction.ToString();
        }

    }
}