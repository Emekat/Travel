using System.Collections.Generic;
using System.IO;
using Travel.Application.Common.Interfaces;
using Travel.Application.TourLists.QueriesAndHandlers.ExportTours;

namespace Travel.Shared.Files
{
    public class CsvFileBuilder : ICsvFileBuilder
    {
        public byte[] BuildTourPackagesFile(IEnumerable<TourPackageRecord> records)
        {
            using var memoryStream = new MemoryStream();
            return memoryStream.ToArray();
        }
    }
}