using Microsoft.AspNetCore.Identity.UI.Services;

namespace TaskManagement.Web.Areas.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(ILogger<EmailSender> logger)
        {
            _logger = logger;
        }

        public Task SendEmailAsync(string email, string subject, string htmlmessage)
        {
            // For development - log the email instead of sending
            _logger.LogInformation("Email would be sent to {Email}", email);
            _logger.LogInformation("Subject: {Subject}", subject);
            _logger.LogInformation("Message: {Message}", htmlmessage);

            // In production, implement actual email sending here
            // Examples: SendGrid, SMTP, Azure Communication Services, etc.

            return Task.CompletedTask;
        }
    }
}
