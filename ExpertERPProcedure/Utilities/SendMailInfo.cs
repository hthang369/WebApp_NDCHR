using System;
using System.Collections.Generic;

using System.Text;

namespace ExpertERP.Procedure
{
    class SendMailInfo
    {

        protected string mailFrom;
        protected string password;
        protected List<String> mailTo;
        protected List<String> mailCC;
        protected string subject;
        protected string content;
        protected string smtpserver;
        protected int port;
        protected bool ssl;
        protected bool attachment;
        protected List<String> pathAttachment;

        public SendMailInfo(string mmailFrom, string mpassword, List<String> mmailTo, List<String> mmailCC, string msubject, string mcontent, string msmtpserver, int mport, bool mssl, bool mattachment, List<String> mpathAttachment)
        {
            mailFrom = mmailFrom;
            password = mpassword;
            mailTo = mmailTo;
            mailCC = mmailCC;
            subject = msubject;
            content = mcontent;
            smtpserver = msmtpserver;
            port = mport;
            ssl = mssl;
            attachment = mattachment;
            pathAttachment = mpathAttachment;
        }

        public string MailFrom
        {
            get { return mailFrom; }
            set { mailFrom = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public List<String> MailTo
        {
            get { return mailTo; }
            set { mailTo = value; }
        }


        public List<String> MailCC
        {
            get { return mailCC; }
            set { mailCC = value; }
        }


        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }


        public string Content
        {
            get { return content; }
            set { content = value; }
        }


        public String Smtpserver
        {
            get { return smtpserver; }
            set { smtpserver = value; }
        }


        public int Port
        {
            get { return port; }
            set { port = value; }
        }


        public bool Ssl
        {
            get { return ssl; }
            set { ssl = value; }
        }


        public bool Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }


        public List<String> PathAttachment
        {
            get { return pathAttachment; }
            set { pathAttachment = value; }
        }

        public SendMailInfo()
        {

        }

        
    }
}
