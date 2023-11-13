using OMSCore.Application.DTOs.Email;
using System.Threading.Tasks;

namespace OMSCore.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}