namespace LibCSharp9Demo.Models
{
    public record Member
    {
        public string LastName;
        public string FirstName;

        public Member( string firstName , string lastName ) => (FirstName, LastName) = (firstName, lastName);

        public void Deconstruct( out string firstName , out string lastName )
            => (firstName, lastName) = (FirstName, LastName);
    }
}
