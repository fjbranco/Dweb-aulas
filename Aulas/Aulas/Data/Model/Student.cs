using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    public class Student : MyUser
    {
        public int StudentNumber { get; set; }
        [Precision(8,2)]
        public Decimal TuitionFee { get; set; }
        public DateTime RegistrationDate { get; set; }


        [ForeignKey(nameof(Degree))]
        public int DegreeFK { get; set; }
        public Degree Degree { get; set; } = null!;


        /// <summary>
        /// Lista de Registos
        /// </summary>
        public ICollection<Registration> Registrations { get; set; } = [];

    }
}
