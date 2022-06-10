using System.ComponentModel.DataAnnotations;

namespace dotnet_3.Models
{
    public class Person
    {
        [Display(Name = "Imię")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Proszę wypełnić to pole")]
        public string Name { get; set; }

        [Display(Name = "Rok")]
        [MinLength(1)]
        [Required(ErrorMessage = "Proszę wypełnić to pole")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość z zakresu {1} i {2}.")]
        public int Year { get; set; }

        [Display(Name = "Rok przestępny")]
        public bool LeapYear { get; set; }

        public string? Result { get; set; }

        public void isLeap()
        {
            if (DateTime.IsLeapYear(Year))
            {
                LeapYear = true;
                Result = "rok przestępny";
            }
            else
            {
                LeapYear = false;
                Result = "rok nie był przestępny";
            }
        }

        override public string ToString()
        {
            return Name + ", " + Year + " - " + Result;
        }
    }
}
