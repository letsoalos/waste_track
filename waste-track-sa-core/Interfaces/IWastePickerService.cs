using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
     public interface IWastePickerService
    {
        Task<WastePicker> CreateWastePickerAsync(string FirstName, string LastName, DateOnly DOB, string IdentityNumber, 
            string OtherIdentityNumber, int Age, string CellphoneNo, string AltCellphoneNo, string Potrait, int DocumentTypeId, 
            int WastePickerNo, string Comment, int Consent, string CreatedBy, DateTime CreatedDate, string LastUpdatedBy, DateTime LastUpdatedDate, 
            string RegistrationLocation, int WastePickerStatusId, int GenderId, int RaceId, bool IsMemberCooperative, int CooperativeId, int ActivityStatusId,                       
            DateTime LastActivityDate, int PrintCount, int ManualPrintCount, int AutoPrintCount);
        Task<IReadOnlyList<WastePicker>> GetWastePickersAsync();
        Task<WastePicker> GetWastePickerByIdAsync(int id);
        Task<Gender> GetGenderByWastePickerIdAsync(int id);
        Task<WastePickerStatus> GetWastePickerStatusByIdAsync(int id);
        Task<Race> GetRaceByWastePickerIdAsync(int id);
        Task<DocumentType> GetDocumentTypeByWastePickerIdAsync(int id);


        //TODO
        //update waste picker
        //delete waste picker

    }
}