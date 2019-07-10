using netCampWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netCampWeb.Models
{
    public static class GlobalData //static bellekte duracak demek sabit
    {
        public static List<Ogrenci> Ogrenciler { get; set; }

    }
}
