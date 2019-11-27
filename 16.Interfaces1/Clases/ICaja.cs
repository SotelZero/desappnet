
namespace Interfaces.Clases {
    
    interface ICaja
    {
        string Color { get; set; }
        string Contenido {get; set;}
        bool estaAbierta { get; set;}

      
        bool Abrir();
        bool Cerrar();
    } 

}