using MicroRabbit.Presentation.Web.Models.DTO;
using System.Threading.Tasks;

namespace MicroRabbit.Presentation.Web.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDTO transferDTO);
    }
}
