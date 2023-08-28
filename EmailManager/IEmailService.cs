using ConfluentisEmailApp;

namespace EmailManager
{
    public interface IEmailService
    {        
        void SendEmail(EmailModel email);
    }
}
