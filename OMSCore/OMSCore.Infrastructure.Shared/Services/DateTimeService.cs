using OMSCore.Application.Interfaces;
using System;

namespace OMSCore.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}