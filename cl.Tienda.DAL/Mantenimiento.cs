using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Data.Entity;

namespace cl.Tienda.DAL
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
                    return new Mantenimiento();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }
        public void Insertar(Ropa ropa)
        {
            try
            {
                TiendaEntities db = new TiendaEntities();
                db.Ropas.Add(ropa);
                
                db.SaveChanges();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {

            }
        }

        public List<Ropa> Mostrar()
        {

            //Inicializamos
            List<Ropa> lista = new List<Ropa>();
            try
            {
                TiendaEntities db = new TiendaEntities();
                lista = db.Ropas.ToList();
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }

        }

        public void Actualizar(Ropa ropa)
        {

            try
            {
                TiendaEntities db = new TiendaEntities();
                var _ropa = db.Ropas.Find(ropa.iId);
                _ropa.vNombre = ropa.vNombre;

                _ropa.iGenero = ropa.iGenero;
                _ropa.vCategoria = ropa.vCategoria  ;
                _ropa.dValor = ropa.dValor;
                _ropa.bDisponible = ropa.bDisponible;


                db.SaveChanges();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {

            }

        }

        public void Eliminar(Ropa ropa)
        {

            try
            {
                TiendaEntities db = new TiendaEntities();
                var _ropa = db.Ropas.Find(ropa.iId);
                db.Ropas.Remove(_ropa);
                db.SaveChanges();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {

            }

        }


    }
}
