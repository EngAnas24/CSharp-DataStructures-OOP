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
    public Dictionary<string, State> states;
    private string initialState;
    private string currentState;

    public FSTMachine()
    {
        states = new Dictionary<string, State>();
        initialState = "";
        currentState = "";
    }

    public void AddState(string name)
    {
        states[name] = new State(name);
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
            State currentStateObj = states[currentState];
            Transition transition = currentStateObj.Transitions[symbol];

            currentState = transition.NextState;
            output.Append(transition.Output);
            stateSequence.Append(currentState).Append(", ");
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
            using (StreamReader reader = new StreamReader("FST.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');

                    if (parts.Length == 3)
                    {
                        string currentState = parts[0];
                        char inputSymbol = parts[1][0];
                        string nextState = parts[2];

                        if (!fstMachine.states.ContainsKey(currentState))
                            fstMachine.AddState(currentState);

                        fstMachine.states[currentState].Transitions[inputSymbol] = new Transition(nextState, inputSymbol.ToString());
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Hata: {e.Message}");
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
        Console.ReadLine();
    }
}
