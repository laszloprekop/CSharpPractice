import {MapContainer, TileLayer, Marker, Popup} from 'react-leaflet'

const SWEDEN_CENTER = [60.170887, 18.643501]

function IncidentMap({incidents}) {
  const mapped = incidents.filter(i => {
    const [lat, lng] = i.location.gps.split(',').map(Number)
    return lat !== 0 && lng !== 0
  })

  return (
    <MapContainer
      center={SWEDEN_CENTER}
      zoom={5}
      className='h-full w-full'>
      <TileLayer
        url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
        attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a>'
      />
      {mapped.map(incident => {
        const [lat, lng] = incident.location.gps.split(',').map(Number)
        return (
          <Marker key={incident.id} position={[lat, lng]}>
            <Popup>
              <strong>{incident.type}</strong><br/>
              {incident.location.name}<br/>
              <a href={`https://polisen.se${incident.url}`} target="_blank">Läs mer</a>
            </Popup>
          </Marker>
        )
      })}
    </MapContainer>
  )
}

export default IncidentMap