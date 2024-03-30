namespace VedhaSadhana.Abstraction;

public interface ILoginService
{
    Task<bool> LoginAsync(LoginVM loginVM);
    Task<bool> SignUpAsync(LoginVM loginVM);
}
