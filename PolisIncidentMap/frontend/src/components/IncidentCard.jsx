import {ArrowSquareOut} from '@phosphor-icons/react'

function IncidentCard({incident}) {
  const date = new Date(incident.datetime).toLocaleString('sv-SE', {
    month: 'short', day: 'numeric', hour: '2-digit', minute: '2-digit'
  })
  return (<a href={`https://polisen.se${incident.url}`}
             target="_blank"
             rel="noreferrer"
             className="group relative block px-4 py-3 hover:bg-white border-b border-white hover:shadow-lg transition-all duration-200">
    <div className="flex items-center justify-between mb-1">
        <span
          className="flex-none text-xs font-semibold bg-blue-100 text-blue-800 px-2 py-0.5 -ml-1 rounded-full">{incident.type}</span>
      <span className="flext-auto justify-self-end text-xs text-gray-400">{date}</span>

    </div>
    <p className="flex-none text-xs font-semibold text-gray-400">{incident.location?.name}</p>
    <p className="text-sm text-gray-500 mt-1 line-clamp-2">{incident.summary}</p>
    <ArrowSquareOut size={36} weight="thin"
                    className="absolute p-1.5 right-3 bottom-3 bg-white shadow rounded-full opacity-0 group-hover:opacity-100 transition-opacity text-blue-500"/>
  </a>)
}

export default IncidentCard