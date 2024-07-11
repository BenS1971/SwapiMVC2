using Microsoft.AspNetCore.Mvc;
using SwapiMVC2.Models;

namespace SwapiMVC2.Controllers;

public class PeopleController : Controller
{
    private readonly HttpClient _httpClient;
    public PeopleController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("swapi");
       
    }
    public async Task<IActionResult> Index([FromQuery] string page)
    {
        string route = $"people?page={page ?? "1"}";
        HttpResponseMessage response = await _httpClient.GetAsync(route);
        
        var viewModel = await response.Content.ReadFromJsonAsync<ResultsViewModel<PeopleViewModel>>();

        return View(viewModel);
    }
}