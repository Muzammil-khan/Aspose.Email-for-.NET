﻿using System;
using System.Threading;
using Aspose.Email.Clients.Imap;
using Aspose.Email.Mime;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/email
*/

namespace Aspose.Email.Examples.CSharp.Email.IMAP
{
    class RetrievingMessagesAsynchronously
    {
        public static void Run()
        {
            // ExStart:RetrievingMessagesAsynchronously
            // Connect and log in to IMAP
            using (ImapClient client = new ImapClient("host", "username", "password"))
            {
                client.SelectFolder("Issues/SubFolder");
                ImapMessageInfoCollection messages = client.ListMessages();
                AutoResetEvent evnt = new AutoResetEvent(false);
                MailMessage message = null;
                AsyncCallback callback = delegate(IAsyncResult ar)
                {
                    message = client.EndFetchMessage(ar);
                    evnt.Set();
                };
                client.BeginFetchMessage(messages[0].SequenceNumber, callback, null);
                evnt.WaitOne();               
            }
            // ExEnd:RetrievingMessagesAsynchronously
        }
    }
}