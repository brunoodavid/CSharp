public class ByteBankExceptions : Exception
{

    public ByteBankExceptions(string message) : base($"Aconteceu uma Exceção -> {message}") { }
}