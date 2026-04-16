import {useEffect, useState} from 'react'

const API_URL = 'http://localhost:5116/api/incidents'

function App() {
  const [incidents, setIncidents] = useState([])
  const [loading, setLoading] = useState(true)

  useEffect(() => {
    fetch(API_URL)
      .then(response => response.json())
      .then(data => {
        setIncidents(data)
        setLoading(false)
      })
      .catch(error => {
        console.error('Error fetching incidents:', error);
        setLoading(false);
      })
  }, [])

  return (
    <div className="flex h-screen">
      <aside className="w-96 flex flex-col border-r border-gray-200 overflow-hidden">
        <div className="p-4 border-b border-gray-200">
          <h1 className="text-xl font-bold"> Polisincidenter</h1>
        </div>
        <div className="flex-1 overflow-y-auto p-2">
          {loading && <p className="text-center">Laddar...</p>}
          {incidents.map(incident => (
            <div key={incident.id} className="p-3 mb-2 rounded border border-gray-200 shadow">
              <p className="font-semibold">{incident.type}</p>
              <p className="text-xs text-gray-500">{incident.location.name}</p>
              <p className="text-xs mt-1">{incident.summary}</p>
            </div>
          ))}
        </div>
      </aside>
      <main className="flex-1 bg-gray-100 flex items-center justify-center">
        <p className="text-gray-400">Map placeholder</p>
      </main>
    </div>
  )
}

export default App