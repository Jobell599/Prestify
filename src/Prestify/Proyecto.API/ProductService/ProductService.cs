using Prestify.Web.Models;

namespace Proyecto.API.ProductService
public class ProductService
{ 

    private readonly HttpClient _http;

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Person>>
 GetProductsAsync()

    {
        return await _http.GetFromJsonAsync<List<Person>>("api/products");
    }


}
