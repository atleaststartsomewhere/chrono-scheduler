class TimeDeliveryLog
{
    public string TrackingId { get; set; }
    public Person Sender { get; set; }
    public Person Recipient { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public bool IsDeliverySafe { get; set; }
}
