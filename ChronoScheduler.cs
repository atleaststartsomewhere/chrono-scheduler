using System.Net.Http.Headers;

class ChronoScheduler
{
    public void ScheduleParcel(Parcel parcel)
    {
        Console.WriteLine($"Scheduled delivery to {parcel.Recipient.Name} on {parcel.DepartureTime}");
    }

    public List<TimeDeliveryLog> GetDeliveryLogs()
    {
        return new List<TimeDeliveryLog>();
    }

    public List<Parcel> GetParadoxParcels()
    {
        return new List<Parcel>();
    }
}