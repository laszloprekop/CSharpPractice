import {useEffect, useState} from 'react'

import IncidentCard from './components/IncidentCard'

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
            <IncidentCard key={incident.id} incident={incident}/>))}
        </div>
      </aside>
      <main className="flex-1 bg-gray-100 flex items-center justify-center">
        <p className="text-gray-400">Map placeholder</p>
      </main>
    </div>
  )
}

export default App