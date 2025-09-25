using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.DALs.Utilities;
using GeometriaModels.Models;

namespace GeometriaModels.DALs;

public interface IFigurasDAL<T>:IBaseDAL<FiguraModel, int, T>
{
    //Agregar metodos especificos
    Task ProcesarFiguras(IDALTransaction<T>? transaccion = null);
}
