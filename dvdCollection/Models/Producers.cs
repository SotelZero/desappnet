
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models{

    public class Producers
    {
    public int ProducerID{get; set;}
    public string ProducerName {get; set;}
    public string ContactEmailAddress {get;set;}
    public string WebSite{get;set;}
    
    
    public ICollection<FilmTitlesProducers> FilmTitlesProducers {get; set;}
    }

}
