using BlazorServerCrudDotnet8.Models;

namespace BlazorServerCrudDotnet8.Services
{
    public interface IVideoGameService 
    {
        Task<List<VideoGame>> GetAllGamesAsync();
        

    }
}