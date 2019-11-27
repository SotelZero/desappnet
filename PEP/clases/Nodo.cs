using System.Collections.Generic;
using System;

namespace Redes.Clases
{
    public class Nodo
    {
        string ip,tipo,puertos,saltos,so;
        private List<Vulnerabilidad> vnd;
    
        public Nodo(string ip, string tipo, string puertos, string saltos, string so){
            this.ip=ip;
            this.tipo=tipo;
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=so;
            vnd = new List<Vulnerabilidad>();
        }     

        public string Ip
        {
            get { return ip;}
            set { ip = value;}
        }
        
        public string Tipo
        {
            get { return tipo;}
            set { tipo = value;}
        }

        public string Puertos
        {
            get { return puertos;}
            set { puertos = value;}
        }
        public string Saltos
        {
            get { return saltos;}
            set { saltos = value;}
        }
        
        public string So
        {
            get { return so;}
            set { so = value;}
        }

        public void AgregarVlnd(Vulnerabilidad vlnd){
            vnd.Add(vlnd);
        }

         public List<Vulnerabilidad> vlnd{
            get{return vnd;}
        }     
    }
}