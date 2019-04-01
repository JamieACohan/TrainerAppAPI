using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AndroidAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GymController : ControllerBase
    {
       

        // GET: /all
        //Return all Trainers and their realted timeslots
        [HttpGet("all")]
        public List<Trainer> GetAll()
        {
            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    trainerList.Add(trainer);
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }

        }

        // GET: /all
        //Return all timeslots and trainer
        [HttpGet("allTimeslots")]
        public List<TimeSlot> GetTimeSlots()
        {

            using (GymContext db = new GymContext())
            {
                List<TimeSlot> timeslotList = new List<TimeSlot>();
                var timeslots = db.TimeSlots.OrderBy(l => l.ID).Select(l => new TimeSlot { TrainerId = l.TrainerId, ID = l.ID, Day = l.Day, Time = l.Time, Location = l.Location});

                foreach (var timeslot in timeslots)
                {
                    timeslotList.Add(timeslot);


                }
                Console.WriteLine("\nTimeslots:");
                return timeslotList;

            }
        }

        [HttpGet("trainerByLocation")]
        public List<Trainer> GetTrainerByLocation(string location)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    var trainerTimeslots = trainer.Timeslots;
                    foreach (var trainerTimeslot in trainerTimeslots)
                    {
                       if(trainerTimeslot.Location.ToUpper() == location.ToUpper())
                        {
                            trainerList.Add(trainer);
                        }
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByName")]
        public List<Trainer> GetTrainerByName(string name)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                  if(trainer.TrainerName.ToUpper() == name.ToUpper())
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByRating")]
        public List<Trainer> GetTrainerByRating(double rating)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    if (trainer.Rating >= rating)
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByGender")]
        public List<Trainer> GetTrainerByGender(string gender)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    if (trainer.Gender.ToUpper() == gender.ToUpper())
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByPrice")]
        public List<Trainer> GetTrainerByPrice(double price)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    if (trainer.Price <= price)
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByEmail")]
        public List<Trainer> GetTrainerByEmail(string email)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    if (trainer.Email.ToUpper() == email.ToUpper())
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByPhone")]
        public List<Trainer> GetTrainerByPhone(string phone)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    if (trainer.Phone == phone)
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByID")]
        public List<Trainer> GetTrainerByID(int id)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    if (trainer.ID == id)
                    {
                        trainerList.Add(trainer);
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        
        [HttpGet("trainerByTimeslot")]
        public List<Trainer> GetTrainerByTimeslot(string day, string time)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    var trainerTimeslots = trainer.Timeslots;
                    foreach (var trainerTimeslot in trainerTimeslots)
                    {
                        if (trainerTimeslot.Day.ToUpper() == day.ToUpper() && trainerTimeslot.Time.ToUpper() == time.ToUpper())
                        {
                            trainerList.Add(trainer);
                        }
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }
        
        [HttpGet("trainerByDay")]
        public List<Trainer> GetTrainerByDay(string day)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    var trainerTimeslots = trainer.Timeslots;
                    foreach (var trainerTimeslot in trainerTimeslots)
                    {
                        if (trainerTimeslot.Day.ToUpper() == day.ToUpper())
                        {
                            trainerList.Add(trainer);
                        }
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

        [HttpGet("trainerByTime")]
        public List<Trainer> GetTrainerByTime(string time)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.OrderBy(l => l.ID).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName, Phone = l.Phone, Rating = l.Rating, Email = l.Email, Gender = l.Gender, Price = l.Price, Timeslots = l.Timeslots });

                foreach (var trainer in trainers)
                {
                    var trainerTimeslots = trainer.Timeslots;
                    foreach (var trainerTimeslot in trainerTimeslots)
                    {
                        if (trainerTimeslot.Time.ToUpper() == time.ToUpper())
                        {
                            trainerList.Add(trainer);
                        }
                    }
                }


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }

       



        [HttpGet("trainerByIDTest")]
        public IEnumerable<Trainer> GetTrainerByIDTest(int i)
        {


            using (GymContext db = new GymContext())
            {
                List<Trainer> trainerList = new List<Trainer>();
                var trainers = db.Trainers.Where(l => l.ID == i).Select(l => new Trainer { ID = l.ID, TrainerName = l.TrainerName});

                foreach (var trainer in trainers)
                {
                   
                            trainerList.Add(trainer);
                        
                }
                


                Console.WriteLine("\nTrainers:");
                return trainerList;
            }


        }



        [HttpGet("timeslotByLocation")]
        public List<TimeSlot> GetTimeslotByLocation(string location)
        {



            using (GymContext db = new GymContext())
            {
                List<TimeSlot> timeslotList = new List<TimeSlot>();
                var timeslots = db.TimeSlots.OrderBy(l => l.ID).Select(l => new TimeSlot { TrainerId = l.TrainerId, ID = l.ID, Day = l.Day, Time = l.Time, Location = l.Location });

                foreach (var timeslot in timeslots)
                {

                    if (timeslot.Location.ToUpper() == location.ToUpper())
                    {
                        timeslotList.Add(timeslot);
                    }

                }
                Console.WriteLine("\nTimeslots:");
                return timeslotList;

            }


        }

        [HttpGet("timeslotByTime")]
        public List<TimeSlot> GetTimeslotByTime(string time)
        {



            using (GymContext db = new GymContext())
            {
                List<TimeSlot> timeslotList = new List<TimeSlot>();
                var timeslots = db.TimeSlots.OrderBy(l => l.ID).Select(l => new TimeSlot { TrainerId = l.TrainerId, ID = l.ID, Day = l.Day, Time = l.Time, Location = l.Location });

                foreach (var timeslot in timeslots)
                {

                    if (timeslot.Time.ToUpper() == time.ToUpper())
                    {
                        timeslotList.Add(timeslot);
                    }

                }
                Console.WriteLine("\nTimeslots:");
                return timeslotList;

            }


        }

        [HttpGet("timeslotByDay")]
        public List<TimeSlot> GetTimeslotByDay(string day)
        {



            using (GymContext db = new GymContext())
            {
                List<TimeSlot> timeslotList = new List<TimeSlot>();
                var timeslots = db.TimeSlots.OrderBy(l => l.ID).Select(l => new TimeSlot { TrainerId = l.TrainerId, ID = l.ID, Day = l.Day, Time = l.Time, Location = l.Location });

                foreach (var timeslot in timeslots)
                {

                    if (timeslot.Day.ToUpper() == day.ToUpper())
                    {
                        timeslotList.Add(timeslot);
                    }

                }
                Console.WriteLine("\nTimeslots:");
                return timeslotList;

            }


        }

        [HttpGet("timeslotByID")]
        public List<TimeSlot> GetTimeslotByID(int id)
        {



            using (GymContext db = new GymContext())
            {
                List<TimeSlot> timeslotList = new List<TimeSlot>();
                var timeslots = db.TimeSlots.OrderBy(l => l.ID).Select(l => new TimeSlot { TrainerId = l.TrainerId, ID = l.ID, Day = l.Day, Time = l.Time, Location = l.Location });

                foreach (var timeslot in timeslots)
                {

                    if (timeslot.TrainerId == id)
                    {
                        timeslotList.Add(timeslot);
                    }

                }
                Console.WriteLine("\nTimeslots:");
                return timeslotList;

            }


        }


    }
}

        