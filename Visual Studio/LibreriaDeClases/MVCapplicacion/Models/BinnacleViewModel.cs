using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCapplicacion.Models
{
    public class BinnacleViewModel
    {
        public List<string> BinnaclesTypes;
        public List<Binnacle> Binnacles;
        public SelectList BinnaclesIds;
    }
}
