using Microsoft.JSInterop;

namespace Homely.Models
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "javascript confirm popup from class");
            return await js.InvokeAsync<bool>("confirm", message);
        }
        
        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("my_function", message);
        }
    }
}
