# PolisIncidentMap — Backend

ASP.NET Core Web API (.NET 10). Acts as a proxy for the Polisen public API,
avoiding CORS issues in the browser.

## Endpoint

`GET /api/incidents` — returns the full list of current police incidents as JSON.

## Running locally

```bash
dotnet run
```

API will be available at `http://localhost:5116/api/incidents`.

## Configuration

| Variable | Description |
|---|---|
| `Cors__AllowedOrigin` | Frontend URL allowed to call this API |