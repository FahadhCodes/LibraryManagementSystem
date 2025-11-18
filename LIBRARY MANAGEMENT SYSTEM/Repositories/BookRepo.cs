using LIBRARY_MANAGEMENT_SYSTEM.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace LIBRARY_MANAGEMENT_SYSTEM.Repositories
{
    public class BookRepo
    {
        private readonly string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\FHD29\\Desktop\\LIBRARY MANAGEMENT C#\\Library Managment System\\LIBRARY MANAGEMENT SYSTEM\\libraryDB.mdf\";Integrated Security=True";
        //search book
        public List<Books> SearchBooks(string searchTerm)
        {
            var books = new List<Books>();

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string sql = @"SELECT * FROM libraryTB 
                                  WHERE isbn LIKE @search OR 
                                        title LIKE @search OR 
                                        author LIKE @search OR 
                                        category LIKE @search 
                                  ORDER BY title";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Books bookobj = new Books();
                                bookobj.id = reader.GetInt32("id");
                                bookobj.isbn = reader.GetString("isbn");
                                bookobj.title = reader.GetString("title");
                                bookobj.author = reader.GetString("author");
                                bookobj.category = reader.GetString("category");
                                bookobj.quantity = reader.GetInt32("quantity");
                                books.Add(bookobj);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Database Error");
                Console.WriteLine("ERROR: " + ex.ToString());
            }

            return books;
        }
        // get books
        public List<Books> GetBooks()
        {
            var books = new List<Books>();

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string sql = "SELECT * FROM libraryTB ORDER BY id DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Books bookobj = new Books();
                                bookobj.id = reader.GetInt32(0);
                                bookobj.isbn = reader.GetString(1);
                                bookobj.title = reader.GetString(2);
                                bookobj.author = reader.GetString(3);
                                bookobj.category = reader.GetString(4);
                                bookobj.quantity = reader.GetInt32(5);
                                books.Add(bookobj); //Adding to the list
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: "+ex.ToString());
            }
            return books;
        }

        //by ID
        public Books? GetBooks(int BID) //read student by ID
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string sql = "SELECT * FROM libraryTB WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", BID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Books bookobj = new Books();
                                bookobj.id = reader.GetInt32(0);
                                bookobj.isbn = reader.GetString(1);
                                bookobj.title = reader.GetString(2);
                                bookobj.author = reader.GetString(3);
                                bookobj.category = reader.GetString(4);
                                bookobj.quantity = reader.GetInt32(5);

                                return bookobj;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine("ERROR: "+ex.ToString());
                }
            }
            return null;
        }

        //add new type book
        public void CreateBooks(Books book)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string sql = @"INSERT INTO libraryTB (isbn,title,author,category,quantity) 
                                   VALUES (@isbn,@title,@author,@category,@quantity)";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@isbn", book.isbn);
                        cmd.Parameters.AddWithValue("@title", book.title);
                        cmd.Parameters.AddWithValue("@author", book.author);
                        cmd.Parameters.AddWithValue("@category", book.category);
                        cmd.Parameters.AddWithValue("@quantity", book.quantity);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        //update
        public void updateBooks(Books book)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string sql = "UPDATE libraryTB SET isbn = @isbn, title = @title, author = @author, category = @category, quantity = @quantity WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", book.id);
                        cmd.Parameters.AddWithValue("@isbn", book.isbn);
                        cmd.Parameters.AddWithValue("@title", book.title);
                        cmd.Parameters.AddWithValue("@author", book.author);
                        cmd.Parameters.AddWithValue("@category", book.category);
                        cmd.Parameters.AddWithValue("@quantity", book.quantity);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: "+ex.ToString());
            }
        }

        //delete

        public void deleteBooks(int BID)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string sql = "DELETE FROM libraryTB WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", BID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }
    }
}
