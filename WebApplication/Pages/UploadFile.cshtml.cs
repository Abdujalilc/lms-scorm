using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenSourceSCORMLMS.Helpers;
using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace OpenSourceSCORMLMS.Pages
{

    public class UploadFileModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private IConfiguration _configuration;
        private IWebHostEnvironment _environment;
        private ILogger _logger { get; set; }
        private DatabaseHelper databaseHelper { get; set; }
        public UploadFileModel(UserManager<IdentityUser> User, IConfiguration Configuration, IWebHostEnvironment hostingEnvironment, ILogger<UploadFileModel> logger)
        {
            _userManager = User;
            _configuration = Configuration;
            _environment = hostingEnvironment;
            _logger = logger;
            databaseHelper = new DatabaseHelper(_logger);
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(IFormFile file)
        {
            string UserID = _userManager.GetUserId(HttpContext.User);
            bool isSavedSuccessfully = true;
            _logger.LogInformation("Saving package...");
            var siteRoot = _environment.ContentRootPath;
            var uploadFolder = Path.Combine(siteRoot, ConfigurationHelper.UploadFolder);
            var courseFolder = Path.Combine(siteRoot, ConfigurationHelper.CourseFolder);
            if (!Directory.Exists(courseFolder))
            {
                Directory.CreateDirectory(courseFolder);
            }
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }
            string fname = file.FileName;
            string pathToFile = Path.Combine(uploadFolder, file.FileName);

            if (file.Length > 0)
            {

                string newFilename = FileSystemHelper.getUniqueFileName(pathToFile);
                if (!string.IsNullOrWhiteSpace(newFilename))
                {
                    fname = newFilename;
                    pathToFile = Path.Combine(uploadFolder, newFilename);
                }
                using (var fileStream = new FileStream(pathToFile, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            // Make sure the folder name doesn't have invalid characters
            string sFileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathToFile);
            foreach (var c in System.IO.Path.GetInvalidFileNameChars())
            {
                sFileNameWithoutExtension = sFileNameWithoutExtension.Replace(c.ToString(), string.Empty);
            }

            // Unzip the package
            string sPathToPackageFolder = Path.Combine(courseFolder, sFileNameWithoutExtension);
            ZipFile.ExtractToDirectory(pathToFile, sPathToPackageFolder, true);

            // find the imsmanifest.xml file
            string sPathToManifest = FileSystemHelper.FindManifestFile(sPathToPackageFolder);
            SCORMUploadHelper scorm = new SCORMUploadHelper(_logger);
            scorm.parseManifest(sPathToManifest);
            string sPathToIndex = scorm.href;

            databaseHelper.InsertScormCourse(scorm.title, scorm.title, sPathToIndex, sPathToManifest, sPathToPackageFolder, scorm.SCORM_Version, DateTime.Now, UserID);

            if (isSavedSuccessfully)
            {
                string href = "/" + ConfigurationHelper.CourseFolder + "" + sFileNameWithoutExtension + "/" + sPathToIndex + "";
                _logger.LogInformation("SCORM package saved.");
                return new JsonResult(new { Message = fname, Url = href });
            }
            else
            {
                _logger.LogError("Error saving file.");
                return new JsonResult(new { Message = "Error in saving file" });
            }
        }
    }
}
