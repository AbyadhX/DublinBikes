using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DublinBikes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBikes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DublinBikesContext(serviceProvider.GetRequiredService<DbContextOptions<DublinBikesContext>>()))
            {
                // Look for any station.
                if (context.DublinBike.Any())
                {
                    return;   // DB has been seeded
                }
                    context.DublinBike.AddRange(
                        new DublinBike
                        {
                            Number = 42,
                            Name = "SMITHFIELD NORTH",
                            Address = "Smithfield North",
                            Latitude = 53.349562f,
                            Longitude = -6.278198f,
                            Banking = true,
                            Status = "OPEN",
                            Available_bikes = 15,
                            Available_stands = 25,
                            Capacity = 40
                        },

                        new DublinBike
                        {
                            Number = 30,
                            Name = "PARNELL SQUARE NORTH",
                            Address = "Parnell Square North",
                            Latitude = 53.353462f,
                            Longitude = -6.265305f,
                            Banking = true,
                            Status = "OPEN",
                            Available_bikes = 15,
                            Available_stands = 25,
                            Capacity = 40
                        },

                        new DublinBike
                        {
                            Number = 54,
                            Name = "CLONMEL STREET",
                            Address = "Clonmel Street",
                            Latitude = 53.98696f,
                            Longitude = -6.275879f,
                            Banking = true,
                            Status = "OPEN",
                            Available_bikes = 15,
                            Available_stands = 25,
                            Capacity = 40
                        },

                        new DublinBike
                        {
                            Number = 108,
                            Name = "AVONDALE ROAD",
                            Address = "Avondale Road",
                            Latitude = 53.359405f,
                            Longitude = -6.276142f,
                            Banking = true,
                            Status = "OPEN",
                            Available_bikes = 40,
                            Available_stands = 10,
                            Capacity = 50
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}