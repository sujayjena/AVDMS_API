using AVDMS.Application.Models;
using AVDMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVDMS.Application.Interfaces
{
    public interface IMasterDataRepository
    {
        Task<IEnumerable<SelectListResponse>> GetReportingToEmployeeForSelectList(ReportingToEmpListParameters parameters);
        Task<IEnumerable<EmployeesListByReportingTo_Response>> GetEmployeesListByReportingTo(int EmployeeId);
    }
}
