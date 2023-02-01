namespace BookingSystem
{
    public class Person
    {
        //skapar unikt id, namn, efternamn
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }

        public Person(string firstName, string lastName, int id)
        
        {
            Id= id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
