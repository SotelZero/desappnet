
using System.Collections.Generic;
namespace dvdCollection.Models{
    public class Actors
    {
    public int ActorID {get; set;}
    public string ActorFullName {get; set;}
    public string ActorsNotes {get; set;}
    
    public ICollection<FilmsActorRoles> FilmsActorRoles {get; set;}
    
    }

}
