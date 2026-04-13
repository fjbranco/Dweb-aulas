using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    public class Degree
    {
        [Key]
        public int Id{ get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string Logotype { get; set; }

        // Relacionamentos 1 - N
        public ICollection<Course> ListaCourses { get; set; } = [];
        public ICollection<Student> ListaStudents { get; set; } = [];
    }
}
