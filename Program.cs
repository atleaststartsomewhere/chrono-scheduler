using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security;

namespace ChronoDrop
{
    public class Program
    {
        public static void Main()
        {
            // init stuff
            PersonFactory.Initialize();
            // program logic
            var scheduler = new ChronoScheduler();

            var parcels = GenerateParcels(10);

            foreach (var parcel in parcels)
            {
                scheduler.ScheduleParcel(parcel);
            }

            var loggedParcels = scheduler.GetDeliveryLogs();
            if (loggedParcels.Count > 0)
            {
                foreach (var log in scheduler.GetDeliveryLogs())
                {
                    Console.WriteLine($"{log.TrackingId} | From: {log.Sender.Name} To: {log.Recipient.Name} | Departure: {log.DepartureTime} Arrival: {log.ArrivalTime} | Safe: {log.IsDeliverySafe}");
                }
            }

            var paradoxParcels = scheduler.GetParadoxParcels();
            if (paradoxParcels.Count > 0)
            {
                Console.WriteLine("\n=== PARADOX DETECTED ===");
                foreach (var paradox in scheduler.GetParadoxParcels())
                {
                    Console.WriteLine($"{paradox.TrackingId} caused a paradox.");
                }
            }
        }


        static List<Parcel> GenerateParcels(int parcelGenerationCount)
        {
            var generatedParcels = new List<Parcel>();
            for (int i = 0; i < parcelGenerationCount; i++)
            {
                generatedParcels.Add(ParcelFactory.GenerateParcel());
            }

            return generatedParcels;
        }
    }
}
