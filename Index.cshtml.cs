using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ale.Pages
{
    public class IndexModel : PageModel

    {

    

        private readonly ILogger<IndexModel> _logger;

    

        public IndexModel(ILogger<IndexModel> logger)

        {

            _logger = logger;

        }

    

        public void OnGet()

        {




        }

         public void OnPost(string email)

        {

            var smtp = new System.Net.Mail.SmtpClient();

            smtp.Port = 587;

            smtp.EnableSsl = true;

            smtp.Host = "smtp.office365.com";  //smtp.office365.com

            smtp.Credentials = new System.Net.NetworkCredential("perla.soriano@my.unitec.edu.mx", "18338822");



            var mail = new System.Net.Mail.MailMessage();

            mail.To.Add(email);

            mail.Subject = "Los mejores postres";

            mail.Body = $"<h1>Para mas recetas de postres deliciosas</h1>";

            mail.IsBodyHtml = true;

            mail.From = new System.Net.Mail.MailAddress("perla.soriano@my.unitec.edu.mx", "Los mejores postres");

            smtp.Send(mail);

        }

    }

}
