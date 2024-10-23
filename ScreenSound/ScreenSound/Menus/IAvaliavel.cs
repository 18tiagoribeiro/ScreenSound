using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliação nota);
    double Media { get; }
}
