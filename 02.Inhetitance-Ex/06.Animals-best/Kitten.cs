namespace Animals
{
   public class Kitten : Cat
    {
        private const string FefaultGender = "Female";
        public Kitten(string name, int age) 
            : base(name, age, FefaultGender)
        {
        }
       
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
