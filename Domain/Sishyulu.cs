namespace VedhaSadhana.Domain;

public class Sishyulu : Audit
{
    [Key]
    public Guid Id { get; set; } // Guid

    [ForeignKey(nameof(Guru))]
    public int GuruID { get; set; } // Foreign key
    public Guru Guru { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    // Navigation property for Guru

}
