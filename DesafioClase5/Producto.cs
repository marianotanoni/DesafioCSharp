using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioClase5
{
    public class Producto
    {
        private int _Id;
        private string _Descripcion;
        private double _Costo;
        private double _PrecioVenta;
        private int _Stock;
        private int _IdUsuario;

        public Producto(int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            this._Id = Id;
            this._Descripcion = Descripcion;
            this._Costo = Costo;
            this._PrecioVenta = PrecioVenta;
            this._Stock = Stock;
            this._IdUsuario = IdUsuario;
        }
        public int Id
        { 
            get { return _Id;}
            set {  _Id = value;}
        }
        public string Descripcion 
        {
            get { return _Descripcion;}
            set { this._Descripcion = value; }
        }
        public double Costo
        {
            get { return _Costo;}
            set {  this._Costo = value;}
        }
        public double PrecioVenta
        { 
            get { return _PrecioVenta;}
            set { this._PrecioVenta = value;}
        }   
        public int Stock
        {
            get { return _Stock;}
            set { this._Stock = value;}
        }
        public int IdUsuario
        {
            get {  return _IdUsuario;}
            set { this.IdUsuario = value; }
        }    
    }
}
