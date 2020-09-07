using System;
using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Quartz;
 
namespace ProjectIepAuction.Quartz
{
    public class TaskQuartzJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            string id = context.JobDetail.JobDataMap.GetString("id");
            
 
            string connectionString = "Server=localhost,10800;Database=ProjectIepAuctionDB;User Id=sa;Password=Iep12345;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
 
            string sql_query = "Update Auctions set state='OPEN' where Id='"+id+"'";
            SqlCommand command = new SqlCommand(sql_query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand =  new SqlCommand(sql_query, connection);
            await adapter.UpdateCommand.ExecuteNonQueryAsync();
 
            command.Dispose();
            connection.Close();
        }
    }
}