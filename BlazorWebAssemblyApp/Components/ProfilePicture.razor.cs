using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
