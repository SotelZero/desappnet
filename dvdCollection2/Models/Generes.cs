
using System.Collections.Generic;
namespace dvdCollection.Models{
    public class Generes
    {
    public int GenereID {get; set;}
    public string GenereDesc {get; set;}
    
    
    public ICollection<FilmTitles> FilmsTitles {get; set;}
    
    }

}
