using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imagefile, string folder, Guid? guid = null);
        Task<Guid> UploadImageGuidAsync(IFormFile imagefile, string folder);
    }
}
