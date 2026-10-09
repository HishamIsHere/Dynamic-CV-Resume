namespace WebAppTemplate.Helpers.File
{
    public class FileHelper :IFileHelper
    {
        IWebHostEnvironment _webHostEnvironment;

        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string SaveImage(IFormFile File, string folderName, string OldImageName = null)
        {
            string FinalName;
            if (File != null)
            {
                List<string> allowedExtensions = new List<string>
                    {
                        ".png",".jpeg",".jpg"
                    };
                var rootPath = Path.Combine(_webHostEnvironment.WebRootPath, folderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);
                // no / S !
                // newjpg / new(1).jpg
                var newName = Guid.NewGuid().ToString() + fileInfo.Extension;
                if (allowedExtensions.Contains(fileInfo.Extension.ToString()))
                {
                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }
                    FinalName = $"/{folderName}/{newName}";
                }
                else
                {
                    FinalName = "Error";
                }
            }
            else
            {
                return OldImageName;
            }
            return FinalName;
        }
        public string SaveDoc(IFormFile File, string folderName, string OldImageName = null)
        {
            string FinalName;
            if (File != null)
            {
                List<string> allowedExtensions = new List<string>
                    {
                        ".pdf",".docx",".doc"
                    };
                var rootPath = Path.Combine(_webHostEnvironment.WebRootPath, folderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);
                // no / S !
                // newjpg / new(1).jpg
                var newName = Guid.NewGuid().ToString() + fileInfo.Extension;
                if (allowedExtensions.Contains(fileInfo.Extension.ToString()))
                {
                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }
                    FinalName = $"/{folderName}/{newName}";
                }
                else
                {
                    FinalName = "Error";
                }
            }
            else
            {
                return OldImageName;
            }
            return FinalName;
        }
    }
}
