namespace TFLTripPlanner;

public class Station
{
    public string Name { get; }
    public List<Connection> Connections { get; }

    public double TimeFromStart { get; set; }
    public bool Visited { get; set; }
    public Station Previous { get; set; }
    public Station Next { get; set; }

    public string currentLine { get; set; }

    public Station(string name)
    {
        Name = name;
        Connections = new List<Connection>();
        TimeFromStart = double.PositiveInfinity;
        Visited = false;
        Previous = null;
        Next = null;
        currentLine = "";
    }

    public void AddConnection(Station station, double weight, string line, string direction)
    {
        Connections.Add(new Connection(station, weight, line, direction));
    }
}