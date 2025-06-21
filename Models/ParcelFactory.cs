using System.Reflection.Metadata.Ecma335;

class ParcelFactory
{
    static int TrackingIdBase = 1000;
    static int ParcelsGenerated = 0;
    static string TrackingIdFormat = "PKG-{0}";
    static DateTime MinimumDate = new DateTime(2040, 1, 1, 0, 0, 0);
    static DateTime MaximumDate = new DateTime(3040, 12, 31, 23, 59, 59);

    public static Parcel GenerateParcel()
    {
        var newParcel = new Parcel();
        var rand = new Random();
        newParcel.TrackingId = String.Format(TrackingIdFormat, TrackingIdBase + ParcelsGenerated);

        var senderName = PersonFactory.GetRandomName();
        var recipientName = PersonFactory.GetRandomName();

        newParcel.Sender = new Person(senderName);
        newParcel.Recipient = new Person(recipientName);

        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        long minDateSinceEpoch = (long)(MinimumDate - epoch).TotalSeconds;
        long maxDateSinceEpoch = (long)(MaximumDate - epoch).TotalSeconds;
        int range = (int)(maxDateSinceEpoch - minDateSinceEpoch);

        long arrivalTime = rand.Next(0, range);
        newParcel.ArrivalTime = MinimumDate.AddSeconds(arrivalTime);
        long departTime = rand.Next(0, range);
        newParcel.DepartureTime = MinimumDate.AddSeconds(departTime);

        ParcelsGenerated++;
        return newParcel;
    }
}