using System.Text;

namespace Tyuiu.ErmakovAA.Sprint7.V13.Lib
{
    public class DataService
    {
        public static string? imagesFolder;
        public List<string[]> ParseRouteItems(string path)
        {
            List<string[]> values = new List<string[]>();

            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    values.Add(line.Split(';'));
                }
            }
            return values;
        }
        public bool GetPathImageFile(string fileName, string folderPath, out string? ImagePath)
        {
            string[] formats = { "*.jpg", "*.jpeg", "*.png" };

            if (folderPath == null || string.IsNullOrEmpty(folderPath))
            {
                ImagePath = null;
                return false;
            }

            foreach (var format in formats)
            {
                string[] files = Directory.GetFiles(folderPath, format);

                foreach (var file in files)
                {
                    if (Path.GetFileNameWithoutExtension(file) == fileName)
                    {
                        ImagePath = file;
                        return true;
                    }
                }
            }

            ImagePath = null;
            return false;
        }
    }
}
