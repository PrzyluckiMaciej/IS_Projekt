using Project_app.ORM_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_app.ORM_interfaces
{
    public interface IExamRepository
    {
        IList<ExamResult> GetAllExamResultsAfter();
        IList<ExamResult> GetAllExamResultsBefore();
    }
}
