using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Services
{
    public interface ICompanyservice
    {
        string GetPath(IFormFile file);
       
    }
}
