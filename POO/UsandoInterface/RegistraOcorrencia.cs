namespace UsandoInterface;

public class RegistraOcorrencia
{
    private readonly IRegistro _registro;

    public RegistraOcorrencia(IRegistro registro)
    {
        _registro = registro;
    }

    public void Registrar(string mensage)
    {
        _registro.RegistraInfo(mensage);
    }
}
