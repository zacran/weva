using System.Text.Json;
using Microsoft.JSInterop;

namespace Weva.Data
{
    public static class LocalStorageManager
    {

        private static IJSRuntime? _js;
        public static void Init(IJSRuntime js)
        {
            _js = js;
        }

        public static async Task Save(string key, object value)
        {
            value = JsonSerializer.Serialize(value);
            if (_js != null)
                await _js.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public static async Task<Object> Read(string key)
        {
            if (_js != null)
                return await _js.InvokeAsync<string>("localStorage.getItem", key);
            else
                return new Object();
        }

        public static async Task Delete(string key)
        {
            if (_js != null)
                await _js.InvokeVoidAsync("localStorage.removeItem", key);
        }
    }
}