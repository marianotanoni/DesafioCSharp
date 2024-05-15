using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioClase5
{
    public class Venta
    {
        private int _Id; 
        private string _Comentarios;
        private string _IdUsuario;

        public Venta(int Id, string Comentarios,string IdUsuario)
        {
            this._Id = Id;
            this._Comentarios = Comentarios;
            this._IdUsuario= IdUsuario;
        }
        public int Id
        { 
            get { return _Id; }
            set { _Id = value; }    
        }
        public string Comentarios
        {
            get { return _Comentarios; }
            set {  this._Comentarios = value; }
        }
        public string IdUsuarios 
        { 
            get { return _IdUsuario; }
            set { this._IdUsuario = value; }
        }
        
    }
}
