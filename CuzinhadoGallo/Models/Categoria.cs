using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuzinhadoGallo.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome")]
    [StringLength(30)]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    public bool ExibirHome { get; set; } = false;
}
