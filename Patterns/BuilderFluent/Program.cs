using BuilderFluent;

EmailBuilder emailBuilder = new();

emailBuilder
    .To("microsoft#email.com")
    .From("douglas.email@yahoo.com")
    .Subject("Teste de email")
    .Body("Este email foi enviado como teste");

var email = emailBuilder.BuildEmail();

Console.WriteLine(email.ToString());
Console.ReadLine();