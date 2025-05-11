using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseProject.Models
{
    public class Facilitis
    {
        public int FacilityId { get; set; }

        public string Parking { get; set; }

        public string FreshWater { get; set; }

        public string OutdoorSpace { get; set; }

        public string StoreRoom { get; set; }

        public string SecurityGuard { get; set; }

        public string InternetService { get; set; }

        public int PropertyId { get; set; }

    }
}