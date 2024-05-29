using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Domain.Entities.Estate
{
    public class EstateFilterDto
    {
        public float? MaxPrice { get; set; }
        public float? MinPrice { get; set; }
        public float? MinM2 { get; set; }
        public float? MaxM2 { get; set; }
        public int? CityId { get; set; }


    }
}
