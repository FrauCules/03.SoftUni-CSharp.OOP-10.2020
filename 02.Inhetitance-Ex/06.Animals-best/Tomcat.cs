namespace Animals
{
    public class Tomcat :Cat
    {
        private const string FedaultGender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, FedaultGender)
        {
        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
