using Server_app.Entities;

namespace Server_app.Services.DB_data
{
    public interface IExamRepository
    {
        IList<ExamResult> GetAllExamResultsAfter();
        IList<ExamResult> GetAllExamResultsBefore();
        IList<AverageExamData> GetAverageExamPerYearAfter();
        IList<AverageExamData> GetAverageExamPerYearBefore();
        void ClearExamsAfter();
        void InsertExamsAfter(ExamResult examResult);
        void ClearExamsBefore();
        void InsertExamsBefore(ExamResult examResult);
    }
}
