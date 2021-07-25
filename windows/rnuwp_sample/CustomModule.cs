using Microsoft.ReactNative.Managed;

namespace rnuwp_sample
{
    [ReactModule]
    class CustomModule
    {
        [ReactMethod("saveImage")]
        public void SaveImage(string base64)
        {
            var base64String = base64.Replace("data:image/png;base64,", string.Empty);
        }
    }
}
