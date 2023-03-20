namespace LogIn.Data
{
    public class BaseDatos
    {
        public BaseDatos(string usuario) => _usuario = usuario;
        public string _usuario { get; }
    }
}