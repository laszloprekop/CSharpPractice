using Microsoft.AspNetCore.Mvc;

namespace PolisIncidentMap.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IncidentsController : ControllerBase
{
    private const string PolisApUrl = "https://polisen.se/api/events";

    private readonly HttpClient _httpClient;

    public IncidentsController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet]
    public async Task<IActionResult> GetIncidents()
    {
        var response = await _httpClient.GetAsync(PolisApUrl);

        if (!response.IsSuccessStatusCode)
            return StatusCode((int)response.StatusCode, "Failed to fetch incidents from Polisen API");
        
        var json = await response.Content.ReadAsStringAsync();
        return Content(json, "application/json");
    }
}