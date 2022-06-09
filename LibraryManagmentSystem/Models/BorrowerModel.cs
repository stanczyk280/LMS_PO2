using System;

namespace LibraryManagmentSystem
{
    public class BorrowerModel : IModel
    {
        public int Id { get; set; }
        public string BookCode { get; set; }
        public int PatronId { get; set; }
        public string ReleaseDate { get; set; }
        public string DueDate { get; set; }

        public override string ToString()
        {
            return $"{BookCode} {PatronId} {ReleaseDate} {DueDate}";
        }
    }
}