namespace Reservations.Data.Db
{
    using Reservations.Data.Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Interfase for database representation - for the purposes of this test solution 
    /// it should just expose entity's collections
    /// </summary>
    public interface IDatabase
    {
        IDictionary<int, Reservation> Reservations { get; }
        IDictionary<int, Lecturer> Lecturers { get; }
        IDictionary<int, LectureHall> LectureHalls { get; }
    }
}
