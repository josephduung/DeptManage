using Microsoft.AspNetCore.Antiforgery;
using DeptManage.Controllers;

namespace DeptManage.Web.Host.Controllers
{
    public class AntiForgeryController : DeptManageControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
