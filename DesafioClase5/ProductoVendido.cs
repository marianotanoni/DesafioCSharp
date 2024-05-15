using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioClase5
{
    public class ProductoVendido
    {
        private int _Id;
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;

        public ProductoVendido(int Id,int IdProducto, int stok, int Idventa)
        {
            this._Id = Id;
            this._IdProducto = IdProducto;
            this._Stock = stok;
            this._IdVenta = Idventa;
        }
        public int Id
        {
            get { return _Id; }
            set { this._Id = value; }
        }
        public int IdProducto
        {
            get { return _IdProducto; }
            set { this._IdProducto = value; }
        }
        public int Stock
        {
            get { return _Stock; }
            set { this._Stock = value; }
        }
        public int IdVenta
        {
            get { return _IdVenta; }
            set { this._IdVenta=value; }
        }
    }
}
