namespace ClassLibrary1
{
    public class Banco
    {
        readonly string Conexao = "Data Source=127.0.0.1;Initial Catalog=Persist;User id=sa;Password=SqlServer2019!; TrustServerCertificate=true;";

        public Banco()
        {
        }
        public string Caminho()
        {
            return Conexao;
        }
    }
}
