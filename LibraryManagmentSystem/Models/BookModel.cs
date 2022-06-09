namespace LibraryManagmentSystem
{
    public class BookModel : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public int Copies { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return $" { Id } { Title } { Author } { Publisher } { Category } { Copies } { Code }";
        }
    }
}