namespace ScreenSound.Modelos;

internal class Avaliação
{
    public Avaliação(int nota)
    {
      if (nota <= 0) nota = 0;
      if (nota >= 10) nota = 10;
        Nota = nota;
    }
    public int Nota { get; }

    public static Avaliação Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliação(nota);
    }
}
