using AVDMS.Application.Helpers;
using AVDMS.Application.Interfaces;
using AVDMS.Application.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVDMS.Persistence.Repositories
{
    public class TerritoryRepository : GenericRepository, ITerritoryRepository
    {
        private IConfiguration _configuration;

        public TerritoryRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        #region Region

        public async Task<int> SaveRegion(Region_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@RegionName", parameters.RegionName.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveRegion", queryParameters);
        }

        public async Task<IEnumerable<Region_Response>> GetRegionList(BaseSearchEntity parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<Region_Response>("GetRegionList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<Region_Response?> GetRegionById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<Region_Response>("GetRegionById", queryParameters)).FirstOrDefault();
        }

        public async Task<IEnumerable<RegionDataValidationErrors>> ImportRegion(List<ImportedRegion> parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            string xmlData = ConvertListToXml(parameters);
            queryParameters.Add("@XmlData", xmlData);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);
            return await ListByStoredProcedure<RegionDataValidationErrors>("ImportRegion", queryParameters);
        }

        #endregion

        #region State

        public async Task<int> SaveState(State_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@StateName", parameters.StateName.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveState", queryParameters);
        }

        public async Task<IEnumerable<State_Response>> GetStateList(BaseSearchEntity parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<State_Response>("GetStateList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<State_Response?> GetStateById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<State_Response>("GetStateById", queryParameters)).FirstOrDefault();
        }

        public async Task<IEnumerable<StateDataValidationErrors>> ImportState(List<ImportedState> parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            string xmlData = ConvertListToXml(parameters);
            queryParameters.Add("@XmlData", xmlData);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);
            return await ListByStoredProcedure<StateDataValidationErrors>("ImportState", queryParameters);
        }

        #endregion

        #region City

        public async Task<int> SaveCity(City_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@CityName", parameters.CityName.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveCity", queryParameters);
        }

        public async Task<IEnumerable<City_Response>> GetCityList(BaseSearchEntity parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<City_Response>("GetCityList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<City_Response?> GetCityById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<City_Response>("GetCityById", queryParameters)).FirstOrDefault();
        }

        public async Task<IEnumerable<CityDataValidationErrors>> ImportCity(List<ImportedCity> parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            string xmlData = ConvertListToXml(parameters);
            queryParameters.Add("@XmlData", xmlData);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);
            return await ListByStoredProcedure<CityDataValidationErrors>("ImportCity", queryParameters);
        }

        #endregion

        #region Territories

        public async Task<int> SaveTerritories(Territories_Request parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", parameters.Id);
            queryParameters.Add("@RegionId", parameters.RegionId);
            queryParameters.Add("@StateId", parameters.StateId);
            queryParameters.Add("@CityId", parameters.CityId);
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            return await SaveByStoredProcedure<int>("SaveTerritories", queryParameters);
        }

        public async Task<IEnumerable<Territories_Response>> GetTerritoriesList(BaseSearchEntity parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@SearchText", parameters.SearchText.SanitizeValue());
            queryParameters.Add("@IsActive", parameters.IsActive);
            queryParameters.Add("@PageNo", parameters.PageNo);
            queryParameters.Add("@PageSize", parameters.PageSize);
            queryParameters.Add("@Total", parameters.Total, null, System.Data.ParameterDirection.Output);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);

            var result = await ListByStoredProcedure<Territories_Response>("GetTerritoriesList", queryParameters);
            parameters.Total = queryParameters.Get<int>("Total");

            return result;
        }

        public async Task<Territories_Response?> GetTerritoriesById(long Id)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@Id", Id);
            return (await ListByStoredProcedure<Territories_Response>("GetTerritoriesById", queryParameters)).FirstOrDefault();
        }

        public async Task<IEnumerable<Territories_Region_State_City_Response>> GetTerritories_Region_State_City_List_ById(Territories_Region_State_City_Search parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            queryParameters.Add("@RegionId", parameters.RegionId);
            queryParameters.Add("@StateId", parameters.StateId);
            queryParameters.Add("@CityId", parameters.CityId);

            var result = await ListByStoredProcedure<Territories_Region_State_City_Response>("GetTerritories_Region_State_City_List_ById", queryParameters);

            return result;
        }

        public async Task<IEnumerable<TerritoriesDataValidationErrors>> ImportTerritories(List<ImportedTerritories> parameters)
        {
            DynamicParameters queryParameters = new DynamicParameters();
            string xmlData = ConvertListToXml(parameters);
            queryParameters.Add("@XmlData", xmlData);
            queryParameters.Add("@UserId", SessionManager.LoggedInUserId);
            return await ListByStoredProcedure<TerritoriesDataValidationErrors>("ImportTerritories", queryParameters);
        }

        #endregion
    }
}

