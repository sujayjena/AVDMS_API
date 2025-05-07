using AVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVDMS.Application.Models
{
    public class TerritoryModel
    {
    }

    #region Region

    public class Region_Request : BaseEntity
    {
        public string? RegionName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Region_Response : BaseResponseEntity
    {
        public string? RegionName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class RegionDataValidationErrors
    {
        public string RegionName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedRegion
    {
        public string RegionName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion

    #region State

    public class State_Request : BaseEntity
    {
        public string? StateName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class State_Response : BaseResponseEntity
    {
        public string? StateName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class StateDataValidationErrors
    {
        public string StateName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedState
    {
        public string StateName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion

    #region City

    public class City_Request : BaseEntity
    {
        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class City_Response : BaseResponseEntity
    {
        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class CityDataValidationErrors
    {
        public string CityName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedCity
    {
        public string CityName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion

    #region Territories

    public class Territories_Request : BaseEntity
    {
        public int? RegionId { get; set; }

        public int? StateId { get; set; }

        public int? CityId { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Territories_Response : BaseResponseEntity
    {
        public int? RegionId { get; set; }

        public string? RegionName { get; set; }

        public int? StateId { get; set; }

        public string? StateName { get; set; }

        public int? CityId { get; set; }

        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Territories_Region_State_City_Search
    {
        public int? RegionId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
    }

    public class Territories_Region_State_City_Response
    {
        public int? Id { get; set; }

        public string? Value { get; set; }

        public string? Text { get; set; }
    }

    public class TerritoriesDataValidationErrors
    {
        public string RegionName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedTerritories
    {
        public string RegionName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion
}
