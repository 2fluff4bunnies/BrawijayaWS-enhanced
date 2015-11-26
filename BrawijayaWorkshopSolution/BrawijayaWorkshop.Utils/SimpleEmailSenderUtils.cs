﻿using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BrawijayaWorkshop.Utils
{
    public static class SimpleEmailConstants
    {
        public const string APP_SETTING_MAIL_SERVER = "MailServer";
        public const string APP_SETTING_MAIL_SERVERPORT = "MailServerPort";
        public const string APP_SETTING_MAIL_USERNAME = "MailUsername";
        public const string APP_SETTING_MAIL_PASSWORD = "MailPassword";
        public const string APP_SETTING_MAIL_SSL = "MailSSL";

        public const string MAIL_TEMPLATE_APPNAME = "@@appname@@";
        public const string MAIL_TEMPLATE_ERRORCONTENT = "@@error@@";
    }

    public static class SimpleEmailSenderUtils
    {
        public static bool IsValidEmail(string input)
        {
            try
            {
                return Regex.IsMatch(input,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void SendEmail(string emailSubject, string emailBody, string to, string from, string cc, string bcc, string attachmentUrl)
        {
            if (!IsValidEmail(to))
                return;
            //get the mail server
            string mailServer = ConfigurationManager.AppSettings[SimpleEmailConstants.APP_SETTING_MAIL_SERVER];
            string mailServerPort = ConfigurationManager.AppSettings[SimpleEmailConstants.APP_SETTING_MAIL_SERVERPORT];
            string mailUsername = ConfigurationManager.AppSettings[SimpleEmailConstants.APP_SETTING_MAIL_USERNAME];
            string mailPassword = ConfigurationManager.AppSettings[SimpleEmailConstants.APP_SETTING_MAIL_PASSWORD];
            mailPassword = mailPassword.Decrypt();
            string mailSSL = ConfigurationManager.AppSettings[SimpleEmailConstants.APP_SETTING_MAIL_SSL];

            MethodBase.GetCurrentMethod().Debug("Send email notification to :" + to + ", cc :" + cc + ", bcc : " + bcc);

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(mailServer);
            if (!string.IsNullOrEmpty(mailServerPort))
            {
                smtp.Port = int.Parse(mailServerPort);
            }
            smtp.Credentials = new System.Net.NetworkCredential(mailUsername, mailPassword);
            smtp.EnableSsl = false;

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(from, to, emailSubject, emailBody);

            // CC
            if (!string.IsNullOrEmpty(cc))
            {
                if (cc.Contains(','))
                {
                    string[] ccs = cc.Split(',');
                    for (int i = 0; i < ccs.Length; i++)
                    {
                        msg.CC.Add(ccs[i]);
                    }
                }
                else
                    msg.CC.Add(cc);
            }

            // BCC
            if (!string.IsNullOrEmpty(bcc))
            {
                if (bcc.Contains(','))
                {
                    string[] bccs = bcc.Split(',');
                    for (int i = 0; i < bccs.Length; i++)
                    {
                        msg.Bcc.Add(bccs[i]);
                    }
                }
                else
                    msg.Bcc.Add(bcc);
            }

            // SSL
            if (!string.IsNullOrEmpty(mailSSL))
            {
                bool ssl = true;
                if (!bool.TryParse(mailSSL, out ssl))
                    smtp.EnableSsl = false;
                smtp.EnableSsl = ssl;
            }

            if (attachmentUrl != string.Empty)
            {
                //use by the multiple attachment
                char[] Delimiter = { ',' };
                //split multiple attachment with coma ","
                string[] SplitAttachment = attachmentUrl.Split(Delimiter);
                //Multiple Attachment
                if (SplitAttachment.Length > 0)
                {
                    for (int i = 0; i < SplitAttachment.Length; i++)
                    {
                        msg.Attachments.Add(new System.Net.Mail.Attachment(SplitAttachment[i].ToString()));
                    }
                }
                //Single Attachment
                else
                {
                    msg.Attachments.Add(new System.Net.Mail.Attachment(attachmentUrl));
                }
            }
            msg.IsBodyHtml = true;
            smtp.Send(msg);
        }
    }
}
