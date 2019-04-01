using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndroidAPI
{
    public class GymContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:andoidapp.database.windows.net,1433;Initial Catalog=AndoidApp;Persist Security Info=False;User ID=androidapp;Password=Tallaght1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
    }

    public class GymRepository
    {

        // print trainer and their timeslots
        public List<Trainer> DoTrainerQuery()
        {
            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach(var trainer in trainers)
                {
                    trainerList.Add(trainer);

                   
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }
        }

       
        public void AddTrainer(Trainer trainer)
        {
            using (GymContext db = new GymContext())
            {
                try
                {
                    // add and save
                    db.Trainers.Add(trainer);
                    db.SaveChanges();
                    // navigation properties updated on both sides
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        
        public void AddTimeslot(TimeSlot slot)
        {
            using (GymContext db = new GymContext())
            {
                try
                {
                    // add and save
                    db.TimeSlots.Add(slot);
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        //class Program
        //{
        //    static void Main()
        //    {
        //        GymRepository repository = new GymRepository();



        //        

        //        Console.ReadLine();

        //        
        //    }
        //}
    }
}

