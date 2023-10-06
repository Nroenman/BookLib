namespace BookLib
{
    public class Book
    {
        public int Id { get; set; }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("Der skal være 3 bogstaver i din tittel");
                }
                if (_title != null)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("Der skal være en tittel");
                }
            }
        }

            
        public double Pris { get; set; }
       

        public Book(int id, string title, double pris)
        {
            Id = id;
            Title = title;
            Pris = pris;
        }

        public Book()
        {

        }


        public override string ToString()
        {
            return $"Pris:{Pris}";
        }

       
       
        
        






    }

}