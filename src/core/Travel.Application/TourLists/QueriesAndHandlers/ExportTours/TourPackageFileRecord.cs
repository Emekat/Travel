using Travel.Application.Mappings;
using Travel.Domain.Entities;

namespace Travel.Application.TourLists.QueriesAndHandlers.ExportTours
{
    public class TourPackageRecord : IMapFrom<TourPackage>
    {
        public string Name { get; set; }
        public string MapLocation { get; set; }
    }
}