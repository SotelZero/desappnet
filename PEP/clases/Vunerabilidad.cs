using System.Collections.Generic;
using System;

namespace Redes.Clases
{
    public class Vulnerabilidad
    {
        private string clave,vendedor,descripcion,tipo;
        private DateTime fecha;

        

        public Vulnerabilidad(string clave,string vendedor,string descripcion,string tipo,DateTime fecha){
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
        }
        
        public string Clave
        {
            get { return clave;}
            set { clave = value;}
        }

        public string Vendedor
        {
            get { return vendedor;}
            set { vendedor = value;}
        }

        public string Descripcion
        {
            get { return Descripcion;}
            set { Descripcion = value;}
        }

        public string Tipo
        {
            get { return tipo;}
            set { tipo = value;}
        }


    }
}