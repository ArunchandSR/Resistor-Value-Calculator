using MyOrg.CircuitColorCoder.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyOrg.ResistorColorCoder.Models
{
    public class ColorCode
    {
        [Display(Name = "BandA")]
        public BandA bandA { get; set; }

        [Display(Name = "BandB")]
        public BandB bandB { get; set; }

        [Display(Name = "BandC")]
        public BandC bandC { get; set; }

        [Display(Name = "BandD")]
        public BandD bandD { get; set; }
    }
}