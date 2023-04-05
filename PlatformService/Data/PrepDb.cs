using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrePopulation(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static async void SeedData(AppDbContext appDbContext)
        {
            if (!appDbContext.platForms.Any())
            {
                Console.WriteLine("seeding-data");
                appDbContext.platForms.AddRange(
                new PlatForm()
                {
                    Name = "Dot Net",
                    Publisher = "Micro Soft",
                    Cost = "Free"
                }, new PlatForm()
                {
                    Name = "Sql Server Express",
                    Publisher = "Micro Soft",
                    Cost = "Free"
                }, new PlatForm()
                {
                    Name = "Kubernetss",
                    Publisher = "Clound Native Computing Foundation",
                    Cost = "Free"
                }
                );
                appDbContext.SaveChanges();
            }
        }
    }
}
