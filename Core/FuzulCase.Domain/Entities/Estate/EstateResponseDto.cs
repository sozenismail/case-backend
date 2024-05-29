using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Domain.Entities.Estate
{
    public class EstateResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ListingDate { get; set; }
        public int FieldM2 { get; set; }
        public string Thumbnail { get; set; }
        public float Price { get; set; }
        public int CityId { get; set; }
    }
}
