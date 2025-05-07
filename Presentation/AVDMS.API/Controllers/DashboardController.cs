using AVDMS.Application.Enums;
using AVDMS.Application.Helpers;
using AVDMS.Application.Interfaces;
using AVDMS.Application.Models;
using AVDMS.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVDMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : CustomBaseController
    {
        private ResponseModel _response;
        private IFileManager _fileManager;

        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IFileManager fileManager, IDashboardRepository dashboardRepository)
        {
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
            _dashboardRepository = dashboardRepository;
        }
    }
}
