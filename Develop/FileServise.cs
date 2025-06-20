using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using TVprogram.Models;

namespace TVprogram.Develop
{
    public class FileService
    {
        public List<TVShow> LoadShows(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<TVShow>();
            }

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<TVShow>>(json) ?? new List<TVShow>();
        }

        public void SaveShows(string filePath, List<TVShow> shows)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json = JsonSerializer.Serialize(shows, options);

            File.WriteAllText(filePath, json);
        }

        public void SaveStringListAsTxt(string filePath, List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }
    }
}