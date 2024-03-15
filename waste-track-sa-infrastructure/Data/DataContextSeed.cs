using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data
{
    public class DataContextSeed
    {
        public static async Task SeedAsync(DataContext context)
        {
            if (!context.Gender.Any())
            {
                var genderData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/gender.json");
                var gender = JsonSerializer.Deserialize<List<Gender>>(genderData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Gender.AddRange(gender);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            if (!context.Worksites.Any())
            {
                var worksitesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/worksites.json");
                var worksites = JsonSerializer.Deserialize<List<Worksite>>(worksitesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Worksites.AddRange(worksites);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            if (!context.WastePickerStatuses.Any())
            {
                var wastePickerStatusesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/wastePickerStatuses.json");
                var wastePickerStatuses = JsonSerializer.Deserialize<List<WastePickerStatus>>(wastePickerStatusesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.WastePickerStatuses.AddRange(wastePickerStatuses);
#pragma warning restore CS8604 // Possible null reference argument. 
            }

            if (!context.IncomeMethods.Any())
            {
                var incomeMethodsData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/incomeMethods.json");
                var incomeMethods = JsonSerializer.Deserialize<List<IncomeMethod>>(incomeMethodsData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.IncomeMethods.AddRange(incomeMethods);
#pragma warning restore CS8604 // Possible null reference argument. incomeMethods.json
            }

            if (!context.UserTypes.Any())
            {
                var userTypesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/userTypes.json");
                var userTypes = JsonSerializer.Deserialize<List<UserType>>(userTypesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.UserTypes.AddRange(userTypes);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            if (!context.SortingAreas.Any())
            {
                var sortingAreasData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/sortingAreas.json");
                var sortingAreas = JsonSerializer.Deserialize<List<SortingArea>>(sortingAreasData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.SortingAreas.AddRange(sortingAreas);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            if (!context.Race.Any())
            {
                var raceData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/race.json");
                var race = JsonSerializer.Deserialize<List<Race>>(raceData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Race.AddRange(race);
#pragma warning restore CS8604 // Possible null reference argument. 
            }

            if (!context.OfficialTypes.Any())
            {
                var oficialTypesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/oficialTypes.json");
                var oficialTypes = JsonSerializer.Deserialize<List<OfficialType>>(oficialTypesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.OfficialTypes.AddRange(oficialTypes);
#pragma warning restore CS8604 // Possible null reference argument. oficialTypes.json
            }

            if (!context.Provinces.Any())
            {
                var provincesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/provinces.json");
                var provinces = JsonSerializer.Deserialize<List<Province>>(provincesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Provinces.AddRange(provinces);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            if (!context.OrganizationTypes.Any())
            {
                var organizationTypesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/organizationTypes.json");
                var organizationTypes = JsonSerializer.Deserialize<List<OrganizationType>>(organizationTypesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.OrganizationTypes.AddRange(organizationTypes);
#pragma warning restore CS8604 // Possible null reference argument. oficialTypes.json
            }

            if (!context.MasterCodes.Any())
            {
                var masterCodesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/masterCodes.json");
                var masterCodes = JsonSerializer.Deserialize<List<MasterCode>>(masterCodesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.MasterCodes.AddRange(masterCodes);
#pragma warning restore CS8604 // Possible null reference argument. 
            }

            if (!context.DocumentTypes.Any())
            {
                var documentTypesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/documentTypes.json");
                var documentTypes = JsonSerializer.Deserialize<List<DocumentType>>(documentTypesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.DocumentTypes.AddRange(documentTypes);
#pragma warning restore CS8604 // Possible null reference argument. 
            }

            if (!context.Districts.Any())
            {
                var districtsData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/districts.json");
                var districts = JsonSerializer.Deserialize<List<District>>(districtsData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Districts.AddRange(districts);
#pragma warning restore CS8604 // Possible null reference argument. 
            }

            if (!context.Municipalities.Any())
            {
                var municipalitiesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/municipalities.json");
                var municipalities = JsonSerializer.Deserialize<List<Municipality>>(municipalitiesData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Municipalities.AddRange(municipalities);
#pragma warning restore CS8604 // Possible null reference argument.  cooperative.json
            }

            if (!context.Cooperatives.Any())
            {
                var cooperativeData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/cooperative.json");
                var cooperatives = JsonSerializer.Deserialize<List<Cooperative>>(cooperativeData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Cooperatives.AddRange(cooperatives);
#pragma warning restore CS8604 // Possible null reference argument.  cooperative.json
            }

            if (!context.Organizations.Any())
            {
                var organizationsData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/organizations.json");
                var organizations = JsonSerializer.Deserialize<List<Organization>>(organizationsData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.Organizations.AddRange(organizations);
#pragma warning restore CS8604 // Possible null reference argument. 
            }

            if (!context.WastePickers.Any())
            {
                var wastePickersData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/wastePickers.json");
                var wastePickers = JsonSerializer.Deserialize<List<WastePicker>>(wastePickersData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.WastePickers.AddRange(wastePickers);
#pragma warning restore CS8604 // Possible null reference argument. wastePickers.json
            }

            if (!context.CooperativeInfo.Any())
            {
                var CooInfoData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/cooperativeInfo.json");
                var CoopInfo = JsonSerializer.Deserialize<List<CooperativeInfo>>(CooInfoData);
#pragma warning disable CS8604 // Possible null reference argument.
                context.CooperativeInfo.AddRange(CoopInfo);
#pragma warning restore CS8604 // Possible null reference argument. wastePickers.json
            }


            //if (!context.ReclaimingInfo.Any())
           // {
           //     var oficialTypesData = File.ReadAllText("../waste-track-sa-infrastructure/Data/SeedData/oficialTypes.json");
            //    var oficialTypes = JsonSerializer.Deserialize<List<ReclaimingInfo>>(oficialTypesData);
//#pragma warning disable CS8604 // Possible null reference argument.
             //   context.ReclaimingInfo.AddRange(oficialTypes);
//#pragma warning restore CS8604 // Possible null reference argument. oficialTypes.json
            //}


            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }

        private static T DeserializeJson<T>(string jsonData)
        {           
            var options = new JsonSerializerOptions
            {               
                Converters = { new DateTimeConverter() }, // Add the DateTimeConverter               
                PropertyNameCaseInsensitive = true, // Adjust this based on your needs
                // Additional options if necessary...
            };

#pragma warning disable CS8603 // Possible null reference return.
            return JsonSerializer.Deserialize<T>(jsonData, options);
#pragma warning restore CS8603 // Possible null reference return.
        }


        public class DateTimeConverter : JsonConverter<DateTime>
        {
            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string dateStr = reader.GetString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                if (DateTime.TryParseExact(dateStr, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind,out DateTime result))
                {
                   
                    return result;
                }


                // Handle parsing failure
               
                throw new JsonException($"Unable to parse date string: {dateStr}");
            }

           public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
            {
               
                writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            }
        }
        
    }
}