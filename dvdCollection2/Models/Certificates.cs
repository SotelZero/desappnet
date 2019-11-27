
using System.Collections.Generic;

namespace dvdCollection.Models{

    public class Certificates
    {
    public int CertificateID {get; set;}
    public string CertificateDesc {get; set;}
    
    
    public ICollection<FilmTitles> FilmsTitles {get; set;}
    
    }

}
