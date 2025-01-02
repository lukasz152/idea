using Abstractions.time;
using System.Diagnostics.CodeAnalysis;

namespace Shared.Infrastructure.Time
{
    [ExcludeFromCodeCoverage]
    public sealed class UtcClock : IClock
    {
        public DateTime GetCurrecntDate()
        {
            return DateTime.UtcNow;
        }
    }
}
