using BethanysPieShopHRM.Shared.Domain;
using BlazorWebAssemblyApp.Models;

namespace BlazorWebAssemblyApp.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        private Employee? _selectedEmployee;

        public string Title = "Employee overview";
        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
