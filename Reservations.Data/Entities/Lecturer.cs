namespace Reservations.Data.Entities
{
    /// <summary>
    /// Database entity for lecturer
    /// </summary>
    public class Lecturer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}