using System.Collections.Generic;
using Travel.Application.Common.Dtos;

namespace Travel.Application.TourLists.QueriesAndHandlers.GetTours
{
    public class ToursVm
    {
        public IList<TourListDto> Lists { get; set; }
    }
}