            DatabaseContext db = new DatabaseContext();

            var tableNames = db.Field_Interviewer_Maps.ToList();
            
                  foreach (var item in tableNames)
                    {
                            projectNum = item."SomeDbColumn";
                    }
