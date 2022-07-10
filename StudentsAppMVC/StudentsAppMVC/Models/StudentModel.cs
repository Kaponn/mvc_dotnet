using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAppMVC.Models
{
    [Table("Students")]
    public class StudentModel
    {
        [Key]
        [DisplayName("ID studenta")]
        public int StudentId { get; set; }

        [DisplayName("Imię")]
        [Required(ErrorMessage = "Musisz podać nazwisko studenta")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Długość imienia musi byc w zakresie 2 - 20 znaków")]
        public string Name { get; set; }

        [DisplayName("Nazwisko")]
        [Required(ErrorMessage = "Musisz podać nazwisko studenta")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Długość imienia musi byc w zakresie 2 - 20 znaków")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Proszę podać poprawny adres email")]
        [Required(ErrorMessage = "Pole e-mail jest obowiązkowe")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Range(6, 100, ErrorMessage = "Proszę podać wiek w zakresie 6 - 100")]
        [Required(ErrorMessage = "Musisz podać wiek")]
        public int Age { get; set; }

        [DisplayName("Aktywny")]
        public bool IsActive { get; set; }
    }
}
