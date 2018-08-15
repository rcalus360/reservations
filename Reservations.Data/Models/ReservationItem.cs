namespace Reservations.Data.Models
{
    using System;

    /// <summary>
    /// View model used for presenting reservation item (dedicated for external web communication)
    /// </summary>
    public class ReservationItem
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int LectureHallNumber { get; set; }
        public string Lecturer { get; set; }
    }
}