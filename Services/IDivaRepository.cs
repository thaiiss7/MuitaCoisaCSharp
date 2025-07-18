using MuitaCoisaCSharp.Models;

namespace MuitaCoisaCSharp.Services;

public interface IDivaRepository
{
    Task<IEnumerable<Diva>> Search(string name);
    Task<Diva?> GetByID(Guid id);
    Task<Guid?> Create(Diva diva);
}