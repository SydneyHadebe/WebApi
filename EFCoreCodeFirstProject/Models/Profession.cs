using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstProject.Models
{
    public class Profession 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfessionId { get; set; }

        public string Title { get; set; }

        public string Speciality { get; set; }
        
        [ForeignKey("Employee")]
        public long EmployeeId { get; set; }
    }
}
