using System;

namespace LibraryManagmentSystem
{
    public class PatronModel : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string ContactNumber { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {City} {Address} {BirthDate} {ContactNumber}";
        }
    }
}