namespace dotnet_3.Models
{
    public class PersonList
    {
        public List<string> list = new List<string>();
        
        public void Add(Person newPerson)
        {
            list.Add(newPerson.Name + ", " + newPerson.Year + " " + newPerson.Result);
        }
    }
}
