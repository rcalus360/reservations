namespace Reservations.Data.Db
{
    using Reservations.Data.Entities;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation of database for the purposes of test solution (we don't want to test "real" db access).
    /// It's a simple set of dictionaries (faster access and primary key constraint "simulation") 
    /// containing entity's entries. It's registered as a singleton,
    /// which is just about perfect concerning it's not a "real" database. 
    /// </summary>
    public class InMemoryDatabase : IDatabase
    {
        public IDictionary<int, Reservation> Reservations { get; private set; }
        public IDictionary<int, Lecturer> Lecturers { get; private set; }
        public IDictionary<int, LectureHall> LectureHalls { get; private set; }

        public InMemoryDatabase()
        {
            Reservations = new ConcurrentDictionary<int, Reservation>();
            Lecturers = new ConcurrentDictionary<int, Lecturer>();
            LectureHalls = new ConcurrentDictionary<int, LectureHall>();
        }

        public InMemoryDatabase(IDictionary<int, Reservation> reservations, IDictionary<int, Lecturer> lecturers,
            IDictionary<int, LectureHall> lectureHalls)
        {
            Reservations = reservations;
            Lecturers = lecturers;
            LectureHalls = lectureHalls;
        }

    }
}