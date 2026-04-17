function InfoPanel() {
  return (
    <div className="mb-3 p-3 bg-gray-50 rounded-lg border border-gray-200 text-gray-600">
      <p className="mb-3">
        Visar aktuella polishändelser i Sverige i realtid, hemtade från Polisens öppna API.
      </p>
      <p className="font-bold text-gray-700 mb-1">Teknik</p>
      <ul className="space-y-0.5 mb-3">
        <li>React + Vite + Tailwind CSS
          <
        </li>
        <li>ASP.NET Core Web API (.NET 10)</li>
        <li>react-leaflet + OpenStreetMap</li>
        <li>Polisens öppna API @ <a
          href="https://polisen.se/om-polisen/om-webbplatsen/oppna-data/api-over-polisens-handelser/"
          target=_blank>polisen.se</a></li>
      </ul>
      <a
        href="https://github.com/laszloprekop/CSharpPractice/tree/main/PolisIncidentMap"
        target="_blank"
        rel="noreferrer"
        className="text-blue-600 hover:underline"
      >Källkod på GitHub →</a>
    </div>
)
}

export default InfoPanel