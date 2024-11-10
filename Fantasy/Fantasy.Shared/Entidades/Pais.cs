using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entidades;

public class Pais
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string nombre { get; set; } = null!;
}