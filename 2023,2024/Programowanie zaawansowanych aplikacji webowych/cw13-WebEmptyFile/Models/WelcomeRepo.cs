namespace WebEmptyFile.Models
{
    public class WelcomeRepo
    {
        public static void SaveToFile(Person? person, string path = "dane.txt") {
            File.AppendAllText(path,person?.ToString()+Environment.NewLine);
        }

        public static List<Person> AllFromFile(string path = "dane.txt") {
            List<Person> persons = new List<Person>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines) {
                var data = line.Split('|');
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                if (data.Length == 5) {
                    var temp = data[4].Split('.');
                    if (temp.Length == 3) {
                        year = Convert.ToInt32(temp[2]);
                        month = Convert.ToInt32(temp[1]);
                        day = Convert.ToInt32(temp[0]);
                    }
                    persons.Add(new Person {
                        Id = data[0],
                        Firstname = data[1],
                        Lastname = data[2],
                        Content = data[3],
                        PartyDate = new DateOnly(year, month, day)
                    });
                }
            }
            return persons;
        }

        public static void SaveAllToFile(List<Person> persons) {
            var lines = new List<string>();
            foreach (var person in persons) {
                lines.Add(person.ToString());
            }
            File.WriteAllLines("dane.txt",lines);
        }
    }
}
