using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gastos.Clases
{
    class Datos
    {
        private string _fecha, _lugar,_descripcion,_user,_foto,_correo,_nombre_comercio, _categoria,_direccion,_departamento,_pais;
        private int _importe, _cod_gasto, _contacto;
        public string fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
        public string lugar
        {
            get
            {
                return _lugar;
            }
            set
            {
                _lugar = value;
            }
        }
        public string descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
        public int importe
        {
            get
            {
                return _importe;
            }
            set
            {
                _importe = value;
            }
        }
        public int cod_gasto
        {
            get
            {
                return _cod_gasto;
            }
            set
            {
                _cod_gasto = value;
            }
        }
        public string user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
        public string foto
        {
            get
            {
                return _foto;
            }
            set
            {
                _foto = value;
            }
        }
        public string correo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
            }
        }
        public string nombre_comercio
        {
            get
            {
                return _nombre_comercio;
            }
            set
            {
                _nombre_comercio = value;
            }
        }
        public string categoria
        {
            get
            {
                return _categoria;
            }
            set
            {
                _categoria = value;
            }
        }
        public string direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public string departamento
        {
            get
            {
                return _departamento;
            }
            set
            {
                _departamento = value;
            }
        }
        public string pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
            }
        }

        public int contacto
        {
            get
            {
                return _contacto;
            }
            set
            {
                _contacto = value;
            }
        }
    }
}
