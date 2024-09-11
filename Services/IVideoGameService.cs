namespace BlazorServerCrudDotnet8.Data
{
    public class IVideoGameService 
    {
        Task<List<VideoGame>> GetAllGamesAsync();
        

    }
}