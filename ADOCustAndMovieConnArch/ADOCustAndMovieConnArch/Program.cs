using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ADOCustAndMovieConnArch
{
    public class Customer
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string DOB { get; set; }
        public string  City { get; set; }
    }
    class Program
    {
        public static void GetDataBySqlDataReader()
        {
            StringBuilder sb = new StringBuilder(1024);
            using(SqlConnection con= new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from TblCustomer", con))
                {
                    con.Open();
                    using(SqlDataReader dr= cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while(dr.Read())
                        {
                            sb.AppendLine($"CustomerName:{dr[1].ToString()}");
                            sb.AppendLine($"City:{dr[3].ToString()}");
                            sb.AppendLine();
                        }    
                    }
                }
            }
            var result = sb.ToString();
            Console.WriteLine(result);
        }
       public static void GetDataByGetMethodsOfDr()
        {
            List<Customer> Custlist = new List<Customer>();
            using(SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                cn.Open();
                using(SqlCommand cmd= new SqlCommand("Select * from TblCustomer",cn))
                {
                    using(SqlDataReader sd = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while(sd.Read())
                        {
                            Custlist.Add( new Customer
                            {
                                CName= sd.GetString(sd.GetOrdinal("CustomerName")),
                                City= sd.GetString(sd.GetOrdinal("City"))
                            });
                        }
                    }
                }
                
                foreach(var v in Custlist)
                {
                    Console.WriteLine($"CustomerName : {v.CName}\nCity : {v.City}\n");
                }
            }
            
        }
        public static void GetDataByGetFieldValue()
        {
            List<Customer> Custlist = new List<Customer>();
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("Select CustomerName,City from TblCustomer", cn))
                {
                    using (SqlDataReader sd = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (sd.Read())
                        {
                            Custlist.Add(new Customer
                            {
                                CName = sd.GetFieldValue<string>(sd.GetOrdinal("CustomerName")),
                                City = sd.GetFieldValue<string>(sd.GetOrdinal("City"))
                            });
                        }
                    }
                }
                
                foreach (var v in Custlist)
                {
                    Console.WriteLine($"CustomerName  : {v.CName}\nCity : {v.City}\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Customer data using DataReader");
            Program.GetDataBySqlDataReader();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Customer data using GetMethod");
            Program.GetDataByGetMethodsOfDr();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Customer data using GetFieldValue");
            Program.GetDataByGetFieldValue();
        }
    }
}
