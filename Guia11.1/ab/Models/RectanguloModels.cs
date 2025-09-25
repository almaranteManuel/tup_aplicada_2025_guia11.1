using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models;

public class RectanguloModels
{
    public double Ancho { get; set; }
    public double Largo { get; set; }

    public RectanguloModels(double largo, double ancho) { 
        Ancho = ancho;
        Largo = largo;
    }
}
