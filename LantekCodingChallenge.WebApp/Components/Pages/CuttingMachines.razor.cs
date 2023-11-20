using LantekCodingChallenge.Models;
using LantekCodingChallenge.Services;
using Microsoft.AspNetCore.Components;

namespace LantekCodingChallenge.WebApp.Components.Pages
{
    public partial class CuttingMachines
    {
        [Inject]
        private LantekAPIService Service { get; set; } = null!;
        [CascadingParameter(Name = "Authentication")] 
        private BasicAuth Authentication { get; set; } = null!;

        private List<CuttingMachine>? Model { get; set; }
        private string Resource { get; set; } = "/api/cut";
        private string ErrorMessage { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            UpdateModel();
            await base.OnInitializedAsync();
        }

        public async void UpdateModel()
        {
            try
            {
                Model = await Service.GetMachinesAsync(Resource, Authentication);
            }
            catch (Exception ex)
            {
                Model = null;
                ErrorMessage = ex.Message;
            }
            StateHasChanged();
        }
    }
}
