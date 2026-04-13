using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model
{
    public class MyUser
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(17)]
        public string CellPhone { get; set; } = null!;
        [StringLength(50)]
        public string UserID { get; set; }

    }
}
