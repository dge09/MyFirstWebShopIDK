using MyFirstWebShop.Data.DTOs;
using MyFirstWebShop.Data.Entity;

namespace MyFirstWebShop.Data.Services
{
    public interface IGenderService // 1 implement
    {
        Task<List<GenderSelect>> GetGenderSelect(); // 4 implement

        Task<GenderDetail?> GetGender(int GenderId); // 5 implement

        void Add(GenderDetail genderDetail); // 6 implement

        void Update(Gender gender); // 7 implement

        void Delete(int GenderId); // 8 implement


    }
}
