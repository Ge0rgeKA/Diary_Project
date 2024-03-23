using Microsoft.Data.SqlClient;
using Diary_Project.COMMON.Tasks;
using Diary_Project.DAL.Contracts.Task;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.DAL.Task
{
    public class TaskRepository : ITaskRepository
    {
        public void Add(TaskInputModel task)
        {
            string connectionString = "Data Source=sqlsrv;Initial Catalog=Diary;User ID=student;Password=1;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO Task (Name, Description) VALUES ({task.Name})";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
