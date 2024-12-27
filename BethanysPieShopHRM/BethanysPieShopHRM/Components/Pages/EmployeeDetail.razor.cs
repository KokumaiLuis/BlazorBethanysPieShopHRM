using BethanysPieShopHRM.Services;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.Contracts.Services;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.QuickGrid;
using BethanysPieShop.Client;
using BethanysPieShopHRM.Shared.Model;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId {  get; set; }

        public Employee Employee { get; set; } = new Employee();

        public List<TimeRegistration> TimeRegistrations { get; set; } = [];

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Inject]
        public ITimeRegistrationDataService? TimeRegistrationDataService { get; set; }
        private float itemHeight = 50;
        protected IQueryable<TimeRegistration>? itemsQueryable;
        protected int queryableCount = 0;
        public PaginationState pagination = new() { ItemsPerPage = 10 };

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected async override Task OnInitializedAsync()
        {
            //Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
            Employee = await EmployeeDataService.GetEmployeeDetails(employeeId: EmployeeId);
            //TimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(employeeId: EmployeeId);
            itemsQueryable = (await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(employeeId: EmployeeId)).AsQueryable();
            queryableCount = itemsQueryable.Count();

            if (Employee.Longitude.HasValue && Employee.Latitude.HasValue)
            {
                MapMarkers = new List<Marker>
                {
                    new Marker{Description = $"{Employee.FirstName} {Employee.LastName}",  ShowPopup = false, X = Employee.Longitude.Value, Y = Employee.Latitude.Value}
                };
            }
        }

        public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
        {
            int totalNumberOfTimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationCountForEmployeeId(EmployeeId);

            var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
            var listItems = await TimeRegistrationDataService.GetPagedTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);

            return new ItemsProviderResult<TimeRegistration>(listItems, totalNumberOfTimeRegistrations);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
