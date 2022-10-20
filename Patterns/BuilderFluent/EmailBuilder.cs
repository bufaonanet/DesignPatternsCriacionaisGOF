namespace BuilderFluent;

//Builder
public class EmailBuilder
{
    private readonly Email _email;
	public EmailBuilder()
	{
		_email = new Email();
	}

	public EmailBuilder To(string to)
	{
		_email.To = to;
		return this;
	}

    public EmailBuilder From(string from)
    {
        _email.From = from;
        return this;
    }

    public EmailBuilder Subject(string subject)
    {
        _email.Subject = subject;
        return this;
    }

    public EmailBuilder Body(string body)
    {
        _email.Body = body;
        return this;
    }

    public Email BuildEmail()
    {
        return _email;  
    }
}
