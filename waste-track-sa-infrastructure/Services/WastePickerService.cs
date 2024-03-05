using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_infrastructure.Services
{
    public class WastePickerService : IWastePickerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public WastePickerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public Task<WastePicker> CreateWastePickerAsync(string FirstName, string LastName, DateOnly DOB, string IdentityNumber, string OtherIdentityNumber, int Age, string CellphoneNo, string AltCellphoneNo, string Potrait, int DocumentTypeId, int WastePickerNo, string Comment, int Consent, string CreatedBy, DateTime CreatedDate, string LastUpdatedBy, DateTime LastUpdatedDate, string RegistrationLocation, int WastePickerStatusId, int GenderId, int RaceId, bool IsMemberCooperative, int CooperativeId, int ActivityStatusId, DateTime LastActivityDate, int PrintCount, int ManualPrintCount, int AutoPrintCount)
        {
            throw new NotImplementedException();
        }        

        public async Task<WastePicker> GetWastePickerByIdAsync(int id)
        {
             var spec = new WastePickersWithLookUpDataSpecification();

            return await _unitOfWork.Repository<WastePicker>().GetEntityWithSpec(spec);
        }

        public async Task<IReadOnlyList<WastePicker>> GetWastePickersAsync()
        {
            var spec = new WastePickersWithLookUpDataSpecification();
           
            return await _unitOfWork.Repository<WastePicker>().ListAsync(spec);
        }

        public async Task<Gender> GetGenderByWastePickerIdAsync(int id)
        {
            return await _unitOfWork.Repository<Gender>().GetByIdAsync(id);
        }

        public async Task<WastePickerStatus> GetWastePickerStatusByIdAsync(int id)
        {
           return await _unitOfWork.Repository<WastePickerStatus>().GetByIdAsync(id);
        }

        public async Task<Race> GetRaceByWastePickerIdAsync(int id)
        {
           return await _unitOfWork.Repository<Race>().GetByIdAsync(id);
        }

        public async Task<DocumentType> GetDocumentTypeByWastePickerIdAsync(int id)
        {
            return await _unitOfWork.Repository<DocumentType>().GetByIdAsync(id); 
        }
    }
}