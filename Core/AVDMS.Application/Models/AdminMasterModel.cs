using AVDMS.Domain.Entities;
using AVDMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AVDMS.Application.Models
{
    #region Blood Group
    public class BloodGroup_Search : BaseSearchEntity
    {
    }

    public class BloodGroup_Request : BaseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BloodGroup_Response : BaseResponseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Company Type

    public class CompanyType_Search : BaseSearchEntity
    {
    }

    public class CompanyType_Request : BaseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CompanyType_Response : BaseResponseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Gender
    public class Gender_Search : BaseSearchEntity
    {
    }

    public class Gender_Request : BaseEntity
    {
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Gender_Response : BaseResponseEntity
    {
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region MaritalStatus
    public class MaritalStatus_Search : BaseSearchEntity
    {
    }

    public class MaritalStatus_Request : BaseEntity
    {
        public string? MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaritalStatus_Response : BaseResponseEntity
    {
        public string? MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Frequency
    public class Frequency_Search : BaseSearchEntity
    {
    }

    public class Frequency_Request : BaseEntity
    {
        public string? Frequency { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Frequency_Response : BaseResponseEntity
    {
        public string? Frequency { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion
}
