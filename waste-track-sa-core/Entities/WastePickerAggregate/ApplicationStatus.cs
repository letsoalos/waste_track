using System.Runtime.Serialization;

namespace waste_track_sa_core.Entities.WastePickerAggregate
{
    public enum ApplicationStatus
    {
        [EnumMember(Value = "Capturing Stage")]
        Draft,

        [EnumMember(Value = "In Progress")]
        InProgress,

        [EnumMember(Value = "Cptured Successfully")]
        Completed
    }
}