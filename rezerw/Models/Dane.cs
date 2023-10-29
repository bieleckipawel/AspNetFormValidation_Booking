using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace rezerw.Models
{
    public enum Miasta
    {
        Krakow = 1,
        Warszawa = 2,
        Wroclaw = 3,
        Poznan = 4,
        Gdansk = 5
    }

    public class Dane
    {
        [Required (ErrorMessage = "Pole Imie jest wymagane")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Imię musi mieć co najmniej 3 znaki.")] 
        public string Imie { get; set; }
        [Required (ErrorMessage = "Pole Nazwisko jest wymagane")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nazwisko musi mieć co najmniej 3 znaki.")]
        public string Nazwisko { get; set; }
        [Required (ErrorMessage = "Pole Email jest wymagane")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [HiddenInput(DisplayValue = false)]
        [Required (ErrorMessage = "Pole Haslo jest wymagane")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Hasło jest zbyt słabe!")]
        public string Haslo { get; set; }
        [HiddenInput(DisplayValue = false)]
        [Required (ErrorMessage = "Musisz wprowadzić hasło dwa razy")]
        [Compare("Haslo", ErrorMessage = "Podane hasła nie są takie same")]
        public string PowtorzHaslo { get; set; }
        [RegularExpression(@"^[1-9](?:\d{8}|\d{9})$", ErrorMessage = "Niepoprawny numer telefonu")]   
        public int Telefon { get; set; }
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80 lat.")]
        public int Wiek { get; set; }
        public Miasta Miasto { get; set; }
    }
}