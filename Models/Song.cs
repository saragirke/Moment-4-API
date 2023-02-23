namespace MusicAPI.Models
{

    public class Song
    {
        public int Id { get; set; }
        public string? Artist { get; set; }
        public string? Title { get; set; }
        public int? Length { get; set; }
        public string? Category { get; set; }
        public int? AlbumId { get; set; }
        public Album? Album { get; set; }

    }
}