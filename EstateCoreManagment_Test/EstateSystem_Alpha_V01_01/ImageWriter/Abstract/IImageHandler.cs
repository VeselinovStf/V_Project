using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageWriter.Abstract
{
    public interface IImageHandler
    {
        Task<string> UploadImage(IFormFile file, string name);
    }
}
