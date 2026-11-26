public class Sells
    {
        private int _id;
        private int _idAnimal;
        private int _idCustomer;
        private DateTime _date;
        private decimal _money;

        public int Id
        {
            get { return _id; } 
            set { _id = value; }
        }
        public int IdAnimal
        {
            get { return _idAnimal; }
            set { _idAnimal = value; }
        }
        public int IdCustomer
        {
            get;set;
        }
        public DateTime Date
        {
            get;set;
        }
        public decimal Money
        {
            get;set;
        }
        public Sells(int id,int idAnimal, int idCustomer, DateTime date, decimal money)
        {
            Id = id;
            IdAnimal = idAnimal;
            IdCustomer = idCustomer;
            Date = date;
            Money = money;
        }

      
    }
