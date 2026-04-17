import {useEffect, useState} from 'react'

import {Siren, Info} from '@phosphor-icons/react'
import IncidentCard from './components/IncidentCard'
import IncidentMap from './components/IncidentMap'
import InfoPanel from './components/InfoPanel'

const API_URL = import.meta.env.VITE_API_URL || 'http://localhost:5116/api/incidents'

function App() {
  const [incidents, setIncidents] = useState([])
  const [loading, setLoading] = useState(true)
  const [selectedType, setSelectedType] = useState('All')
  const [showInfo, setShowInfo] = useState(false)


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

  const types = ['All', ...new Set(incidents.map(i => i.type)).values()]
  const filteredIncidents = selectedType === 'All' ? incidents : incidents.filter(i => i.type === selectedType)

  return (
    <div className="flex h-screen">
      <aside className="w-96 flex flex-col border-r border-gray-200 overflow-hidden">
        <div className="p-4 border-b border-gray-200">
          <div className="flex items-center justify-between mb-3">
            <div className="flex items-center gap-2">
              <Siren size={20} weight="duotone" className="text-blue-600"/>
              <h1 className="text-xl font-bold"> Polisincidenter</h1>
            </div>
            <button onClick={() => setShowInfo(v => !v)}>
              <Info size={20} weight="thin" className="text-gray-400 hover:text-blue-600"/>
              </button>
          </div>
          {showInfo && (
            <>
              <div className="fixed inset-0 z-10" onClick={() => setShowInfo(false)} />
              <div className="relative z-20">
                <InfoPanel />
              </div>
            </>
          )}
          <select
            value={selectedType}
            onChange={e => setSelectedType(e.target.value)}
            className="w-full text-sm border border-gray-300 rounded-md p-2 py-1"
          >
            {types.map(type => (
              <option key={type} value={type}>
                {type}
              </option>
            ))}
          </select>
        </div>
        <div className="flex-1 overflow-y-auto bg-gray-50">
          {loading && <p className="text-center">Laddar...</p>}
          {filteredIncidents.map(incident => (
            <IncidentCard key={incident.id} incident={incident}/>))}
        </div>
      </aside>
      <main className="flex-1">
        <IncidentMap incidents={filteredIncidents}/>
      </main>
    </div>
  )
}

export default App