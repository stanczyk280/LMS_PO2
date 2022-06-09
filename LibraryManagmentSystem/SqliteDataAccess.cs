using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace LibraryManagmentSystem
{
    public static class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        #region LoadModel

        public static List<BookModel> LoadBookModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BookModel>("SELECT * FROM Book",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<PatronModel> LoadPatronModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PatronModel>("SELECT * FROM Patron",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<BorrowerModel> LoadBorrowerModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BorrowerModel>("SELECT * FROM Borrower",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        #endregion LoadModel

        #region AddToTable

        public static void AddBook(BookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Book (Title, Author, Publisher, Category, Copies, Code) values (@Title, @Author," +
                    " @Publisher, @Category, @Copies, @Code)", book);
            }
        }

        public static void AddPatron(PatronModel patron)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Patron (Name, Surname, City, Address, BirthDate, ContactNumber) values (@Name, @Surname, @City," +
                    " @Address, @BirthDate, @ContactNumber)", patron);
            }
        }

        #endregion AddToTable
    }
}