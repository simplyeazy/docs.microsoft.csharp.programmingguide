using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using FluentEmail.Core;
using FluentEmail.Smtp;

namespace Mailer
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Email
                .From("edc.monitoring.cimb@gmail.com","edc mon")
                .To("simplyeazy@gmail.com", "simply")
                .Subject("hows it going bob")
                .Body("yo dawg, sup?");
            email.Sender=new SmtpSender(new SmtpClient());
            //send normally
            email.Send();
        }
    }
}
