namespace Travel.Application.TourLists.QueriesAndHandlers.ExportTours
{
    public class ExportToursVm
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
    }
}