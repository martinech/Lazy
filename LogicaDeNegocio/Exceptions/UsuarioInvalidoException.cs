namespace LogicaDeNegocio.Exceptions
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException() { }
        public UsuarioInvalidoException(string message) : base(message) { }
    }
}
