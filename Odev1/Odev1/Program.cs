using System;
using System.Collections.Generic;
using System.IO;

class FiniteStateTransducer
{
    private Dictionary<string, Dictionary<char, Tuple<string, char>>> transitions;
    private HashSet<string> states;
    private HashSet<char> inputAlphabet;
    private HashSet<char> outputAlphabet;

    public FiniteStateTransducer(string fileName)
    {
        transitions = new Dictionary<string, Dictionary<char, Tuple<string, char>>>();
        states = new HashSet<string>();
        inputAlphabet = new HashSet<char>();
        outputAlphabet = new HashSet<char>();

        try
        {
            ReadFSTFile(fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading FST file: {ex.Message}");
        }
    }

    private void ReadFSTFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('\t');

            if (parts.Length >= 4)
            {
                string state = parts[0];
                char inputSymbol = parts[1][0];
                string nextState = parts[2];
                char outputSymbol = parts[3][0];

                if (!transitions.ContainsKey(state))
                {
                    transitions[state] = new Dictionary<char, Tuple<string, char>>();
                }

                transitions[state][inputSymbol] = new Tuple<string, char>(nextState, outputSymbol);

                states.Add(state);
                states.Add(nextState);
                inputAlphabet.Add(inputSymbol);
                outputAlphabet.Add(outputSymbol);
            }
            else
            {
                Console.WriteLine("Invalid line format: " + line);
            }
        }
    }

    public Tuple<string, string> ProcessInput(string input)
    {
        string currentState = "q0";
        string output = "";
        List<string> stateSequence = new List<string> { currentState };

        foreach (char symbol in input)
        {
            if (transitions.ContainsKey(currentState) && transitions[currentState].ContainsKey(symbol))
            {
                Tuple<string, char> transition = transitions[currentState][symbol];
                currentState = transition.Item1;
                output += transition.Item2;
                stateSequence.Add(currentState);
            }
            else
            {
                Console.WriteLine("Invalid transition found.");
                break;
            }
        }

        return new Tuple<string, string>(output, string.Join(", ", stateSequence));
    }
}

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "D:\\c#\\Asp.net_Web\\Odev1\\FST.txt";
            FiniteStateTransducer fst = new FiniteStateTransducer(filePath);

            Console.WriteLine("FST.txt file has been read.");

            Console.Write("Please enter the first input: ");
            string input1 = Console.ReadLine();

            var result1 = fst.ProcessInput(input1);

            Console.WriteLine($"State sequence: {result1.Item2}");
            Console.WriteLine($"Output: {result1.Item1}");

            Console.Write("\nPlease enter the second input: ");
            string input2 = Console.ReadLine();

            var result2 = fst.ProcessInput(input2);

            Console.WriteLine($"State sequence: {result2.Item2}");
            Console.WriteLine($"Output: {result2.Item1}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}