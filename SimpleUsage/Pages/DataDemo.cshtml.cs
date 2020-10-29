using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleUsage.Models;

namespace SimpleUsage.Pages
{
    public class DataDemoModel : PageModel
    {

        public List<PersonModel> People { get; set; } = new List<PersonModel>();

        public void OnGet()
        {
            People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            People.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
            People.Add(new PersonModel { FirstName = "Jame", LastName = "Smith" });

        }
    }
}
