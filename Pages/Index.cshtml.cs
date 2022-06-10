using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using dotnet_3.Models;

namespace dotnet_3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Person Person { get; set; }
        public PersonList PersonList { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            if (PersonList == null)
                PersonList = new PersonList();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Person.isLeap();
                PersonList.Add(Person);
                HttpContext.Session.SetString("Data", HttpContext.Session.GetString("Data") + Person.ToString() + ".");
                return RedirectToPage("./SavedInSession");
            }
            return Page();
        }
    }
}