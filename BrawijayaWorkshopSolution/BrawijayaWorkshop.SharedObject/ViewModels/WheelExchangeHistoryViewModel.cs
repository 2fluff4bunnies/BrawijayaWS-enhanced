
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class WheelExchangeHistoryViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SPKId { get; set; }
        public virtual SPKViewModel SPK { get; set; }
        public int OriginalWheelId { get; set; }
        public virtual SpecialSparepartDetailViewModel OrignialWheel { get; set; }
        public int ReplaceWheelId { get; set; }
        public virtual SpecialSparepartDetailViewModel ReplaceWheel { get; set; }
    }
}
