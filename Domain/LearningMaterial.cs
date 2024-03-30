namespace VedhaSadhana.Domain;

public class LearningMaterial : Audit
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string FilePath { get; set; }
    [ForeignKey(nameof(Guru))]
    public int GuruID { get; set; } // Foreign key
    public Guru Guru { get; set; }
    public DateTime DateUploaded { get; set; }
    public MaterialType MaterialType { get; set; }
    public Subject Subject { get; set; }
    public SubjectType SubjectType { get; set; }
}

