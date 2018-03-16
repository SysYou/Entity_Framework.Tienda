using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace cl.Tienda.BL
{
    public class Mantenimiento : IMantenimiento
    {
        private static Mantenimiento instancia;

        public static Mantenimiento Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new BL.Mantenimiento();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = new BL.Mantenimiento();
                }
            }
        }
        public void Insertar(DAL.Ropa ropa)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimiento.Instancia.Insertar(ropa);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public List<Tienda.DAL.Ropa> Mostrar()
        {
            List<cl.Tienda.DAL.Ropa> lista = new List<cl.Tienda.DAL.Ropa>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = cl.Tienda.DAL.Mantenimiento.Instancia.Mostrar();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Actualizar(Tienda.DAL.Ropa ropa)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimiento.Instancia.Actualizar(ropa);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Eliminar(Tienda.DAL.Ropa ropa)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimiento.Instancia.Eliminar(ropa);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
}
