using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_ASP.Models
{
    public class TaskItem
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(100, ErrorMessage = "El titulo no puede tener más de 100 caracteres")]
        public string Title { get; set; }

        [StringLength(100, ErrorMessage = "La descripcion no puede tener más de 100 caracteres")]
        public string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public int Order { get; set; } = 0;


        public byte[]? Image { get; set; }

        public string? ImageContentType { get; set; }
        [NotMapped]

        public IFormFile? ImageFile { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [BindNever]
        public string UserId { get; set; } = string.Empty;


    }
}
