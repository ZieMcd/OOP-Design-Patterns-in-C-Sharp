namespace Proxy;

public class DataService : IDataService
{
    private readonly List<string> _fakeDataStore;

    public DataService()
    {
        _fakeDataStore = new();
    }

    public async Task<List<string>> GetDate()
    {
        await Task.Delay(3000);
        return _fakeDataStore;
    }

    public void InsertData(string item)
    {
        _fakeDataStore.Add(item);
    }
}