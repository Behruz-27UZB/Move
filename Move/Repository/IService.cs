using Move.Model;

namespace Move.Repository
{
    public interface IService
    {
        Task<Moveis> SetImageAsync(int moveisId, IFormFile file);
        Task<Moveis> GetByIdMoveisAsync(int moveisId);
        Task<Moveis> AddMoveisAsync(Moveis moveis);
        Task<IEnumerable<Moveis>> GetAllMoveisAsync();
    }
}
