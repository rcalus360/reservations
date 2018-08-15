namespace Reservations.Data.Entities
{
    using System;

    /// <summary>
    /// Database entity for reservation
    /// </summary>
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public virtual LectureHall Hall { get; set; }
        public virtual Lecturer Lecturer { get; set; }
    }
}