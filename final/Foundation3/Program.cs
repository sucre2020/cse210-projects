using System;

public class Address {
    private string street;
    private string city;
    private string state;
    private string zip;

    public Address(string street, string city, string state, string zip) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public override string ToString() {
        return $"{street}, {city}, {state} {zip}";
    }
}

public abstract class Event {
    private string title;
    private string description;
    private DateTime date;
    private DateTime time;
    private Address address;

    public Event(string title, string description, DateTime date, DateTime time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails() {
        return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address}\n";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription() {
        return $"{this.GetType().Name} - {title} - {date.ToShortDateString()}";
    }
}

public class Lecture : Event {
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails() {
        return $"Event: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}\n{GetStandardDetails()}";
    }
}

public class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail) : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails() {
        return $"Event: Reception\nRSVP Email: {rsvpEmail}\n{GetStandardDetails()}";
    }
}

public class PictureGathering : Event {
    private string weather;

    public PictureGathering(string title, string description, DateTime date, DateTime time, Address address, string weather) : base(title, description, date, time, address) {
        this.weather = weather;
    }

    public override string GetFullDetails() {
        return $"Event: Picture Gathering\nWeather: {weather}\n{GetStandardDetails()}";
    }
}

public class Program {
    public static void Main() {
        Console.Write("Welcome to the Event Planner!\n Enter the event street address: ");
        string street = Console.ReadLine();

        Console.Write("Enter the city: ");
        string city = Console.ReadLine();

        Console.Write("Enter the state: ");
        string state = Console.ReadLine();

        Console.Write("Enter the ZIP code: ");
        string zip = Console.ReadLine();

        Address address = new Address(street, city, state, zip);

        Console.Write("Enter the event type (Lecture/Reception/Picture Gathering): ");
        string eventType = Console.ReadLine();

        Console.Write("Enter the event title: ");
        string eventTitle = Console.ReadLine();

        Console.Write("Enter the event description: ");
        string eventDescription = Console.ReadLine();

        Console.Write("Enter the event date (YYYY-MM-DD): ");
        DateTime eventDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the event time (HH:MM AM/PM): ");
        DateTime eventTime = DateTime.Parse(Console.ReadLine());

        Event newEvent;

        switch (eventType.ToLower()) {
            case "lecture":
                Console.Write("Enter the speaker for the Lecture event: ");
                string speaker = Console.ReadLine();
                Console.Write("Enter the capacity for the Lecture event: ");
                int capacity = int.Parse(Console.ReadLine());
                newEvent = new Lecture(eventTitle, eventDescription, eventDate, eventTime, address, speaker, capacity);
                break;

            case "reception":
                Console.Write("Enter the RSVP email for the Reception event: ");
                string rsvpEmail = Console.ReadLine();
                newEvent = new Reception(eventTitle, eventDescription, eventDate, eventTime, address, rsvpEmail);
                break;

            case "picture gathering":
                Console.Write("Enter the expected weather for the Picture Gathering event: ");
                string weather = Console.ReadLine();
                newEvent = new PictureGathering(eventTitle, eventDescription, eventDate, eventTime, address, weather);
                break;

            default:
                Console.WriteLine($"Invalid event type: {eventType}");
                return;
        }

        Console.WriteLine(newEvent.GetFullDetails());
    }
}
