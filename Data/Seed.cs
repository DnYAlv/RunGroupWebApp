using Microsoft.AspNetCore.Identity;
using RunGroupWebApp.Data.Enum;
using RunGroupWebApp.Data;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Clubs.Any())
                {
                    context.Clubs.AddRange(new List<Club>()
                    {
                        new Club()
                        {
                            Title = "Running Club 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first cinema",
                            ClubCategory = ClubCategory.City,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                         },
                        new Club()
                        {
                            Title = "Running Club 2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first cinema",
                            ClubCategory = ClubCategory.Endurance,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new Club()
                        {
                            Title = "Running Club 3",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            ClubCategory = ClubCategory.Trail,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new Club()
                        {
                            Title = "Running Club 3",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            ClubCategory = ClubCategory.City,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Michigan",
                                State = "NC"
                            }
                        }
                    });
                    context.SaveChanges();
                }
                //Races
                if (!context.Races.Any())
                {
                    context.Races.AddRange(new List<Race>()
                    {
                        new Race()
                        {
                            Title = "Running Race 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first race",
                            RaceCategory = RaceCategory.Marathon,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new Race()
                        {
                            Title = "Running Race 2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first race",
                            RaceCategory = RaceCategory.Ultra,
                            AddressId = 5,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async task seedusersandrolesasync(iapplicationbuilder applicationbuilder)
        //{
        //    using (var servicescope = applicationbuilder.applicationservices.createscope())
        //    {
        //        //roles
        //        var rolemanager = servicescope.serviceprovider.getrequiredservice<rolemanager<identityrole>>();

        //        if (!await rolemanager.roleexistsasync(userroles.admin))
        //            await rolemanager.createasync(new identityrole(userroles.admin));
        //        if (!await rolemanager.roleexistsasync(userroles.user))
        //            await rolemanager.createasync(new identityrole(userroles.user));

        //        //users
        //        var usermanager = servicescope.serviceprovider.getrequiredservice<usermanager<appuser>>();
        //        string adminuseremail = "teddysmithdeveloper@gmail.com";

        //        var adminuser = await usermanager.findbyemailasync(adminuseremail);
        //        if (adminuser == null)
        //        {
        //            var newadminuser = new appuser()
        //            {
        //                username = "teddysmithdev",
        //                email = adminuseremail,
        //                emailconfirmed = true,
        //                address = new address()
        //                {
        //                    street = "123 main st",
        //                    city = "charlotte",
        //                    state = "nc"
        //                }
        //            };
        //            await usermanager.createasync(newadminuser, "coding@1234?");
        //            await usermanager.addtoroleasync(newadminuser, userroles.admin);
        //        }

        //        string appuseremail = "user@etickets.com";

        //        var appuser = await usermanager.findbyemailasync(appuseremail);
        //        if (appuser == null)
        //        {
        //            var newappuser = new appuser()
        //            {
        //                username = "app-user",
        //                email = appuseremail,
        //                emailconfirmed = true,
        //                address = new address()
        //                {
        //                    street = "123 main st",
        //                    city = "charlotte",
        //                    state = "nc"
        //                }
        //            };
        //            await usermanager.createasync(newappuser, "coding@1234?");
        //            await usermanager.addtoroleasync(newappuser, userroles.user);
        //        }
        //    }
        //}
    }
}