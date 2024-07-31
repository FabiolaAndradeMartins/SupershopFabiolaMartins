using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public  async Task<string> UploadImageAsync(IFormFile imagefile, string folder)
        {
            string guid = Guid.NewGuid().ToString();
            string file = $"{guid}.jpg";
           
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot\\images\\{folder}",
            file);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await imagefile.CopyToAsync(stream);
            }

            return $"~/images/{folder}/{file}";
        }
    }
}
