using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace Labb1EF_ASP_core.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        [StringLength(30)]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [StringLength(30)]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public ICollection<Vacation>? Vacations { get; set; }
    }
}
