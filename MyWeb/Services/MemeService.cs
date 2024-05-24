using MyWeb.Models;
 
namespace MyWeb.Services;
 
public class MemeService
{
    private string url = "https://memes.tw/wtf/api";
     
    public async Task<List<MemeModel>> List()
    {
        List<MemeModel> result = new List<MemeModel>();
         
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<List<MemeModel>>();
            }
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }
        
        return result;
    }
}