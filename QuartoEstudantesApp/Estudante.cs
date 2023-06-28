namespace QuartoEstudantesApp
{
    public class Estudante
    {
        private string _nome;
        private string _email;

        public Estudante(string nome, string email)
        {
            _nome = nome;
            _email = email;
        }

        public string Nome
        {
            get { return _nome; } 
            set 
            { 
                if (value != null &&  value.Length > 5) 
                {
                    _nome = value;
                } 
            }
        }

        public string Email
        {
            get { return _email; }
            set 
            {
                if (value != null && value.Contains("@gmail.com"))
                {
                    _email = value;
                }
            }
        }
    }
}
