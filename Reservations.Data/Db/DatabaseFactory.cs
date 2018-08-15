namespace Reservations.Data.Db
{
    using Reservations.Data.Entities;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// Responsible for db creation and filling it with initial sample data 
    /// </summary>
    public static class DatabaseFactory
    {
        private static IDictionary<int, Reservation> Reservations;
        private static IDictionary<int, Lecturer> Lecturers;
        private static IDictionary<int, LectureHall> LectureHalls;

        public static IDatabase CreateDatabase()
        {
            SetInitialData();
            return new InMemoryDatabase(Reservations, Lecturers, LectureHalls);
        }

        private static void SetInitialData()
        {
            Reservations = new ConcurrentDictionary<int, Reservation>();
            Lecturers = new ConcurrentDictionary<int, Lecturer>();
            LectureHalls = new ConcurrentDictionary<int, LectureHall>();

            // Lecture Halls

            var lh101 = new LectureHall
            {
                Number = 101,
                Capacity = 100
            };

            var lh102 = new LectureHall
            {
                Number = 102,
                Capacity = 200
            };

            var lh105 = new LectureHall
            {
                Number = 105,
                Capacity = 30
            };

            var lh108 = new LectureHall
            {
                Number = 108,
                Capacity = 100
            };

            var lh201 = new LectureHall
            {
                Number = 201,
                Capacity = 200
            };

            var lh202 = new LectureHall
            {
                Number = 202,
                Capacity = 30
            };

            var lh210 = new LectureHall
            {
                Number = 210,
                Capacity = 30
            };

            var lh212 = new LectureHall
            {
                Number = 212,
                Capacity = 100
            };

            LectureHalls.Add(lh101.Number, lh101);
            LectureHalls.Add(lh102.Number, lh102);
            LectureHalls.Add(lh105.Number, lh105);
            LectureHalls.Add(lh108.Number, lh108);
            LectureHalls.Add(lh201.Number, lh201);
            LectureHalls.Add(lh202.Number, lh202);
            LectureHalls.Add(lh210.Number, lh210);
            LectureHalls.Add(lh212.Number, lh212);


            // Lecturers

            var l1 = new Lecturer()
            {
                Id = 1,
                Name = "John",
                Surname = "Nash",
                Title = "prof. ",
            };

            var l2 = new Lecturer()
            {
                Id = 2,
                Name = "Steve",
                Surname = "Wozniak",
                Title = "dr ",
            };

            var l3 = new Lecturer()
            {
                Id = 3,
                Name = "Jim",
                Surname = "Morrisson",
                Title = "prof. ",
            };

            var l4 = new Lecturer()
            {
                Id = 4,
                Name = "Ronnie",
                Surname = "O'Sullivan",
                Title = "prof. ",
            };

            var l5 = new Lecturer()
            {
                Id = 5,
                Name = "James",
                Surname = "Milner",
                Title = string.Empty
            };

            var l6 = new Lecturer()
            {
                Id = 6,
                Name = "Roger",
                Surname = "Schmidt",
                Title = "prof. "
            };

            var l7 = new Lecturer()
            {
                Id = 7,
                Name = "Julian",
                Surname = "Archibald",
                Title = "dr "
            };

            var l8 = new Lecturer()
            {
                Id = 8,
                Name = "Christian",
                Surname = "Vogelsang",
                Title = string.Empty
            };

            Lecturers.Add(l1.Id, l1);
            Lecturers.Add(l2.Id, l2);
            Lecturers.Add(l3.Id, l3);
            Lecturers.Add(l4.Id, l4);
            Lecturers.Add(l5.Id, l5);
            Lecturers.Add(l6.Id, l6);
            Lecturers.Add(l7.Id, l7);
            Lecturers.Add(l8.Id, l8);


            // Reservations

            var r1 = new Reservation
            {
                Id = 1,
                From = new DateTime(2015, 1, 2, 8, 0, 0),
                To = new DateTime(2015, 1, 2, 8, 0, 0).AddHours(2),
                Hall = lh202,
                Lecturer = l5
            };

            var r2 = new Reservation
            {
                Id = 2,
                From = new DateTime(2015, 1, 2, 12, 0, 0),
                To = new DateTime(2015, 1, 2, 12, 0, 0).AddHours(1),
                Hall = lh202,
                Lecturer = l2
            };

            var r3 = new Reservation
            {
                Id = 3,
                From = new DateTime(2015, 1, 5, 15, 0, 0),
                To = new DateTime(2015, 1, 5, 15, 0, 0).AddHours(2),
                Hall = lh105,
                Lecturer = l8
            };

            Reservations.Add(r1.Id, r1);
            Reservations.Add(r2.Id, r2);
            Reservations.Add(r3.Id, r3);
        }
    }
}