using Microsoft.EntityFrameworkCore;
using BlazorServerCrudDotnet8.Data;
using BlazorServerCrudDotnet8.Models;

namespace BlazorServerCrudDotnet8.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly DataContext _context;

        public VideoGameService(DataContext context)
        {
            _context = context;
        }

        public Task AddGameAsync(VideoGame game)
        {
            _context.VideoGames.Add(game);
            return _context.SaveChangesAsync();
        }

        public async Task DeleteGameAsync(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game != null)
            {
                _context.VideoGames.Remove(game);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<VideoGame>> GetAllGamesAsync()
        {
            var result = await _context.VideoGames.ToListAsync();
            return result;
        }

        public async Task<VideoGame> GetGameByIdAsync(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            return game;
        }

        public async Task UpdeteGameAsync(VideoGame game, int id)
        {
            var dbgame = await _context.VideoGames.FindAsync(id);
            if (dbgame != null)
            {
                dbgame.Title = game.Title;
                dbgame.Publisher = game.Publisher;
                dbgame.ReleaseYear = game.ReleaseYear;
                
                await _context.SaveChangesAsync();
            }
        }
    }
}