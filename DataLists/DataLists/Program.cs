using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLists
{
    class user
    {
        public user()
        {
        }

        public user(int id, string name, int age, long number)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.number = number;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public long number { get; set; }
    }

    interface IDataHelper<T>
    {
        List<T> getdata();
        T find(int id);
        void add(T s);
        void editor(int id, user s);
        void delete(int id);
    }

    class userentity : IDataHelper<user>
    {
        List<user> arr;
        user user;

        public userentity()
        {
            arr = new List<user>();
        }

        public void add(user s)
        {
            arr.Add(s);
        }

        public void delete(int id)
        {
            user = find(id);
            arr.Remove(user);
        }

        public void editor(int id, user s)
        {
             user = find(id);
            if (user != null)
            {
                user.name = s.name;
                user.age = s.age;
                user.number = s.number;
            }

            else
                Console.WriteLine("Empty List");
                
            
        }

        public user find(int id)
        {
            return arr.Where(x => x.id == id).FirstOrDefault();
        }

        public void printdata()
        {
            List<user> userList = getdata();

            foreach (user u in userList)
            {
                Console.WriteLine("user ID: " + u.id);
                Console.WriteLine("user Name: " + u.name);
                Console.WriteLine("user age: " + u.age);
                Console.WriteLine("user number: " + u.number);
                Console.WriteLine("-------------------------------------------------\n");

            }
        }

        public List<user> getdata()
        {
            return arr.ToList();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            user s = new user(1, "Anas", 24, 05433055030);
            user e = new user(2, "ahmed", 24, 241512454512);
            user r = new user(1, "ANAS", 24, 241512454512);
            user e1 = new user(2, "ahmed", 24, 4888888241512);

            userentity u = new userentity();
            u.add(s);
            u.add(e);
            u.editor(1, r);
            u.editor(2, e1);

            u.printdata();
            Console.ReadKey();
        }
    }
}
  

