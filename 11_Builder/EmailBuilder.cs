public class EmailBuilder : IEmailBuilder
{
    private Email _email;
    public EmailBuilder()
    {
        _email = new Email();
    }

    public IEmailBuilder Anexo(string fileName)
    {
        _email.Anexo = fileName;
        return this;
    }

    public IEmailBuilder Body(string content)
    {
        _email.Body = content;
        return this;
    }

    public Email Build()
    {
        return _email;
    }

    public IEmailBuilder From(string address)
    {
        _email.From = address;
        return this;
    }

    public IEmailBuilder Subject(string subject)
    {
        _email.Subject = subject;
        return this;
    }

    public IEmailBuilder To(string address)
    {
        _email.To = address;
        return this;
    }
}
