using System.Threading.Tasks;
using Travel.Application.Common.Dtos;

namespace Travel.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailDto emailRequest);
    }
}