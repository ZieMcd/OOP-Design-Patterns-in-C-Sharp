namespace Proxy;

public interface IDataService
{
    Task<List<string>> GetDate();
    void InsertData(string item);
}