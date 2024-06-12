using System;
using System.Collections.Generic;
using System.IO;

class State
{
    public string Name { get; set; }
    public Dictionary<char, Transition> Transitions { get; set; }

    public State(string name)
    {
        Name = name;
        Transitions = new Dictionary<char, Transition>();
    }
}

class Transition
{
    public string NextState { get; set; }
    public string Output { get; set; }

    public Transition(string nextState, string output)
    {
        NextState = nextState;
        Output = output;
    }
}

class FSTMachine
{
    public Dictionary<string, State> States { get; private set; }
    private string initialState;
    private string currentState;

    public FSTMachine()
    {
        States = new Dictionary<string, State>();
        initialState = "";
        currentState = "";
    }

    public void AddState(string name)
    {
        States[name] = new State(name);
    }

    public void SetInitialState(string initialState)
    {
        this.initialState = initialState;
        currentState = initialState;
    }

    public string ProcessInput(string input)
    {
        var output = new System.Text.StringBuilder();
        var stateSequence = new System.Text.StringBuilder();

        foreach (char symbol in input)
        {
            if (States.TryGetValue(currentState, out State currentStateObj))
            {
                if (currentStateObj.Transitions.TryGetValue(symbol, out Transition transition))
                {
                    currentState = transition.NextState;
                    output.Append(transition.Output);
                    stateSequence.Append(currentState).Append(", ");
                }
                else
                {
                    Console.WriteLine($"Error: No transition for symbol '{symbol}' in state '{currentState}'");
                    return string.Empty;
                }
            }
            else
            {
                Console.WriteLine($"Error: State '{currentState}' not found.");
                return string.Empty;
            }
        }

        return $"Durumların sırası: {stateSequence.ToString()}\nÇıktı: {output.ToString()}";
    }
}

class Program
{
    static void Main()
    {
        FSTMachine fstMachine = new FSTMachine();

        try
        {
            using (StreamReader reader = new StreamReader("D:\\c#\\Asp.net_Web\\Odev\\Odev\\FST.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');

                    if (parts.Length >= 4) // Check if there are enough parts in the line
                    {
                        string stateName = parts[0];
                        fstMachine.AddState(stateName);

                        if (fstMachine.States.Count == 1)
                        {
                            fstMachine.SetInitialState(stateName);
                        }

                        char inputSymbol = parts[1][0];
                        string nextState = parts[2];
                        string outputSymbol = parts[3];

                        if (fstMachine.States.TryGetValue(stateName, out State currentState))
                        {
                            currentState.Transitions.Add(inputSymbol, new Transition(nextState, outputSymbol));
                        }
                        else
                        {
                            Console.WriteLine($"Error: State '{stateName}' not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: Insufficient parts in the line '{line}'.");
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }


        Console.WriteLine("FST.txt dosyası okundu.");

        Console.WriteLine("Lütfen birinci input'u giriniz:");
        string input1 = Console.ReadLine();
        string result1 = fstMachine.ProcessInput(input1);
        Console.WriteLine(result1);

        Console.WriteLine("Lütfen ikinci input'u giriniz:");
        string input2 = Console.ReadLine();
        string result2 = fstMachine.ProcessInput(input2);
        Console.WriteLine(result2);
    }
}
