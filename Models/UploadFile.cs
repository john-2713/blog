using Microsoft.AspNetCore.Http;

namespace AspNetCoreMvcWebSite.Models
{
    public class UploadFile
    {
        public IFormFile File { get; set; }
    }
}