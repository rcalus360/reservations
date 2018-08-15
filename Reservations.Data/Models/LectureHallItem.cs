namespace Reservations.Data.Models
{
    /// <summary>
    /// View model used for presenting lecture hall item (dedicated for external web communication)
    /// </summary>
    public class LectureHallItem
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
    }
}