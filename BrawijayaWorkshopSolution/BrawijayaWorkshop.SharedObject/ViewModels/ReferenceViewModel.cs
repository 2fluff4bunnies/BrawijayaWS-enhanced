
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class ReferenceViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public int? ParentId { get; set; }
        public ReferenceViewModel Parent { get; set; }
    }
}
