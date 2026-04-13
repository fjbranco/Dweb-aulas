using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    public class Professor : MyUser
    {
        // Relacionamentos N - M
        /// <summary>
        /// Lista de Cursos
        /// </summary>
        public ICollection<Course> ListaCourses { get; set; } = [];
    }
}
