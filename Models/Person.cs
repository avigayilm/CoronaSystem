using System.ComponentModel.DataAnnotations;

namespace CoronaSystem.Models
{
    public class Person
    {
        [Key]
       public int PersonId { get; set; }
        [Required]
        public string MyId { get; set; }
       
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? CellPhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FirstShot { get; set; }
        [DataType(DataType.Date)]
        public DateTime? SecondShot { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ThirdShot { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FourthShot { get; set; }
        public string? Vaccine1 { get; set; }
        public string? Vaccine2 { get; set; }
        public string? Vaccine3 { get; set; }
        public string? Vaccine4 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PositiveDate { get; set; }
        [DataType(DataType.Date)]

        public DateTime? NegativeDate { get; set; }

    }
}
