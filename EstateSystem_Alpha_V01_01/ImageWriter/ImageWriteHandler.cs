using ImageWriter.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageWriter
{
    public class ImageWriteHandler : IImageHandler
    {
        private readonly IImageWriter imageWriter;

        public ImageWriteHandler(IImageWriter imageWriter)
        {
            this.imageWriter = imageWriter;
        }
        public async Task<string> UploadImage(IFormFile file, string name)
        {
            var result = await imageWriter.UploadImage(file,  name);

            //return new ObjectResult(result)
            return result;
        }
    }
}
