using System;

namespace cw3.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int? ReleaseYear { get; set; }
        public string? Developer { get; set; }
    }
}
