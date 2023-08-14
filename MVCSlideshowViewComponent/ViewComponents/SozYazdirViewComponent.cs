using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCSlideshowViewComponent.Data;

namespace MVCSlideshowViewComponent.ViewComponents
{
    public class SozYazdirViewComponent :ViewComponent
    {
        private readonly UygulamaDbContext _db;

        public SozYazdirViewComponent(UygulamaDbContext context)
        {
            _db = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<BilgeSoz> soz = await _db.BilgeSozler.ToListAsync();
            return View(soz);
        }
    }
}
