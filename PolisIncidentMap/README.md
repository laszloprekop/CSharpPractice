# PolisIncidentMap

**Live demo: [polis-incidents-map.dentaku.se](https://polis-incidents-map.dentaku.se/)**

A fullstack web app displaying live Swedish police incidents on an interactive map.

Adapted from an Android/Kotlin project built during the Linero course (module203).

## Architecture

```
Frontend (React + Vite + Tailwind)
        ↓ HTTP
Backend (ASP.NET Core Web API)
        ↓ HTTP
Polisen Public API (polisen.se/api)
```

## Features

- Live incidents fetched from the Swedish Police public API
- Interactive map with clustered markers (react-leaflet)
- Filter incidents by type
- Clicking a marker shows incident details

## Running locally

Start the backend first, then the frontend — see their respective READMEs.

## Deployment

Hosted on Coolify with two separate Docker containers.