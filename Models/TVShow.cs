using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVprogram.Models
{
    public class TVShow
    {
        public DateTime StartDateTime { get; set; }
        public string Title { get; set; } = string.Empty;
        public Channel? Channel { get; set; }
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{StartDateTime:dd.MM HH:mm} - {Title}";
        }

    }
}
