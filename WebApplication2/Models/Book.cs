using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Название книги обязательно")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Картинка обязательна")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Имя автора обязательно")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Издательство обязательно")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Год издания обязателен")]
        [Range(1000, 9999, ErrorMessage = "Год издания должен быть в диапазоне от 1000 до 9999")]
        public int PublicationYear { get; set; }

        [Required(ErrorMessage = "ISBN обязателен")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "ISBN должен быть длиной от 10 до 13 символов")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Жанр обязателен")]
        public string Genre { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Цена обязательна")]
        [Range(0.01, 1000000, ErrorMessage = "Цена должна быть в диапазоне от 0.01 до 1 000 000")]
        public decimal Price { get; set; }

        [Range(1, 10000, ErrorMessage = "Количество должно быть в диапазоне от 1 до 1 000")]
        public int Count { get; set; }
    }
}
