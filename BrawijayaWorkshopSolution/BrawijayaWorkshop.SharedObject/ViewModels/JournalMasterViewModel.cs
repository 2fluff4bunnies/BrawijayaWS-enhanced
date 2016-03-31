
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class JournalMasterViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public JournalMasterViewModel Parent { get; set; }
    }
}
