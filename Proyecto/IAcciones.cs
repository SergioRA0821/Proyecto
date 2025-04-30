using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal interface IAcciones
    {
        List<Alumno> Consultar();
        void Agregar(string nombre, int edad, int matricula);
        void Eliminar(int matricula);
        void Actualizar(string nombre, int edad, int matricula);
        void ExportarExcel();
    }
}
