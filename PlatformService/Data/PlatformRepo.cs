using Dapper;
using Microsoft.Data.SqlClient;
using PlatformService.DTO;
using PlatformService.Dtos;
using PlatformService.Models;
using System.Data;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly IConfiguration _configuration;
        public PlatformRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> CreatePlatForm(PlatFormCreateUpdateDto platForm)
        {
            using (IDbConnection db = new SqlConnection(_configuration["ConnectionStrings:Default"]))
            {
                return await db.ExecuteAsync("Platform_Create", platForm, null, null, CommandType.StoredProcedure);
            }
        }

        public async Task<int> DeletePlatForm(int id)
        {
            using (IDbConnection db = new SqlConnection(_configuration["ConnectionStrings:Default"]))
            {
                return await db.ExecuteAsync("Platform_Delete", id, null, null, CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<PlatformReadDto>> GetAllPlatForm(PlatformGetListDto input)
        {
            using (IDbConnection db = new SqlConnection(_configuration["ConnectionStrings:Default"]))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Name", input.Name);
                parameters.Add("Publisher", input.Publisher);
                parameters.Add("Cost", input.Cost);
                return await db.QueryAsync<PlatformReadDto>("Platform_GetAll", parameters, null, null, CommandType.StoredProcedure);
            }
        }

        public async Task<PlatForm> GetPlatFormAsync(int id)
        {
            using (IDbConnection db = new SqlConnection(_configuration["ConnectionStrings:Default"]))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", id);
                return await db.QueryFirstAsync<PlatForm>("Platform_GetById", parameters, null, null, CommandType.StoredProcedure);
            }
        }

        public async Task<int> UpdatePlatForm(PlatFormCreateUpdateDto platForm)
        {
            throw new NotImplementedException();
        }
    }
}
