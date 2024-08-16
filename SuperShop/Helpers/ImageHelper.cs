using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public  async Task<string> UploadImageAsync(IFormFile imagefile, string folder, Guid? guid = null)
        {
            if (guid == null) guid = Guid.NewGuid();
            var guidString = guid.Value.ToString();
            string file = $"{guidString}.png";
           
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

        public async Task<Guid> UploadImageGuidAsync(IFormFile imagefile, string folder)
        {       
            var guid = Guid.NewGuid();
            UploadImageAsync(imagefile, folder, guid);
            return guid;
        }
    }
}
