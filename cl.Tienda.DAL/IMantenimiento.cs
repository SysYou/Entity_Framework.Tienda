using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cl.Tienda.DAL
{
    public interface IMantenimiento
    {
        void Insertar(Ropa ropa);
        List<Ropa> Mostrar();
        void Actualizar(Ropa ropa);
        void Eliminar(Ropa ropa);
    }
}