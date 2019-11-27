
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dvdCollection.Models{
    public class FilmsActorRoles
    {
    public int  FilmTitleID {get; set;}
    public int ActorID {get; set;}
    
    public int RoleTypeID {get;set;}
    public string CharacterName {get; set;}
    public string CharacterDescription{get; set;}
    
    public Actors Actor {get; set;}
    public RolesType Role {get;set;}

    public FilmTitles FilmTitle {get;set;}    
    }

}
