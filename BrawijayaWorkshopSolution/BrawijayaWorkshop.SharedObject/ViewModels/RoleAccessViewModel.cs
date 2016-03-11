
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class RoleAccessViewModel
    {
        public int Id { get; set; }

        public int RoleId { get; set; }
        public RoleViewModel Role { get; set; }

        public int ApplicationModulId { get; set; }
        public virtual ApplicationModulViewModel ApplicationModul { get; set; }

        public int AccessCode { get; set; }

        public bool Read { get; set; }
        public bool Create { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
