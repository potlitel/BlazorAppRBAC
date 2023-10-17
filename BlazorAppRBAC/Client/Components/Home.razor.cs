using Microsoft.AspNetCore.Components;

namespace BlazorAppRBAC.Client.Components
{
    public partial class Home
    {
        [Parameter]
        public string Title { get; set; } = null!;

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; } = null!;

        [CascadingParameter(Name = "HeadingColor")]
        public string Color { get; set; } = null!;

        [Parameter]
        public RenderFragment VisitShopContent { get; set; } = null!;
    }
}