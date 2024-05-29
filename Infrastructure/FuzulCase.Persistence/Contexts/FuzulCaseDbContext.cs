using FuzulCase.Domain.Entities;
using FuzulCase.Domain.Entities.Estate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Persistence.Contexts
{
    public class FuzulCaseDbContext : DbContext
    {
        public FuzulCaseDbContext(DbContextOptions options) : base(options){}
        public DbSet<Estate> Estates { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "İstanbul" },
                new City { Id = 2, Name = "İzmir" },
                new City { Id = 3, Name = "Ankara" }
            );

            modelBuilder.Entity<Estate>().HasData(
              new Estate { Id = 1, 
                  Title= "Modern ve rahat bir daire. Şehir yaşamının tüm olanaklarına yakın olan bu daire, konforlu bir yaşam sunuyor.",
                  CityId=1,ListingDate=DateTime.Now,FieldM2=100,
                  Price=250,
                  Thumbnail= "https://pixabay.com/get/g7a73d72381e6d6d3da930b0c1998741a7101ecc8d79ddf5d0333624d6345d620ddc3595b3673f503c9d64794b1b60ef609c29a1cbecd0adbda66a6c83154cd041c2883baa8b724bfcb6254adfc8cffb7_640.jpg"
              },

              new Estate
              {
                  Id = 2,
                  Title = "Modern mimarinin örnekleri arasında öne çıkan villa. Yenilikçi tasarımı ve özel özellikleriyle bu villa, şıklık ve lüksü bir araya getiriyor.",
                  CityId = 2,
                  ListingDate = DateTime.Now,
                  FieldM2 = 120,
                  Price = 200,
                  Thumbnail = "https://pixabay.com/get/g0d92e7f8bdf85e6980977c270a15e1421ceb3ef450cee5a939ba8dbcecb4fbf5890f16077e363ecf3c00e5ca54febb0c7967c4ff055f31eb88ad9c3e73ee39558aa9f12163965ea84422a4edb3109bff_640.jpg"
              },

              new Estate
              {
                  Id = 3,
                  Title = "Şehre yakın bir tatil köyünde villa. Plajlara yakın olan bu villa, deniz ve güneşin keyfini çıkarmak isteyenlere hitap ediyor.",
                  CityId = 3,
                  ListingDate = DateTime.Now,
                  FieldM2 = 90,
                  Price = 150,
                  Thumbnail = "https://pixabay.com/get/g8dd6911882900526296d4aa50f452a8426bedb0864e589618d9a08eefa1e71e722b10cb8a48c9249617e4573ab3cd20ed29189db34011acf0a78af0d593d3866d61c5ee288e94390648642f5c265e9a7_640.jpg"
              },

              new Estate
              {
                  Id = 4,
                  Title = "Sessiz ve huzurlu dağ evi. Doğanın kucakladığı bu ev, doğal güzellikler içinde sakin bir yaşam sunuyor.",
                  CityId = 1,
                  ListingDate = DateTime.Now,
                  FieldM2 = 200,
                  Price = 450,
                  Thumbnail = "https://pixabay.com/get/g16573450479b2cf9157f4b03b6c2e1bcd6c2dbee098d005062fb74fd6b5cc1601e4e98023f944420e06a2743c95b60715223b57e8161179a8b4ed5c7d3561e87a97a59b9161113689b83bc6389775e5c_640.jpg"
              },

              new Estate
              {
                  Id = 5,
                  Title = "Sosyal tesislere sahip site içi daire. Havuz, spor alanları ve daha fazlasıyla bu site, sosyal bir yaşam sunuyor.",
                  CityId = 2,
                  ListingDate = DateTime.Now,
                  FieldM2 = 300,
                  Price = 550,
                  Thumbnail = "https://pixabay.com/get/g954410a421b64c1e1d4e3f553f6362fe4180dec5e95faf37d92a9cbb628b0b08b13e862b635737115d7a67f3601e20151d0f02c97f8bdf47f3ec5cb78ed331284faf2f257a99b7facb8a8fc00953ec34_640.jpg"
              },

              new Estate
              {
                  Id = 6,
                  Title = "Sahile yakın modern daire. Plajlara yakın olan bu daire, deniz severlere hitap ediyor.",
                  CityId = 1,
                  ListingDate = DateTime.Now,
                  FieldM2 = 220,
                  Price = 210,
                  Thumbnail = "https://pixabay.com/get/g195f346b42fdd79c54d1e6e74d8027c36d24f940076d9d0a4b9ed01a0c4c81a6ef34d8a04dc67827ae08db2542915910711cc2a72e41ecb21ec7b640a2ba31e37b8b3f22514f3b48497bb1367d091190_640.jpg"
              },

              new Estate
              {
                  Id = 7,
                  Title = "Bahçeli taş ev. Geleneksel mimariyle tasarlanan bu ev, doğal ve sıcak bir atmosfer sunuyor.",
                  CityId = 3,
                  ListingDate = DateTime.Now,
                  FieldM2 = 120,
                  Price = 150,
                  Thumbnail = "https://pixabay.com/get/g022ffdbdd0238b95062df3c4f630e5e0e96eff610545c79db2ce54127031e93368ed73bcf8792d601208aee67eb69168c836edb1a127dd6ad1c44110cf771e4091d1abb285f39813c8bf0d9c9734b981_640.jpg"
              }

          );
        }


    }
}
