namespace Lab4_ex1
{
    public class Student: Person
    {
        public string program { get; set; }

        public Student(string fullname, string phone, string email,string program) : base(fullname, phone, email)
        {
            this.program = program;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}