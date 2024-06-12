using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write Input string : ");

        string inputString = Console.ReadLine();
        bool isAccepted = CheckString(inputString);
        
        if (isAccepted)
        {
            Console.WriteLine("Input string is accepted!");
        }
        else
        {
            Console.WriteLine("Input string is not accepted!");
        }
    }

    static bool CheckString(string input)
    {
        int state = 0; // Start from the initial state

        foreach (char c in input)
        {
            switch (state)
            {
                case 0:
                    if (c == 'a')
                        state = 1;
                    break;
                case 1:
                    if (c == 'b')
                        state = 2;
                    break;
                case 2:
                    if (c == 'a')
                        state = 3;
                    break;
                case 3:
                    if (c == 'c')
                        state = 4;
                    break;
                default:
                    return false; // Invalid state
            }
        }

        return state == 4; // Check if the final state is the accepting state
    }
}