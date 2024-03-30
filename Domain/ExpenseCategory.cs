namespace VedhaSadhana.Domain;

public class ExpenseCategory : Audit
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
