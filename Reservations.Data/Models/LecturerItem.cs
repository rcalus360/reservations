namespace Reservations.Data.Models
{
    /// <summary>
    /// View model used for presenting lecturer item (dedicated for external web communication)
    /// </summary>
    public class LecturerItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Subject { get; set; }
    }
}