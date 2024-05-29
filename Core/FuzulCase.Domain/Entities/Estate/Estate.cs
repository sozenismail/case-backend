using FuzulCase.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Domain.Entities.Estate
{
    public class Estate : BaseEntity
    {
        public String? Title { get; set; }
        public DateTime ListingDate { get; set; }
        public int FieldM2 { get; set; }
        public float Price { get; set; }
        public string Thumbnail { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
