using infinity_talent.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace infinity_talent.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuider)
        {
            using (var servicesScope = applicationBuider.ApplicationServices.CreateScope())
            {
                var contex = servicesScope.ServiceProvider.GetService<AppDbContext>();

                if (!contex.Candidates.Any())
                {
                    contex.Candidates.AddRange(new Candidate
                    {
                         Name = "Firmino de Jesus",
                         EmailMain = "fjesus@teste.com.br",
                         Password = "123456",
                         Created = DateTime.Now
                    },
                    new Candidate
                    {
                        Name = "José Fernandes",
                        EmailMain = "jfernandes@teste.com.br",
                        Password = "123456",
                        Created = DateTime.Now
                    },
                    new Candidate
                    {
                        Name = "Donald Trump",
                        EmailMain = "dtrump@teste.com.br",
                        Password = "123456",
                        Created = DateTime.Now
                    });

                    contex.SaveChanges();
                }
            }
        }
    }
}
                        