using System.Text;
using ByteBankIO;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {

            var numeroDeBytesLidos = -1;


            var buffer = new byte[1024]; // 1KB



            // public override int Read(byte[] array, int offset, int count);
            // fluxoDoArquivo.Read(buffer, 0, buffer.Length);
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }
        }


    }
    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        // foreach (var meuByte in buffer)
        // {
        //     Console.Write($"{meuByte} ");
        // }
    }
}