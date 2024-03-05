using System.Numerics;

namespace waste_track_sa_core.Entities
{
    public class WastePicker : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string IdentityNumber { get; set; }
        public string OtherIdentityNumber { get; set; }
        public int Age { get; set; }
        public string CellphoneNo { get; set; }
        public string AltCellphoneNo { get; set; }
        public string Potrait { get; set; }
        public int DocumentTypeId { get; set; }
        public int WastePickerNo { get; set; }
        public string Comment { get; set; }
        public int Consent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string RegistrationLocation { get; set; }
        public int WastePickerStatusId { get; set; }
        public int GenderId { get; set; }
        public int RaceId { get; set; }
        public bool IsMemberCooperative { get; set; }
        public int CooperativeId { get; set; }
        public int ActivityStatusId { get; set; }                      //cant locate related table
        public DateTime LastActivityDate { get; set; }
        public int PrintCount { get; set; }                            //cant locate related table
        public int ManualPrintCount { get; set; }                     //cant locate related table
        public int AutoPrintCount { get; set; }                       //cant locate related table                     


        public DocumentType DocumentType { get; set; }   
        public WastePickerStatus WastePickerStatus { get; set; } 
        public Gender Gender { get; set; }    
        public Race Race { get; set; }
        public Cooperative Cooperative { get; set; }
    }
}