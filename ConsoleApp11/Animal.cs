public class Animal 
    {

        private int _id;
        private string _form;
        private string _breed;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Form
        {
            get { return _form; }
            set { _form = value; }
        }
        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }
        public Animal(int id,string form, string breed)
        {
            Id = id;
            Form = form;
            Breed = breed;
            
        }
    
  
    }
