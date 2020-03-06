using System;
using System.Data.SqlClient;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
//using TodoManager.Web.Data.Enums;

namespace TodoManager.Schedular
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public async static void Run([TimerTrigger("0 07 2 * * *")]TimerInfo myTimer, ILogger log)
        {
            int rows = 0;
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            var connectionstring = Environment.GetEnvironmentVariable("ToDoDbContext");
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var selectquery = "SELECT count(*) From ToDos WHERE Due < GetDate();";
                using (SqlCommand cmd = new SqlCommand(selectquery, conn))
                {
                    rows = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
                if(rows > 0)
                {
                    var text = "UPDATE ToDos SET [Status] = 3 WHERE Due < GetDate(); ";

                    using (SqlCommand cmd = new SqlCommand(text, conn))
                    {
                        // Execute the command and log the # rows affected.
                        var updatedrows = await cmd.ExecuteNonQueryAsync();
                        log.LogInformation($"{updatedrows} rows were updated");
                    }
                }
               
            }
        }
        }
    }

