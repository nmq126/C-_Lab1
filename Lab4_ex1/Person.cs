namespace Lab4_ex1
{
    public class Person
    {
        public string fullname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Person(string fullname, string phone, string email)
        {
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
        }

        public override string ToString()
        {
            return "Class name: " + GetType().Name + " Name: " + fullname + " Email: " + email;
        }
    }
}