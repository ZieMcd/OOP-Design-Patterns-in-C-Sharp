namespace Proxy;

public class DataServiceProxy : IDataService
{
    private readonly DataService _dataService;
    private List<string>? _localCache;

    public DataServiceProxy()
    {
        _dataService = new DataService();
        _localCache = null;
    }

    public async Task<List<string>> GetDate()
    {
        if (_localCache is null)
            _localCache = await _dataService.GetDate();

        return _localCache;
    }

    public void InsertData(string item)
    {
        _localCache = null;
        _dataService.InsertData(item);
    }
}