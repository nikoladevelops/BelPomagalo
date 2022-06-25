using BelPomagalo.Views;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BelPomagalo.Controllers
{
    internal class HomeFormController : Controller<HomeForm>
    {
        public HomeFormController(HomeForm form) : base(form)
        {
            var uri = "https://www.google.com";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;

            _form.CreditsLabel.Click += (x, y) => OpenBrowser("https://github.com/nikoladevelops/BelPomagalo");
        }

        public void OpenBrowser(string url)
        {
            var ps = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}
