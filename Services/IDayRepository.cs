using MuitaCoisaCSharp.Models;

namespace MuitaCoisaCSharp.Services;

public interface IDayRepository
{
    Task<Day> GetNextDay();
    Task Create(Day day);
    Task UpdateDay(Day day);
    Task Update(Day today);
}