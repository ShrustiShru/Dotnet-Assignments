using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SampleConsoleApp;

namespace AssignmentDisconnected.cs
{
    interface IOperation
    {
        void InsertEmployee();
        void DeleteEmployee();
        void UpdateEmployee();
    }

    class Function : IOperation
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        static string query = "SELECT * FROM TBLEMPLOYEE; SELECT * FROM TBLDEPT";
        static DataSet dataset = new DataSet();
        static SqlDataAdapter ada = null;

        public static void LoadData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query,con);
            ada = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            ada.Fill(dataset);
            dataset.Tables[0].TableName = "Employee";
            dataset.Tables[1].TableName = "Department";
        }

        public void InsertEmployee()
        {
            var insert = dataset.Tables[0].NewRow();

            string name = Utilities.Prompt("Enter the name of the Employee");
            string address = Utilities.Prompt("Enter the address of the Employee");
            double salary = Utilities.GetNumber("Enter the salary of the Employee");

            insert[1] = name;
            insert[2] = address;
            insert[3] = salary;

            dataset.Tables[0].Rows.Add(insert);
            ada.Update(dataset.Tables[0]);
        }

        public void DeleteEmployee()
        {
            int id = Utilities.GetNumber("Enter the id u want to delete");
            foreach (DataRow item in dataset.Tables[0].Rows)
            {
                if ((int)item[0] == id)
                {
                    item.Delete();
                    break;
                }
            }
            ada.Update(dataset.Tables[0]);
        }

        public void UpdateEmployee()
        {
            int id = Utilities.GetNumber("Enter the id of the Employee");
            string name = Utilities.Prompt("Enter the name of the Employee");
            string address = Utilities.Prompt("Enter the address of the Employee");
            double salary = Utilities.GetNumber("Enter the salary of the Employee");
            int deptid = Utilities.GetNumber("Enter the department id");

            foreach (DataRow item in dataset.Tables[0].Rows)
            {
                if ((int)item[0]==id)
                {
                    item[1] = name;
                    item[2] = address;
                    item[3] = salary;
                    item[4] = deptid;
                    break;
                }
            }
            ada.Update(dataset.Tables[0]);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Function func = new Function();
            Function.LoadData();

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Press 1 --------->Insert Employee\n" +
                    "Press 2 --------->Delete Employee\n" +
                    "Press 3 --------->Update Employee");
                int choice = Utilities.GetNumber("Enter the choice");
                switch (choice)
                {
                    case 1:
                        func.InsertEmployee();
                        break;
                    case 2:
                        func.DeleteEmployee();
                        break;
                    case 3:
                        func.UpdateEmployee();
                        break;
                }
            }
            throw new Exception("Invalid Input");
        }
    }
}
