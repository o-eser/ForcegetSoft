using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Concrete;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ForcegetSoft.DataAccess.Seeds
{
    public static class SeedData
    {
        public static async Task SeedAsync(IApplicationBuilder app)
        {

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var service = scope.ServiceProvider;
                var context = service.GetRequiredService<AppDbContext>();


                await context.Database.MigrateAsync();

                if (!context.Modes.Any())
                {
                    List<Mode> modes = new List<Mode>()
                    {
                        new Mode { Name = "LCL" },
                        new Mode { Name = "FCL" },
                        new Mode { Name = "Air" }
                    };

                    context.Modes.AddRange(modes);

                    await context.SaveChangesAsync();
                }

                if (!context.MovementTypes.Any())
                {
                    List<MovementType> movementTypes = new List<MovementType>()
                    {
                        new MovementType { Name = "Door to Door" },
                        new MovementType { Name = "Port to Door" },
                        new MovementType { Name = "Port to Port" }
                    };

                    context.MovementTypes.AddRange(movementTypes);

                    await context.SaveChangesAsync();
                }
                if (!context.Incoterms.Any())
                {
                    List<Incoterm> incoTerms = new List<Incoterm>()
                    {
                        new Incoterm { Name = "Delivered Duty Paid (DDP)" },
                        new Incoterm { Name = "Delivered At Place (DAT)" }
                    };

                    context.Incoterms.AddRange(incoTerms);

                    await context.SaveChangesAsync();
                }

                if (!context.Unit1s.Any())
                {
                    List<Unit1> unit1s = new List<Unit1>()
                    {
                        new Unit1 { Name = "IN" },
                        new Unit1 { Name = "CM" }
                    };

                    context.Unit1s.AddRange(unit1s);

                    await context.SaveChangesAsync();
                }
                if (!context.Unit2s.Any())
                {
                    List<Unit2> unit2s = new List<Unit2>()
                    {
                        new Unit2 { Name = "LB" },
                        new Unit2 {Name = "KG"}
                    };

                    context.Unit2s.AddRange(unit2s);

                    await context.SaveChangesAsync();
                }
                if (!context.Countries.Any())
                {

                    List<Country> countries = new List<Country>()
               {
                        new Country { Name = "Turkey" },
                        new Country { Name = "USA" },
                        new Country { Name = "China" }
                    };

                    context.Countries.AddRange(countries);

                    await context.SaveChangesAsync();

                }
                if (!context.PackageTypes.Any())
                {
                    List<PackageType> packageTypes = new List<PackageType>()
                {
                        new PackageType { Name = "Boxes" },
                        new PackageType { Name = "Pallets" },
                        new PackageType { Name = "Cartons" }
                    };

                    context.PackageTypes.AddRange(packageTypes);

                    await context.SaveChangesAsync();
                }
                if (!context.Cities.Any())
                {
                    List<City> citys = new List<City>()
                {
                        new City { Name = "Istanbul", CountryId = context.Countries.FirstOrDefault(x => x.Name == "Turkey").Id },
                        new City { Name = "Izmir", CountryId = context.Countries.FirstOrDefault(x => x.Name == "Turkey").Id },
                        new City { Name = "New York", CountryId = context.Countries.FirstOrDefault(x => x.Name == "USA").Id },
                        new City { Name = "Los Angeles", CountryId = context.Countries.FirstOrDefault(x => x.Name == "USA").Id },
                        new City { Name = "Miami", CountryId = context.Countries.FirstOrDefault(x => x.Name == "USA").Id },
                        new City { Name = "Minnesota", CountryId = context.Countries.FirstOrDefault(x => x.Name == "USA").Id },
                        new City { Name = "Shanghai", CountryId = context.Countries.FirstOrDefault(x => x.Name == "China").Id },
                        new City { Name = "Beijing", CountryId = context.Countries.FirstOrDefault(x => x.Name == "China").Id }
                    };
                    context.Cities.AddRange(citys);

                    await context.SaveChangesAsync();
                }
                if (!context.Offers.Any())
                {
                    List<Mode> modes = new List<Mode>();
                    modes = await context.Modes.ToListAsync();

                    List<MovementType> movementTypes = new List<MovementType>();
                    movementTypes = await context.MovementTypes.ToListAsync();

                    List<Incoterm> incoterms = new List<Incoterm>();
                    incoterms = await context.Incoterms.ToListAsync();

                    List<Unit1> unit1 = new List<Unit1>();
                    unit1 = await context.Unit1s.ToListAsync();

                    List<Unit2> unit2 = new List<Unit2>();
                    unit2 = await context.Unit2s.ToListAsync();

                    List<PackageType> packageTypes = new List<PackageType>();
                    packageTypes = await context.PackageTypes.ToListAsync();


                    List<City> cities = new List<City>();
                    cities = await context.Cities.ToListAsync();



                    List<Offer> offers = new List<Offer>()
                    {
                        new Offer { Mode = modes.FirstOrDefault(x => x.Name == "Air"), MovementType = movementTypes.FirstOrDefault(x => x.Name == "Port to Port"), Incoterm = incoterms.FirstOrDefault(x => x.Name == "Delivered Duty Paid (DDP)"), PackageType =packageTypes.FirstOrDefault(x=>x.Name=="Cartons"),Unit1 = unit1.FirstOrDefault(x=>x.Name == "IN"),Unit2 = unit2.FirstOrDefault (x=>x.Name == "LB" ), Currency = Currency.USD,Unit1Quantity=10,Unit2Quantity=10,City=cities.FirstOrDefault(x=>x.Name=="New York")},

                        new Offer { Mode = modes.FirstOrDefault(x => x.Name == "LCL"), MovementType = movementTypes.FirstOrDefault(x => x.Name == "Door to Door"), Incoterm = incoterms.FirstOrDefault(x => x.Name == "Delivered At Place (DAT)"),PackageType =packageTypes.FirstOrDefault(x=>x.Name=="Boxes"),Unit1 = unit1.FirstOrDefault(x=>x.Name == "CM"),Unit2 = unit2.FirstOrDefault (x=>x.Name == "KG" ), Currency = Currency.TRY,Unit1Quantity=5,Unit2Quantity=5,City=cities.FirstOrDefault(x=>x.Name=="Istanbul")}
                    };

                    context.Offers.AddRange(offers);

                    await context.SaveChangesAsync();
                }

                await Task.CompletedTask;
            }
        }


    }
    
}
