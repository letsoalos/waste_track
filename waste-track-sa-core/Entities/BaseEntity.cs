using System.ComponentModel.DataAnnotations.Schema;

namespace waste_track_sa_core.Entities
{ 
    public class BaseEntity 
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}