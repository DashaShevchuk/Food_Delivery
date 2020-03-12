using Food_Delivery.Data.EFContext;
using Food_Delivery.Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Services
{
    public class FileService
    {
        EFDbContext _context;
        IHostingEnvironment _appEnvironment;
        //private readonly EFDbContext _context;
        //private readonly IHostingEnvironment _appEnvironment;
        //public FileService(EFDbContext context, IHostingEnvironment appEnvironment)
        //{
        //    _context = context;
        //    _appEnvironment = appEnvironment;
        //}

        public async Task AddFile(IFormFile uploadFile)
        {
            if (uploadFile != null)
            {
                string id = Guid.NewGuid().ToString();
                string name = id + ".jpg";
                string path = "/files/" + name;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Id = id, Name = name, Path = path };
                _context.Files.Add(file);
                _context.SaveChanges();

            }
        }
    }
}
