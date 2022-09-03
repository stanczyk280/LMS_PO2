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

        public static List<BorrowerModel> LoadBorrowerModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BorrowerModel>("SELECT * FROM Borrower",
                    new DynamicParameters());
                return output.ToList();
            }
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

        #endregion LoadModel

        #region Search

        public static List<BookModel> SearchByTitle(string str)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BookModel>("SELECT * FROM Book WHERE Title = '" + str + "'",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<BookModel> SearchByAuthor(string str)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BookModel>("SELECT * FROM Book WHERE Author = '" + str + "'",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<BookModel> SearchByCategory(string str)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BookModel>("SELECT * FROM Book WHERE Category = '" + str + "'",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<BookModel> SearchByCode(string str)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BookModel>("SELECT * FROM Book WHERE Code = '" + str + "'",
                    new DynamicParameters());
                return output.ToList();
            }
        }

        #endregion Search

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

        public static void AddBorrower(BorrowerModel borrower)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Borrower (BookCode, PatronId, ReleaseDate, DueDate) values (@BookCode, @PatronId," +
                    " @ReleaseDate, @DueDate)", borrower);
            }
        }

        #endregion AddToTable

        #region RemoveFromTable

        public static void RemoveBook(string code)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Book WHERE Code = '" + code + "'");
            }
        }

        public static void RemovePatron(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Patron WHERE Id = '" + id + "'");
            }
        }

        public static void RemoveBorrower(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Borrower WHERE PatronId = '" + id + "'");
            }
        }

        #endregion RemoveFromTable

        public static void DecrementBookNumber(string str)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Book SET Copies = Copies - 1 WHERE Code = '" + str + "'");
            }
        }

        public static void IncrementBookNumber(string str)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Book SET Copies = Copies + 1 WHERE Code = '" + str + "'");
            }
        }
    }
}