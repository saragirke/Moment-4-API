using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;

namespace MusicAPI.Data
{
    //Ärver klass
    public class SongContext : DbContext{
        //Konstruktor
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }
    public DbSet<Song> Songs { get; set; }  = default!;
    public DbSet<Album> Albums { get; set; }  = default!;
    }
}