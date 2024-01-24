using BethanysPieShopHRM.Shared.Domain;
using BlazorWebAssemblyApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee? Employee { get; set; } = new();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}
