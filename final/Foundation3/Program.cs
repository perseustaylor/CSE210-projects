using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("223 Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("623 Park St", "New York", "NY", "USA");
        Address address3 = new Address("4 Treadle St", "Takoradi", "TA", "Ghana");

        Lecture lecture = new Lecture(
            "The Future of Robotics",
            "An in-depth look at the advancements in Robotics.",
            "2024-09-15",
            "10:00 AM",
            address1,
            "Dr. Jane Smith",
            150);

        Reception reception = new Reception(
            "Wedding Reception",
            "A formal gathering to celebrate Brother and Sister.",
            "2024-10-20",
            "7:00 PM",
            address2,
            "perseustaylor@assignment.org");

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Elder's Quorum Picnic",
            "A fun outdoor picnic for the Elder's Quorum.",
            "2024-08-05",   
            "12:00 PM",
            address3,
            "Cloudy with a chance of meatballs");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach(Event evt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("------------------------------");
        
        }
    }   
}