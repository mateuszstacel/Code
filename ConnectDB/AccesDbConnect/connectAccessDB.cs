       public static string totalCalls()
        {
            //1 Create an OleDBConnection
            OleDbConnection DBConnection = new OleDbConnection();

            //2 Create the Data Adapter(to get values froum our acces table)
            OleDbDataAdapter DataAdapter;

            //3 Create a local data table to hold the values of access table
            DataTable LocalDataTable = new DataTable();

            string totalcalls = "";

            var conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DS01\\Desktop\\numerics.accdb";

            using (OleDbConnection connection = new OleDbConnection(conn))
            {
                try
                {
                    var query = "SELECT * FROM TotalCallsByProject";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(LocalDataTable);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }


            foreach (DataRow row in LocalDataTable.Rows)
            {
                totalcalls += row["CampaignDisplayName"].ToString() + " // Total Calls : " + row["CountOfCallID"].ToString() + "\n";
            }

            DBConnection.Close();

            return totalcalls;
        }
