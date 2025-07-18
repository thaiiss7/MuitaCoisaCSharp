using MuitaCoisaCSharp.Models;
using MuitaCoisaCSharp.Services;

namespace MuitaCoisaCSharp.Implementations;

public class MockDivaRepository : IDivaRepository
{
    List<Diva> divas = [
        new Diva {
            ID = Guid.NewGuid(),
            Name = "trevis"
        },
        new Diva {
            ID = Guid.NewGuid(),
            Name = "Nycollas"
        },
        new Diva {
            ID = Guid.NewGuid(),
            Name = "Cristian"
        }
    ];
    public async Task<Guid> Create(Diva diva)
    {
        diva.ID = Guid.NewGuid();
        divas.Add(diva);
        return diva.ID;
        throw new NotImplementedException();
    }

    public async Task<Diva> GetByID(Guid id)
    {
        foreach (var diva in divas)
        {
            if (diva.ID == id)
                return diva;
        }
        return null;
    }

    public async Task<IEnumerable<Diva>> Search(string name)
    {
        return divas.Where(d => d.Name.Contains(name));
    }
}