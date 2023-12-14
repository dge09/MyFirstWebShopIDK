using Microsoft.EntityFrameworkCore;
using MyFirstWebShop.Data.DTOs;
using MyFirstWebShop.Data.Entity;

namespace MyFirstWebShop.Data.Services
{
    public class GenderService : IGenderService // 9 import all methods
    {
        private ApplicationDbContext dbc; // 12 implement db context 

        public GenderService(ApplicationDbContext context) // 12 set db context
        {
                dbc = context;
        }




        public void Add(GenderDetail genderDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int GenderId)
        {
            throw new NotImplementedException();
        }

        public Task<GenderDetail?> GetGender(int GenderId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GenderSelect>> GetGenderSelect() // 15 implement first get method select all genders
        {
            var genders = from g in dbc.Genders
                          orderby g.Title
                          select new GenderSelect
                          {
                              GenderId = g.GenderId,
                              Title = g.Title
                          };

            return await genders.ToListAsync();
        }

        public void Update(Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
