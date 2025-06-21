class Parcel
{
    /// <summary>
    /// A unique identifier.
    /// </summary>
    public string? TrackingId { get; set; }

    /// <summary>
    /// The person who is sending the parcel.
    /// </summary>
    public Person? Sender { get; set; }

    /// <summary>
    /// The person who is receiving the parcel.
    /// </summary>
    public Person? Recipient { get; set; }

    /// <summary>
    /// The time the parcel will arrive.
    /// </summary>
    public DateTime ArrivalTime { get; set; }

    /// <summary>
    /// The time the parcel will leave.
    /// </summary>
    public DateTime DepartureTime { get; set; }
}
