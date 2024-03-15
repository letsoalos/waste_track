using waste_track_sa_core.Entities;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_core.Interfaces
{
     public interface IWastePickerService
    {
        Task<WastePicker> CreateWastePickerAsync(WastePicker wastePicker);
        Task<WastePicker> UpdateWastePickerAsync(WastePicker wastePicker);
        Task<IReadOnlyList<WastePicker>> GetWastePickersAsync(WastePickerSpecParams wastePickerParams);
        Task<WastePicker> GetWastePickerByIdAsync(int id);
        Task<Gender> GetGenderByWastePickerIdAsync(int id);        
        Task<WastePickerStatus> GetWastePickerStatusByIdAsync(int id);
        Task<Race> GetRaceByWastePickerIdAsync(int id);
        Task<DocumentType> GetDocumentTypeByWastePickerIdAsync(int id);


        //TODO
        //delete waste picker

    }
}