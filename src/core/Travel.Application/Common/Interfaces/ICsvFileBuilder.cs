using System.Collections.Generic;
using Travel.Application.TourLists.QueriesAndHandlers.ExportTours;

namespace Travel.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTourPackagesFile(IEnumerable<TourPackageRecord> records); 
    }
}