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
        void ClearCasesAfter();
        void InsertCasesAfter(CountrySet countrySet);
        void ClearCasesBefore();
        void InsertCasesBefore(CountrySet countrySet);
        void ClearDeathsAfter();
        void InsertDeathsAfter(CountrySet countrySet);
        void ClearDeathsBefore();
        void InsertDeathsBefore(CountrySet countrySet);
    }
}
