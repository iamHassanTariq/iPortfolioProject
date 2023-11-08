using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddSocialNetworksModel : PageModel
    {
        AppDbContext db;
        public SocialNetworks socialNetworks { get; set; }
        public AddSocialNetworksModel(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet(SocialNetworks socialNetworks)
        {
            db.tbl_SocialNetworks.Add(socialNetworks);
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetworks");
        }
    }
}
