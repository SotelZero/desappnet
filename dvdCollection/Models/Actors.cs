
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dvdCollection.Models{
    public class Actors
    {
    [key]
    public int ActorID {get; set;}
    public string ActorFullName {get; set;}
    public string ActorsNotes {get; set;}
    
    public ICollection<FilmsActorRoles> FilmsActorRoles {get; set;}
    
    }

}
