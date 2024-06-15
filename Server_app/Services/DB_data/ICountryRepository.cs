using Server_app.Entities;

namespace Server_app.Services.DB_data
{
    public interface ICountryRepository
    {
        IList<CountrySet> GetAllCasesAfter();
        IList<CountrySet> GetAllCasesBefore();
        IList<CountrySet> GetAllDeathsAfter();
        IList<CountrySet> GetAllDeathsBefore();
        IList<AverageCountryData> GetAverageCasesAfter();
        IList<AverageCountryData> GetAverageCasesBefore();
        IList<AverageCountryData> GetAverageDeathsAfter();
        IList<AverageCountryData> GetAverageDeathsBefore();
    }
}
