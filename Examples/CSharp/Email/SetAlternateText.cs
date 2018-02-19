﻿using Aspose.Email.Mime;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/email
*/

namespace Aspose.Email.Examples.CSharp.Email
{
    class SetAlternateText
    {
        public static void Run()
        {
            // ExStart:SetAlternateText
            // Declare message as MailMessage instance
            MailMessage message = new MailMessage();

            // Creates AlternateView to view an email message using the content specified in the //string
            AlternateView alternate = AlternateView.CreateAlternateViewFromString("Alternate Text");
            
            // Adding alternate text
            message.AlternateViews.Add(alternate);
            // ExEnd:SetAlternateText
        }
    }
}
