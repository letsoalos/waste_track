using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Data
{
    public class WastePickerRepository : GenericRepository<WastePicker>, IWastePickerRepository
    {
        private readonly DataContext _context;
        public WastePickerRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(WastePicker obj)
        {
            _context.WastePickers.Update(obj);
        }
    }
}