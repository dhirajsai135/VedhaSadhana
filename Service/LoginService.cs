namespace VedhaSadhana.Service;

public class LoginService(VedhaDbContext vedhaDbContext) : ILoginService
{
    private readonly VedhaDbContext _context = vedhaDbContext;
    public async Task<bool> LoginAsync(LoginVM loginVM)
    {
        if (_context == null)
        {
            return false;
        }
        var response = await _context.Guru.FirstAsync(x => x.Email == loginVM.Email);
        if (response == null)
        {
            return false;
        }
        return response.Password == loginVM.Password;
    }

    public async Task<bool> SignUpAsync(LoginVM loginVM)
    {
        try
        {
            if (loginVM == null) { return false; }
            Guru guru = new()
            {
                Name = loginVM.FirstName + " " + loginVM.LastName,
                Email = loginVM.Email,
                Password = loginVM.Password,
                Created = DateTime.Now,
                CreatedBy = loginVM.Email
            };
            await _context.Guru.AddAsync(guru);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
}
