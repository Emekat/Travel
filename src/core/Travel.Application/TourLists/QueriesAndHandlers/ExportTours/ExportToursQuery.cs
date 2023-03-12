using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Travel.Application.TourLists.QueriesAndHandlers.ExportTours
{
    public class ExportToursQuery: IRequest<ExportToursVm>
    {
        public int ListId { get; set; }
    }

    public class ExportToursQueryHandler : IRequestHandler<ExportToursQuery, ExportToursVm>
    {
        public async Task<ExportToursVm> Handle(ExportToursQuery request, CancellationToken
            cancellationToken)
        {
            var vm = new ExportToursVm();
            vm.ContentType = "text/csv";
            vm.FileName = "TourPackages.csv";
            return await Task.FromResult(vm);
        }
    }
}