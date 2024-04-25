namespace Store;

public interface IStore
{
    public void GetFile();
    public Task GetFileAsync();
    public void SaveFile();
    public Task SaveFileAsync();
}