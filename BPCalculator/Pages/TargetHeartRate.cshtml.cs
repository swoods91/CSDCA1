using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeartRateCalculator.Pages
{
    public class MaxHeartRateModel : PageModel
    {

        [BindProperty]
        public HeartRate HR { get; set; }
        public void OnGet()
        {
            HR = new HeartRate() { ageValue = 30, PercentRate = 50 };
        }
    }
}
