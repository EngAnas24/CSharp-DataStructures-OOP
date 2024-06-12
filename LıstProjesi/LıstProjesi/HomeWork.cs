using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ListProjesi
{
    internal class HomeWork
    {
        private  List<HomeWork> MembersList = new List<HomeWork>();
        private string name;
        private int age;
        private string sex;
        private static HomeWork home;
        public HomeWork(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public HomeWork()
        {
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }


        public void HelloProgram()
        {


            while (true)
            {
                Console.WriteLine("U can use the number of these options to get what u want: ");
                Console.WriteLine("1. Adding");
                Console.WriteLine("2. Editing");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Show members");
                Console.WriteLine("5. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the name of member: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the age of member: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the sex of member: ");
                        string sex = Console.ReadLine();

                        home = new HomeWork(name, age, sex);
                        MembersList.Add(home);

                        Console.WriteLine("Member added successfully");
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of member to edit: ");
                        string editName = Console.ReadLine();
                        HomeWork memberToEdit = FindMember(editName);

                        if (memberToEdit != null)
                        {
                            Console.WriteLine("Enter the new name: ");
                            memberToEdit.Name = Console.ReadLine();
                            Console.WriteLine("Enter the new age: ");
                            memberToEdit.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the new sex: ");
                            memberToEdit.Sex = Console.ReadLine();
                            Console.WriteLine("Member edited successfully");
                        }
                        else
                        {
                            Console.WriteLine("Member not found");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of member to remove: ");
                        string removeName = Console.ReadLine();
                        HomeWork memberToRemove = FindMember(removeName);

                        if (memberToRemove != null)
                        {
                            MembersList.Remove(memberToRemove);
                            Console.WriteLine("Member removed successfully");
                        }
                        else
                        {
                            Console.WriteLine("Member not found");
                        }
                        break;

                    case 4:
                        if (MembersList.Count == 0)
                        {
                            Console.WriteLine("List is Empty try to Add a member to show it");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Members list:");
                            for (int i = 0;i<MembersList.Count;i++)
                            {
                                home = MembersList[i];  
                                Console.WriteLine($"Name: {home.Name}, Age: {home.Age}, Sex: {home.Sex}");
                            }
                            break;
                        }
                    case 5:
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

        public HomeWork FindMember(string name)
        {
            HomeWork home = null;
            for (int i = 0; i < MembersList.Count; i++)
            {
                if (name == MembersList[i].Name)
                {
                    home = MembersList[i];

                    break;
                }
            }
            return home;
        }
    }
}


