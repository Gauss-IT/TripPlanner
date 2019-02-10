namespace MultiGraph.Core
{
    public interface IVertex<T>
    {
        int Id { get; }
        T Value { get; set; }
    }
}
