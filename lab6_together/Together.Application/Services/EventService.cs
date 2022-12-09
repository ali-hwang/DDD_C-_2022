namespace Together.Application.Services;
public class EventService : IEventService
{
    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        throw new NotImplementedException();
    }

    public EventQueryResult[] query(float lat, float lng, float len)
    {
        throw new NotImplementedException();
    }
}