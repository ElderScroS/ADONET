using System;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = Mrak; Initial Catalog = Restaurant; Integrated Security = True";

            {
                Console.Write("Enter customer name: "); string customerName = Console.ReadLine();
                Console.Write("Enter dish name: "); string dishName = Console.ReadLine();

                Console.Clear();
                Console.Write("\n\n\n\n\t\tConfirm order? (Y/N) "); string confirmation = Console.ReadLine();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        if (confirmation.ToUpper() == "Y")
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerName, DishName) VALUES (@customerName, @dishName)", connection, transaction);
                            command.Parameters.AddWithValue("@customerName", customerName);
                            command.Parameters.AddWithValue("@dishName", dishName);
                            command.ExecuteNonQuery();

                            transaction.Commit();
                            Console.WriteLine("Your order has been confirmed!");
                        }
                        else
                        {
                            transaction.Rollback();
                            Console.WriteLine("Your order has been cancelled.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        transaction.Rollback();
                    }
                }
            }

            {
                Console.Write("Enter amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.Write("Enter account number: ");
                int toAccount = int.Parse(Console.ReadLine());

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("UPDATE Customers SET Amount = Amount - @Amount WHERE AccountNumber = @AccountNumber", connection, transaction);
                        cmd1.Parameters.AddWithValue("@Amount", amount);
                        cmd1.Parameters.AddWithValue("@AccountNumber", 12345);
                        cmd1.ExecuteNonQuery();


                        SqlCommand cmd2 = new SqlCommand("UPDATE Customers SET Amount = Amount + @Amount WHERE AccountNumber = @AccountNumber", connection, transaction);
                        cmd2.Parameters.AddWithValue("@Amount", amount);
                        cmd2.Parameters.AddWithValue("@AccountNumber", toAccount);
                        cmd2.ExecuteNonQuery();

                        Console.WriteLine("Do you want to confirm the transaction? (Y/N)"); string result = Console.ReadLine();
                        if (result == "Y" || result == "y")
                        {
                            transaction.Commit();

                            Console.WriteLine("Transaction completed successfully!");
                        }
                        else if (result == "N" || result == "n")
                        {
                            transaction.Rollback();

                            Console.WriteLine("Transaction was rolled back!");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        Console.WriteLine($"Transaction failed with error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }


            }
        }
    }
}
