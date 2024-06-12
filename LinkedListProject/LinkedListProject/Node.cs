public class Node
{
    public double Data { get; set; }
    public Node Next { get; set; }

    public Node(double data)
    {
        Data = data;
        Next = null;
    }

    public Node()
    {
    }
}
