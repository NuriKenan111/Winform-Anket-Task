namespace SurveyTask;

internal class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public DateTime Datetime { get; set; }
    public string Email { get; set; }
    public bool MilitaryStatus { get; set; }
    public string Gender { get; set; }
    public Person()
    {
        
    }
    public Person(string name,string surname,string country,string city,DateTime date,string email,bool militaryStat,string gender)
    {
        Name = name;
        Surname = surname;
        Country = country;
        City = city;
        Datetime = date;
        Email = email;
        MilitaryStatus = militaryStat;
        Gender = gender;
    }
}
