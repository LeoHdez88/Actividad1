class TempRecord
{
    private float[] temps = new float[10]; // Almacena las temperaturas
    // Indexador: permite acceder a las temperaturas como si fueran elementos de una matriz
    public float this[int index]
    {
        get { return temps[index]; }
        set { temps[index] = value; }
    }
}
