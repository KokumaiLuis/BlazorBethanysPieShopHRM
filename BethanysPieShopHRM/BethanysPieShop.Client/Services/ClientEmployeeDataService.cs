using BethanysPieShopHRM.Shared.Domain;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BethanysPieShop.Client.Services
{
    public class ClientEmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient? _httpClient;

        public ClientEmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var list = await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>( await _httpClient.GetStreamAsync("/api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return list;
        }

        public Task<Employee> GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
