using AVDMS.Application.Models;
using AVDMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVDMS.Application.Interfaces
{
    public interface ITerritoryRepository
    {
        #region Region 

        Task<int> SaveRegion(Region_Request parameters);

        Task<IEnumerable<Region_Response>> GetRegionList(BaseSearchEntity parameters);

        Task<Region_Response?> GetRegionById(long Id);

        Task<IEnumerable<RegionDataValidationErrors>> ImportRegion(List<ImportedRegion> parameters);

        #endregion

        #region State 

        Task<int> SaveState(State_Request parameters);

        Task<IEnumerable<State_Response>> GetStateList(BaseSearchEntity parameters);

        Task<State_Response?> GetStateById(long Id);

        Task<IEnumerable<StateDataValidationErrors>> ImportState(List<ImportedState> parameters);

        #endregion

        #region City 

        Task<int> SaveCity(City_Request parameters);

        Task<IEnumerable<City_Response>> GetCityList(BaseSearchEntity parameters);

        Task<City_Response?> GetCityById(long Id);

        Task<IEnumerable<CityDataValidationErrors>> ImportCity(List<ImportedCity> parameters);

        #endregion

        #region Territories 

        Task<int> SaveTerritories(Territories_Request parameters);

        Task<IEnumerable<Territories_Response>> GetTerritoriesList(BaseSearchEntity parameters);

        Task<Territories_Response?> GetTerritoriesById(long Id);

        Task<IEnumerable<Territories_Region_State_City_Response>> GetTerritories_Region_State_City_List_ById(Territories_Region_State_City_Search parameters);

        Task<IEnumerable<TerritoriesDataValidationErrors>> ImportTerritories(List<ImportedTerritories> parameters);

        #endregion
    }
}
