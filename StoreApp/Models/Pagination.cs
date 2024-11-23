namespace StoreApp.Models
{
    public class Pagination
    {
        public int Totaltems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)Totaltems / ItemsPerPage);
    }
}