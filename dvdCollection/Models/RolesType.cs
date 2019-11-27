
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dvdCollection.Models{
    public class RolesType
    {
    public int RoleTypeID {get; set;}
    public string RoleDesc {get; set;}
    
    
    public ICollection<FilmsActorRoles> FilmsActorRoles {get; set;}
    
    }

}
