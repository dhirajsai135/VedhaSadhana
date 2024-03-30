namespace VedhaSadhana.Controllers;

public class LoginController(ILoginService loginService) : Controller
{
    private readonly ILoginService _loginService = loginService;
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> LoginAsync([FromBody] LoginVM loginVM)
    {
        try
        {
            return Json(await _loginService.LoginAsync(loginVM));
        }
        catch (Exception)
        {
            return Json(false);
        }
    }

    public async Task<IActionResult> Signup([FromBody] LoginVM loginVM)
    {
        try
        {
            return Json(await _loginService.SignUpAsync(loginVM));
        }
        catch (Exception)
        {
            return Json(false);
        }

    }
}
