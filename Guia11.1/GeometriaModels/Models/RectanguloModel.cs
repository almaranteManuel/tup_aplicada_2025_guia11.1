
namespace GeometriaModels.Models;

public class RectanguloModel : FiguraModel
{
    public double Ancho { get; set; }
    public double Largo { get; set; }

    public RectanguloModel (double ancho, double largo)
    {
        Ancho = ancho;
        Largo = largo;
    }

    public RectanguloModel()
    {
    }
}
