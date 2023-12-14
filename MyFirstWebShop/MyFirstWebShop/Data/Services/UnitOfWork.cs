namespace MyFirstWebShop.Data.Services
{
    public class UnitOfWork // 10 implement
    {
        public readonly ApplicationDbContext dbc; // 11 define Class intern db context

        private GenderService _genderService = null; // 14 implement


        public UnitOfWork(ApplicationDbContext context) // 11 get db context 
        {
                dbc = context;
        }


        public GenderService GenderService => _genderService ??= new GenderService(dbc); // 14 implement

        private async Task<int> Commit() // 13 implement to save multiple changes via uoW
        {
            return await dbc.SaveChangesAsync();
        }
    }
}
