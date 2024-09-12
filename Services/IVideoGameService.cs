using BlazorServerCrudDotnet8.Models;

namespace BlazorServerCrudDotnet8.Services
{
    public interface IVideoGameService 
    {
        Task<List<VideoGame>> GetAllGamesAsync();
        Task<VideoGame> GetGameByIdAsync(int id);
        Task AddGameAsync(VideoGame game);
        Task UpdeteGameAsync(VideoGame game, int id);
        Task DeleteGameAsync(int id);
        

    }
}