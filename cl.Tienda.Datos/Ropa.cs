using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl.Tienda.Datos
{
    public class Ropa
    {

        private int iLd;

        public int Id
        {
            get { return iLd; }
            set { iLd = value; }
        }

        private string vNombre;

        public string Nombre
        {
            get { return vNombre; }
            set { vNombre = value; }
        }

        private int iGenero;

        public int Genero
        {
            get { return iGenero; }
            set { iGenero = value; }
        }


        private string vCategoria;

        public string Categoria
        {
            get { return vCategoria; }
            set { vCategoria = value; }
        }





        private decimal dValor;

        public decimal Valor
        {
            get { return dValor; }
            set { dValor = value; }
        }


        private bool BDisponible;

        public bool Disponible
        {
            get { return BDisponible; }
            set { BDisponible = value; }
        }


      



    }
}
