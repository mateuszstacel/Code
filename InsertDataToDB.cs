        private static void SaveLatandLngToDatabase(string coordinates, int ID)
        {
            string[] words = coordinates.Split(',');
            
            try
            {
                string connectionString = "Data Source=000.000.00.00; initial catalog=Field_Interviewer_Maps; user id=*****; password=*****;";
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
