using System.ComponentModel.DataAnnotations;

namespace BlazorTraining239711.Components.Pages.modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10,ErrorMessage  ="zwischen 3 und 10 Zeichen",MinimumLength =3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(150,189,ErrorMessage ="zwischen 150 und 189 sonst kopf ab")]
        public int Gross { get; set; }
    }
}
