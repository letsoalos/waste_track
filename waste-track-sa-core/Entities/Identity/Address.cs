using System.ComponentModel.DataAnnotations;

namespace waste_track_sa_core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }   
        public string FirstName { get; set; }   
        public string LastName { get; set; }    
        public string Street { get; set; }
        public string City { get; set; }  
        public string Code { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }        
    }
}