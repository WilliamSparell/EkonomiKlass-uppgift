namespace EkonomiKlass_uppgift
{ 
    public class Account
    {
        private string label;
        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        public int Number { get; set; } =  0;
        public double debit { get; set; } =  0;
        public double credit { get; set; } = 0;
    }

   
}