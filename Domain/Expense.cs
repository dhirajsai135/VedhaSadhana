namespace VedhaSadhana.Domain;

public class Expense : Audit
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Guru))]
    public int GuruID { get; set; } // Foreign key
    public Guru Guru { get; set; }

    public string Description { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public int ExpenseCategoryId { get; set; }
    public ExpenseCategory Category { get; set; }

}
