using BlazorServerCrudDotnet8.Data;
using BlazorServerCrudDotnet8.Models;

namespace BlazorServerCrudDotnet8.Data
{
    public class VideoGameService : IVideoGameService
    {
        private readonly DataContext Context;

        public VideoGameService()
        {
            _context = context;
        }
        public async Task<List<VideoGame>> GetAllGamesAsync();
        {
            var result = await _context.VideoGames.ToListAsync();
            return result;
        }
    }
}