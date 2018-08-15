namespace Reservations.Data.Models
{
    using System;

    /// <summary>
    /// View model used for adding new reservation item (dedicated for external web communication)
    /// </summary>
    public class NewReservationItem
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int LectureHallNumber { get; set; }
        public int LecturerId { get; set; }
    }
}