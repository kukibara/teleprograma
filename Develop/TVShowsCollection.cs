using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVprogram.Develop;
using TVprogram.Models;

namespace TVprogram.Develop
{
    public class TVShowsCollection
    {
        private List<TVShow> _shows;
        private readonly FileService _fileService;

        public TVShowsCollection()
        {
            _shows = new List<TVShow>();
            _fileService = new FileService();
        }

        // Метод, щоб отримати всі відсортовані телепередачі
        public List<TVShow> GetAllShows()
        {
            return _shows.OrderBy(s => s.StartDateTime).ToList();
        }

        // Метод для додавання нової передачі
        public void AddShow(TVShow show)
        {
            _shows.Add(show);
        }

        // Метод для видалення передачі
        public void RemoveShow(TVShow show)
        {
            _shows.Remove(show);
        }

        // Метод для фільтрації передач
        public List<TVShow> GetFilteredShows(DateTime date, string genre, string channel, string title)
        {
            // Беремо всі передачі і застосовуємо до них фільтри
            var filteredList = _shows.Where(show =>
            {
            bool dateMatch = show.StartDateTime.Date == date.Date;
            bool genreMatch = (genre == "Всі жанри" || show.Genre == genre);
            bool channelMatch = (channel == "Всі канали" ||  show.Channel.Name == channel);
            bool titleMatch = string.IsNullOrEmpty(title) || show.Title.Contains(title, StringComparison.OrdinalIgnoreCase);

            return dateMatch && genreMatch && channelMatch && titleMatch;
        }).OrderBy(show => show.StartDateTime).ToList();

            return filteredList;
        }

        // Метод для завантаження даних з файлу
        public void LoadFromFile(string filePath)
        {
            _shows = _fileService.LoadShows(filePath);
            if (_shows.Count == 0)
            {
                CreateDefaultData();
            }
        }

        // Метод для збереження даних у файл
        public void SaveToFile(string filePath)
        {
            _fileService.SaveShows(filePath, _shows);
        }

        // Приватний метод для створення тестових даних
        private void CreateDefaultData()
        {
            var channel1 = new Channel { Name = "1+1", Country = "Україна" };
            var channel2 = new Channel { Name = "СТБ", Country = "Україна" };
            _shows = new List<TVShow>
            {
                new TVShow { StartDateTime = new DateTime(2025, 6, 20, 8, 0, 0), Title = "Ранкові новини", Channel = channel1, Genre = "Новини"},
                new TVShow { StartDateTime = new DateTime(2025, 6, 20, 20, 0, 0), Title = "Мастер Шеф", Channel = channel2, Genre = "Кулінарія"},
                new TVShow { StartDateTime = new DateTime(2025, 6, 21, 21, 0, 0), Title = "Фільм 'Гаррі Поттер'", Channel = channel1, Genre = "Фантастика" }
            };
        }

        // Метод збереження списку перегляду
        public void SaveWatchlistAsTxt(string filePath, List<TVShow> watchlist)
        {
            List<string> linesToSave = watchlist.Select(show => show.ToString()).ToList();

            _fileService.SaveStringListAsTxt(filePath, linesToSave);
        }
    }
}