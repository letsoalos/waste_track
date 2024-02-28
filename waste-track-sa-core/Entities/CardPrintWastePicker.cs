using System.Numerics;

namespace waste_track_sa_core.Entities
{
    public class CardPrintWastePicker : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int RegistrationNo { get; set; }
    }
}