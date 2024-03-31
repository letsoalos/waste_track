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
        
        public async Task<WastePicker> CreateWastePickerAsync(WastePicker wastePicker)
        {  
            var existingWastePicker = await _unitOfWork.Repository<WastePicker>().Get(x => x.Id == wastePicker.Id);

            // Generate a unique Waste Picker Number
           int wastePickerNumber;
           do
           {
                wastePickerNumber = Convert.ToInt32(GenerateUniqueWastePickerNumber());
           } while (await WastePickerNumberExists(wastePickerNumber)); while (await WastePickerNumberExists(wastePickerNumber));


            if (existingWastePicker == null)
            {
                wastePicker = new WastePicker()
                {
                    FirstName = wastePicker.FirstName,
                    LastName = wastePicker.LastName,
                    DOB = wastePicker.DOB,
                    IdentityNumber = wastePicker.IdentityNumber,
                    OtherIdentityNumber = wastePicker.OtherIdentityNumber,
                    Age = wastePicker.Age,
                    CellphoneNo = wastePicker.CellphoneNo,
                    AltCellphoneNo = wastePicker.AltCellphoneNo,
                    Potrait = wastePicker.Potrait,
                    DocumentTypeId = wastePicker.DocumentTypeId,
                    WastePickerNo = wastePickerNumber,
                    Comment = wastePicker.Comment,
                    Consent = wastePicker.Consent,
                    CreatedBy = wastePicker.CreatedBy = "test@gmail.com",
                    CreatedDate = wastePicker.CreatedDate = DateTime.Now.ToString(),
                    LastUpdatedBy = wastePicker.LastUpdatedBy,
                    LastUpdatedDate = wastePicker.LastUpdatedDate,
                    RegistrationLocation = wastePicker.RegistrationLocation,
                    WastePickerStatusId = wastePicker.WastePickerStatusId,
                    GenderId = wastePicker.GenderId,
                    RaceId = wastePicker.RaceId,
                    IsMemberCooperative = wastePicker.IsMemberCooperative,
                    CooperativeId = wastePicker.CooperativeId,
                    ActivityStatusId = wastePicker.ActivityStatusId,
                    LastActivityDate = wastePicker.LastActivityDate,
                    PrintCount = wastePicker.PrintCount,
                    ManualPrintCount = wastePicker.ManualPrintCount,
                    AutoPrintCount = wastePicker.AutoPrintCount
                };
            }
         
            _unitOfWork.Repository<WastePicker>().Add(wastePicker);
            var result = await _unitOfWork.Complete();
           

            return wastePicker;
        }

        public async Task<WastePicker> UpdateWastePickerAsync(WastePicker wastePicker)
        {
            if (wastePicker == null) return null;

            var existingWastePicker = await _unitOfWork.Repository<WastePicker>().Get(x => x.Id == wastePicker.Id);

            if (existingWastePicker != null)
            {
                wastePicker = new WastePicker()
                {
                    
                    FirstName = wastePicker.FirstName,
                    LastName = wastePicker.LastName,
                    DOB = wastePicker.DOB,
                    IdentityNumber = wastePicker.IdentityNumber,
                    OtherIdentityNumber = wastePicker.OtherIdentityNumber,
                    Age = wastePicker.Age,
                    CellphoneNo = wastePicker.CellphoneNo,
                    AltCellphoneNo = wastePicker.AltCellphoneNo,
                    Potrait = wastePicker.Potrait,
                    DocumentTypeId = wastePicker.DocumentTypeId,
                    WastePickerNo = wastePicker.WastePickerNo,
                    Comment = wastePicker.Comment,
                    Consent = wastePicker.Consent,
                    CreatedBy = wastePicker.CreatedBy,
                    CreatedDate = wastePicker.CreatedDate,
                    LastUpdatedBy = wastePicker.LastUpdatedBy,
                    LastUpdatedDate = wastePicker.LastUpdatedDate,
                    RegistrationLocation = wastePicker.RegistrationLocation,
                    WastePickerStatusId = wastePicker.WastePickerStatusId,
                    GenderId = wastePicker.GenderId,
                    RaceId = wastePicker.RaceId,
                    IsMemberCooperative = wastePicker.IsMemberCooperative,
                    CooperativeId = wastePicker.CooperativeId,
                    ActivityStatusId = wastePicker.ActivityStatusId,
                    LastActivityDate = wastePicker.LastActivityDate,
                    PrintCount = wastePicker.PrintCount,
                    ManualPrintCount = wastePicker.ManualPrintCount,
                    AutoPrintCount = wastePicker.AutoPrintCount
                };
            }

            _unitOfWork.Repository<WastePicker>().UpdateAsync(wastePicker);
            var result = await _unitOfWork.Complete();           

            return wastePicker;
        }        

        public async Task<WastePicker> GetWastePickerByIdAsync(int id)
        {
             var spec = new WastePickersWithLookUpDataSpecification(id);

            return await _unitOfWork.Repository<WastePicker>().GetEntityWithSpec(spec);
        }

        public async Task<IReadOnlyList<WastePicker>> GetWastePickersAsync(WastePickerSpecParams wastePickerParams)
        {
            var spec = new WastePickersWithLookUpDataSpecification(wastePickerParams);

            var countSpec = new WastePickerWithFiletrsForCountSpecification(wastePickerParams);

            var totalWastePickers = await _unitOfWork.Repository<WastePicker>().CountAsync(spec);
           
            return await _unitOfWork.Repository<WastePicker>().ListAsync(spec);
        }

        public async Task<Gender> GetGenderByWastePickerIdAsync(int id)
        {
            return await _unitOfWork.Repository<Gender>().Get(x => x.Id == id);
        }      

        public async Task<WastePickerStatus> GetWastePickerStatusByIdAsync(int id)
        {
           return await _unitOfWork.Repository<WastePickerStatus>().Get(x => x.Id == id);
        }

        public async Task<Race> GetRaceByWastePickerIdAsync(int id)
        {
           return await _unitOfWork.Repository<Race>().Get(x => x.Id == id);
        }

        public async Task<DocumentType> GetDocumentTypeByWastePickerIdAsync(int id)
        {
            return await _unitOfWork.Repository<DocumentType>().Get(x => x.Id == id);
        }



    //generate waste picker number
    static List<int> GenerateUniqueNumbers(int count)
    {
        if (count > 10)
        {
            throw new ArgumentException("Count should not exceed 10 to ensure uniqueness.");
        }

        List<int> numbers = new List<int>();
        Random random = new Random();

        while (numbers.Count < count)
        {
            int randomNumber = random.Next(1, 11); // Generate a random number between 1 and 10

            if (!numbers.Contains(randomNumber))
            {
                numbers.Add(randomNumber);
            }
        }

        return numbers;
    }

private string GenerateUniqueWastePickerNumber()
{
    const int wastePickerNumberLength = 7;
    Random random = new Random();
    List<int> numbers = new List<int>();

    while (numbers.Count < wastePickerNumberLength)
    {
        int randomNumber = random.Next(0, 10); // Generate a random digit between 0 and 9
        if (!numbers.Contains(randomNumber))
        {
            numbers.Add(randomNumber);
        }
    }

        return string.Join("", numbers); // Concatenate the digits to form the Waste Picker Number
    }

// Method to check if a Waste Picker Number already exists in the database
        private async Task<bool> WastePickerNumberExists(int wastePickerNumber)
        {
            return await _unitOfWork.Repository<WastePicker>().Get(x => x.WastePickerNo == wastePickerNumber) != null;
        }
    }
}