        private static void SaveLatandLngToDatabase(string coordinates, int ID)
        {
            string[] words = coordinates.Split(',');
            
            try
            {
                    
                string connectionString = "Data Source=000.000.00.00; initial catalog=Field_Interviewer_Maps; user id=*****; password=*****;";
               //better Practice is this option 2 Need to install via nugets System.Configuration
               //Conection in App.config
                    // <add name="InterviewerEntities" connectionString="Data Source=*****; initial catalog=Field_Interviewer_Maps; user id=sa; password=***;" providerName="System.Data.SqlClient" />
               string connectionString = ConfigurationManager.ConnectionStrings["InterviewerEntities"].ToString();
                    
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE interviewers_details SET Lat =" + words[0] + ", Lng =" + words[1] + "WHERE ID =" + ID.ToString() +";", conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserting Data Successfully");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
            
        }
