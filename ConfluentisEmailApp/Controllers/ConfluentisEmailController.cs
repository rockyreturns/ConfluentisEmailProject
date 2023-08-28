using EmailManager;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace ConfluentisEmailApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfluentisEmailController : ControllerBase
    {

        private readonly ILogger<ConfluentisEmailController> _logger;
        private readonly IEmailService _emailService;

        public ConfluentisEmailController(ILogger<ConfluentisEmailController> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        [HttpGet(Name = "GetEmail")]
        public string Get()
        {
            return "Hello Email";
        }

        [HttpPost(Name = "SendEmail")]
        public IActionResult SendEmail(EmailModel emailModel) 
        {
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("alexane.emard@ethereal.email"));
            //email.To.Add(MailboxAddress.Parse("alexane.emard@ethereal.email"));
            //email.Subject = "Test Email";
            //email.Body = new TextPart(TextFormat.Html) { Text = emailBody };

            //using var smtp = new SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            //smtp.Authenticate("alexane.emard@ethereal.email", "bgShcFjWXsTnJkW8Rt");
            //smtp.Send(email);
            //smtp.Disconnect(true);
            _emailService.SendEmail(emailModel);
            return Ok();
        }

        private bool IsEmailSetUp(EmailModel emailModel) 
        { 
            return true;
            // If my configuration is ready
        }
    }
}