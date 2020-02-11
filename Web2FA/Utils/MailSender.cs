using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Web2FA.Utils
{
    public class MailSender
    {
		private IConfiguration _config;
		public MailSender(IConfiguration config)
		{
			_config = config;
		}

        public void SendMail(string code)
        {
			try
			{
				MailMessage message = new MailMessage();
				SmtpClient smtp = new SmtpClient();
				message.From = new MailAddress("ashok_kottagundu@epam.com");
				message.To.Add(new MailAddress("ashok_kottagundu@epam.com"));
				message.Subject = $"Your authentication code: {code}";
				message.IsBodyHtml = true;
				message.Body = $"Please use authentication code: {code} to authenticate yourself";
				smtp.Port = 111; // TODO: Replace with the right one
				smtp.Host = "abc.xyz.def"; //MYTODO: Replace with the right one.
				smtp.EnableSsl = true;
				smtp.UseDefaultCredentials = false;
				smtp.Credentials = new NetworkCredential("right_username", _config["Password"]);
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtp.Send(message);
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
