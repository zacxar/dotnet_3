using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnet_3.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace dotnet_3.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public string[] PersonList { get; set; }

        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                PersonList = Data.Split('.');
        }
    }
}
