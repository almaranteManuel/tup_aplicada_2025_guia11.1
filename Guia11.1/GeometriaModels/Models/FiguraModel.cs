using System;
namespace GeometriaModels.Models;

public class FiguraModel
{
    public int Id { get; set; }
    public double Area {  get; set; }

    public FiguraModel() { }
    public FiguraModel(int id, double area) {
        Id = id;
        Area = area;
    }

}
