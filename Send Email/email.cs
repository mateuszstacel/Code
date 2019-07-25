MailMessage mail = new MailMessage("from", "to...");
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("user login", "password");
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                //mail.To.Add("add more peoples...");
                mail.Subject = "this is a test email.";
                mail.Body = "this is my test email body";
                client.Send(mail);






        private static void SendEmail(string subject, string email)
        {
            MailMessage mail = new MailMessage("alert@speechanalytics", "mateusz.stacel@bmgresearch.co.uk");
            SmtpClient client = new SmtpClient("172.16.0.43");
            client.Port = 25;
            client.UseDefaultCredentials = false;
            client.EnableSsl = false;
            client.Credentials = new NetworkCredential("", "");
            //mail.To.Add("add more peoples...");
            mail.Subject = subject;
            mail.IsBodyHtml = true;


            mail.Body = email;


            client.Send(mail);
        }
