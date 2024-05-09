using Domain.Interfaces.Services;

namespace Infrastructure.Services
{
    public class TimeService : ITimeService
    {
        public DateTime Now
        {
            get => DateTime.UtcNow;
        }
    }
}
