namespace VedhaSadhana.Domain;
public class Guru : Audit
{
    [Key]
    public int Id { get; set; } // Identity column

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public ICollection<Sishyulu> Sishyulu { get; set; }
}
