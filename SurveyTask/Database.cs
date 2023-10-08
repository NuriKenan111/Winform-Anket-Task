using System.Text.Json;

namespace SurveyTask;

internal class Database
{

    List<Person> person = new List<Person>();
    public List<Person> GetPerson() => person;

    public Database() { 
        LoadDataFromJson();
    }

    public void AddPerson(Person _person)
    {
        ClearPersonJsonFile();
        person.Add(_person);
        UpdatePersonJsonFile();
    }
    public void LoadDataFromJson()
    {
        LoadDataFromFile("Person.json", out person);
    }
    public void ClearPersonJsonFile() => File.WriteAllText("Person.json", string.Empty);

    public void UpdatePersonJsonFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(person, options);
        File.WriteAllText("Person.json", jsonString);
    }

    private void LoadDataFromFile<T>(string fileName, out List<T> dataList)
    {
        dataList = new List<T>();
        if (File.Exists(fileName))
        {
            string jsonData = File.ReadAllText(fileName);
            try
            {
                if (!string.IsNullOrEmpty(jsonData))
                {
                    dataList = JsonSerializer.Deserialize<List<T>>(jsonData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("JSON Deserialize Error: " + ex.Message);
                Console.ReadLine();
            }
        }
    }

}
