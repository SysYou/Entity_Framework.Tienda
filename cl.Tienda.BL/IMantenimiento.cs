using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cl.Tienda.BL
{
    public interface IMantenimiento
    {
        void Insertar(Tienda.DAL.Ropa ropa);
        List<Tienda.DAL.Ropa> Mostrar();
        void Actualizar(Tienda.DAL.Ropa ropa);
        void Eliminar(Tienda.DAL.Ropa ropa);
    }

}