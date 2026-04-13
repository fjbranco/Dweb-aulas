using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; } = null!;
        public int CurricularYear { get; set; }
        public int Semester { get; set; }

        // Relacionamentos 1 - N
        [ForeignKey(nameof(Degree))]
        public int DegreeFK { get; set; }
        public Degree Degree { get; set; } = null!;

        // Relacionamentos N - M
        /// <summary>
        /// Lista de professores
        /// </summary>
        public ICollection<Professor> ListaProfessores { get; set; } = [];


        /// <summary>
        /// Lista de Registos
        /// </summary>
        public ICollection<Registration> ListaRegistrations { get; set; } = [];

    }
}
