public interface IIndexInterface
{
    // Indexador de solo lectura
    int this[int index] { get; }
}
// Implementación de la interfaz
class IndexerClass : IIndexInterface
{
    private int[] arr = new int[100];
    public int this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }
}
