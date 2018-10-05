using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.ComponentModel;

namespace ExpertERP.Procedure
{
    public class SendMail
    {

        public BackgroundWorker worker;
        #region contructor

        public  SendMail()
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            SendMailInfo Info = e.Argument as SendMailInfo;

            SmtpClient emailsend = new SmtpClient(Info.Smtpserver);
            emailsend.UseDefaultCredentials = false;
            emailsend.Credentials = new NetworkCredential(Info.MailFrom, Info.Password);

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            emailsend.EnableSsl = Info.Ssl;

            if (Info.Attachment)
            {
                try
                {
                    Attachment sendFile;
                    foreach (String attach in Info.PathAttachment)
                    {
                        sendFile = new Attachment(attach);
                        mail.Attachments.Add(sendFile);
                    }
                }
                catch
                {
                    return;
                }
            }

            try
            {
                mail.From = new MailAddress(Info.MailFrom);

                foreach (String address in Info.MailTo)
                {
                    if (!String.IsNullOrEmpty(address) && !mail.To.Contains(new MailAddress(address)))
                        mail.To.Add(address);
                }

                foreach (String address in Info.MailCC)
                {
                    if (!String.IsNullOrEmpty(address) && !mail.CC.Contains(new MailAddress(address)) && !mail.To.Contains(new MailAddress(address)))
                        mail.CC.Add(address);
                }

                mail.Subject = Info.Subject;
                mail.Body = "<html><body>" + Info.Content + "<br></body></html>";
                emailsend.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }

       
        #endregion

        #region function SendMail

        public bool Send(string mailFrom, string Password, string mailTo, List<String> cc, string Subject, string content, String SMTPserver, int port, bool SSL, bool bAttachment, List<String> pathFileNameAtt)
        {
            #region Old
 SmtpClient emailsend;
            MailMessage mail;
            emailsend = new SmtpClient(SMTPserver);
            emailsend.UseDefaultCredentials = false;
            emailsend.Credentials = new NetworkCredential(mailFrom, Password);
            mail = new MailMessage();
            mail.IsBodyHtml = true;

            //if (SSL == true)
            emailsend.EnableSsl = true;
            //else
            //    emailsend.EnableSsl = false;

            if (bAttachment == true)
            {
                try
                {
                    Attachment sendFile;
                    foreach (String attach in pathFileNameAtt)
                    {
                        sendFile = new Attachment(attach);
                        mail.Attachments.Add(sendFile);
                    }
                }
                catch
                {
                    return false;
                }
            }
            try
            {
                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);
                foreach (String address in cc)
                {
                    if (!String.IsNullOrEmpty(address) && !mail.CC.Contains(new MailAddress(address)))
                        mail.CC.Add(address);
                }
                mail.Subject = Subject;
                mail.Body = content;
                emailsend.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
 #endregion

            List<String> MailTo = new List<String>();
            MailTo.Add(mailTo);
            SendMailInfo Info = new SendMailInfo(mailFrom, Password, MailTo, cc, Subject, content, SMTPserver, port, SSL, bAttachment, pathFileNameAtt);
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync(Info);
            }
            return true;
        }

        public bool Send(string mailFrom, string Password, List<String> mailTo, List<String> cc, string Subject, string content, String SMTPserver, int port, bool SSL, bool bAttachment, List<String> pathFileNameAtt)
        {
            #region Old
            //SmtpClient emailsend;
            //MailMessage mail;
            //emailsend = new SmtpClient(SMTPserver);
            //emailsend.UseDefaultCredentials = false;
            //emailsend.Credentials = new NetworkCredential(mailFrom, Password);
            //mail = new MailMessage();
            //mail.IsBodyHtml = true;

            ////if (SSL == true)
            //emailsend.EnableSsl = true;
            ////else
            ////    emailsend.EnableSsl = false;

            //if (bAttachment == true)
            //{
            //    try
            //    {
            //        Attachment sendFile;
            //        sendFile = new Attachment(pathFileNameAtt);
            //        mail.Attachments.Add(sendFile);
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //}
            //try
            //{
            //    mail.From = new MailAddress(mailFrom);

            //    foreach (String address in mailTo)
            //    {
            //        if (!String.IsNullOrEmpty(address) && !mail.To.Contains(new MailAddress(address)))
            //            mail.To.Add(address);
            //    }

            //    foreach (String address in cc)
            //    {
            //        if (!String.IsNullOrEmpty(address) && !mail.CC.Contains(new MailAddress(address)) && !mail.To.Contains(new MailAddress(address)))
            //            mail.CC.Add(address);
            //    }
               

            //    mail.Subject = Subject;
            //    mail.Body = content;
            //    emailsend.Send(mail);
            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    return false;
            //}
            #endregion

            SendMailInfo Info = new SendMailInfo(mailFrom, Password, mailTo, cc, Subject, content, SMTPserver, port, SSL, bAttachment, pathFileNameAtt);

            SmtpClient emailsend = new SmtpClient(Info.Smtpserver);
            emailsend.UseDefaultCredentials = false;
            emailsend.Credentials = new NetworkCredential(Info.MailFrom, Info.Password);
            emailsend.Port = Info.Port;
            emailsend.Host = Info.Smtpserver;

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            emailsend.EnableSsl = Info.Ssl;

            if (Info.Attachment)
            {
                try
                {
                    Attachment sendFile;
                    foreach (String attach in Info.PathAttachment)
                    {
                        sendFile = new Attachment(attach);
                        mail.Attachments.Add(sendFile);
                    }
                }
                catch
                {
                    return false;
                }
            }

            try
            {
                mail.From = new MailAddress(Info.MailFrom);

                foreach (String address in Info.MailTo)
                {
                    if (!String.IsNullOrEmpty(address) && !mail.To.Contains(new MailAddress(address)))
                        mail.To.Add(address);
                }

                foreach (String address in Info.MailCC)
                {
                    if (!String.IsNullOrEmpty(address) && !mail.CC.Contains(new MailAddress(address)) && !mail.To.Contains(new MailAddress(address)))
                        mail.CC.Add(address);
                }

                mail.Subject = Info.Subject;
                mail.Body = "<html><body>" + Info.Content + "<br></body></html>";
                emailsend.Send(mail);
            }
            catch (Exception ex)
            {
            }
            return true;
        }

        public void SendEmail(String To)
        {
            //OutLook.Application outlookApplication = new OutLook.Application();
            //OutLook._NameSpace outlookNS = outlookApplication.GetNamespace("MAPI");
            //outlookNS.Logon(Missing.Value, Missing.Value, true, false);
            //outlookNS.Logon("", "", true, true);
            //OutLook.MAPIFolder inboxFolder = outlookNS.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderInbox);
            //inboxFolder.Display();
            //OutLook.MailItem mail = outlookApplication.CreateItem(OutLook.OlItemType.olMailItem) as OutLook.MailItem;

            //if (mail == null)
            //    return;
            //mail.To = To;
            //mail.Display(true);
        }
        #endregion
    }
}
