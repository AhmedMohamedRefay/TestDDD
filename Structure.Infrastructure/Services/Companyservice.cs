using Castle.DynamicProxy.Generators;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//using static System.Net.Mime.MediaTypeNames;

namespace Structure.Infrastructure.Services
{
    public class Companyservice : ICompanyservice
    {
        public string GetPath(IFormFile file)
        {
       

            // Resize the image if needed
           

            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0&& file.Length<=1000000)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                 var  dbPath = Path.Combine(folderName, fileName);
                if (!ValidImageWidthAndHeigh(file))
                    throw new Exception("width and heigh not valid");
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {

                    file.CopyTo(stream);
                }
                return dbPath;
            }
            else
            {
                return "Not Allow";
            }
        }

        private bool ValidImageWidthAndHeigh(IFormFile file)
        {
            bool IsValid=true;

            using (var image = System.Drawing.Image.FromStream(file.OpenReadStream()))

            {
                if (image.Width > 250 || image.Height > 250)
                {
                     IsValid = false;
                }
            }
            return IsValid;
        }

        private void comprssionImage(IFormFile file)
        {


            using (MagickImage image = new MagickImage(file.Name))
            {

                image.Format = image.Format; // Get or Set the format of the image.
                image.Resize(30, 30); // fit the image into the requested width and height. 
                image.Quality = 10; // This is the Compression level.
                image.Write("YourFinalImage.jpg");
            }
        }
             
        
    }
     
}
