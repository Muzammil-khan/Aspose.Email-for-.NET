﻿using Aspose.Email.Mime;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email
{
    class SetEmailHeaders
    {
        public static void Run()
        {
            // ExStart:SetEmailHeaders
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Email();

            // Create an instance MailMessage class
            MailMessage mailMessage = new MailMessage();

            // Specify ReplyTo, From, To field, Cc and Bcc Addresses
            mailMessage.ReplyToList.Add("reply@reply.com");
            mailMessage.From = "sender@sender.com";
            mailMessage.To.Add("receiver1@receiver.com");
            mailMessage.CC.Add("receiver2@receiver.com");
            mailMessage.Bcc.Add("receiver3@receiver.com");

            // Specify Date, Message subject, XMailer, Secret Header, Save message to disc
            mailMessage.Subject = "test mail";
            mailMessage.Date = new System.DateTime(2006, 3, 6);
            mailMessage.XMailer = "Aspose.Email";
            mailMessage.Headers.Add("secret-header", "mystery");
            mailMessage.Save(dataDir + "SetEmailHeaders_out.msg", SaveOptions.DefaultMsg);
            // ExEnd:SetEmailHeaders
        }
    }
}
