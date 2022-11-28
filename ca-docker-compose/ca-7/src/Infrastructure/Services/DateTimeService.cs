using ca_7.Application.Common.Interfaces;

namespace ca_7.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
