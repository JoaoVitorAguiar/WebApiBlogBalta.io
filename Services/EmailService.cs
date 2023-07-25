using System.Net;
using System.Net.Mail;

namespace Blog.Services;

public class EmailService
{
    public bool Send(
        string toName, // Nome do destinatario
        string toEmail, 
        string subject, // Assunto
        string body, // Corpo do email
        string fromName = "Equipe Vitor Aguiar",
        string fromEmail = "joaovitor4guiar@gmail.com"
        )
    {
        var smtpClient = new SmtpClient(Configuration.Smtp.Host, Configuration.Smtp.Port);
        
        // Senha
        smtpClient.Credentials = new NetworkCredential(Configuration.Smtp.UserName, Configuration.Smtp.Password);
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.EnableSsl = true;

        // Mensagem de email
        var mail = new MailMessage();

        mail.From = new MailAddress(fromEmail, fromName);
        mail.To.Add(new MailAddress(toEmail, toName)); // Isso é uma lista
        // Ou seja, pode-se andar para mais de uma pessoa (cliente)
        mail.Subject = subject;
        mail.Body = body;
        mail.IsBodyHtml = true;  // Pode-se  botar tags html no corpo

        // Enviar email
        try
        {
            smtpClient.Send(mail);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
