using Microsoft.JSInterop;

namespace BlazorEcommerce.Services.Extensions
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("showSwal", "success", message);
        }
        public static async Task ShowToastrError(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("showSwal", "error", message);
        }
        public static async Task ShowToastrIsConfirm(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("isConfirm", message);
        }
    }
}
