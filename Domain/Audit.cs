namespace VedhaSadhana.Domain;

public class Audit
{
    public string Created { get; set; }
    public DateTime? CreatedBy { get; set; }
    public string Modified { get; set; }
    public DateTime? ModifiedBy { get; set; }
}
