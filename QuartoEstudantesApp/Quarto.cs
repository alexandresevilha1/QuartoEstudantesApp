namespace QuartoEstudantesApp
{
    public class Quarto
    {
        private int _numeroQuarto;
        public string Nome;
        public string Email;

        public Quarto (int numeroQuarto, string nome, string email )
        {
            _numeroQuarto = numeroQuarto;
            Nome = nome;
            Email = email;

        }

        public int NumeroQuarto 
        {
            get { return _numeroQuarto; }
            set 
            {
                if ( value != null && value > 0 && value <= 10 )
                {
                    _numeroQuarto = value;
                }
            }
        }

        public override string ToString()
        {
            return "Quarto " + _numeroQuarto + ": " + Nome + ", " + Email;
        }

    }
}
