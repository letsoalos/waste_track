using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
    public interface IWastePickerRepository : IGenericRepository<WastePicker> 
    {
        void Update(WastePicker obj);
        void Save();
    }
}