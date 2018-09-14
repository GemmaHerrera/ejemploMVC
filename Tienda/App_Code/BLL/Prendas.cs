using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Prendas
/// </summary>
/// 
namespace BLL
{
    public class Prendas
{
    public Prendas()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
        public static long InsertPrenda(PrendasInfo info)
        {

            Prenda Prenda = new Prenda(); //Objeto creado de la clase DAL//Se pasa la info a cada propiedad del objeto.

            Prenda.FechaCreacion = DateTime.Now;

            Prenda.IDPrenda = info.IDPrenda;
            Prenda.Color = info.Color;
            Prenda.Tipo = info.Tipo;
            Prenda.Precio = info.Precio;
            Prenda.Talla = info.Talla;
            Prenda.IDCateg = info.IDCateg;
            Prenda.IDTemp = info.IDTemp;
            //objeto de data context
            DataClassesDataContext dc = new DataClassesDataContext();

            dc.Prenda.InsertOnSubmit(Prenda);
            dc.SubmitChanges(); //ejecuta cambios

            return Prenda.IDPrenda;

        }
}
    public class PrendasInfo
    {
        public long IDPrenda { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        public string Color { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public string Talla { get; set; }
        public long IDCateg { get; set; }
        public long IDTemp { get; set; }
    }

  
}