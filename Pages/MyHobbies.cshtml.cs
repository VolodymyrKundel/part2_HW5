using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace part2_HW5.Pages
{
    public class MyHobbiesModel : PageModel
    {
        public List<Hobby> ListOfHobbies = new List<Hobby> {
            new Hobby {Name = "Board Gaming", Status = "Active" },
            new Hobby {Name = "Photo", Status = "Semi-Active" },
            new Hobby {Name = "Sky-Diving", Status = "Inactive"}
        };
        public void OnGet()
        {
        }
    }

    public class Hobby
    {
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
