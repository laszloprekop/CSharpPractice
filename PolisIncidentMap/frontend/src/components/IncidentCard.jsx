function IncidentCard({incident}) {
  const date = new Date(incident.datetime).toLocaleString('sv-SE', {
    month: 'short',
    day: 'numeric',
    hour: '2-digit',
    minute: '2-digit'
  })
  return (
    <a href={`https://polisen.se${incident.url}`}
       target="_blank"
       className="block p-3 mb-2 rounded border border-gray-200 hover:border-blue-400 hover:shadow transition-all">
      <div className="flex items-center justify-between mb-1">
        <span
          className="text-xs font-semibold bg-blue-100 text-blue-800 px-2 py-0.5 rounded-full">{incident.type}</span>
        <span className="text-xs text-gray-400">{date}</span>
      </div>
      <p className="text-xs font-medium text-gray-400">{incident.location?.name}</p>
      <p className="text-xs text-gray-500 mt-1 line-clamp-2">{incident.summary}</p>
    </a>
  )
}

export default IncidentCard