using System.ComponentModel.DataAnnotations;

public class Binnacle
{
    public int Id { get; set; }
    
    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
    [StringLength(30, MinimumLength = 25)]
    public string Title { get; set; }

    [Display(Name = "Release Date")] // Nombre que se mostrara en el label
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    
    /* Valores de tipo (decimal, int, float, DateTime) son por herencia requeridos, no requieren del atributo [Required]*/
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
