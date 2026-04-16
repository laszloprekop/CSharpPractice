import {MapContainer, TileLayer, Marker, Popup} from 'react-leaflet'
import MarkerClusterGroup from 'react-leaflet-cluster'
import L from 'leaflet'

const SWEDEN_CENTER = [60.170887, 18.643501]

const createClusterIcon = (cluster) => {
  const count = cluster.getChildCount()
  return L.divIcon({
    html: `                                                                                     
        <div style="position:relative; text-align:center;">                                     
          <div style="                        
            background: white;            
            border: 2px solid #2563eb;
            border-radius: 50%;                                                                   
            width: 36px;
            height: 36px;                                                                         
            display: flex;                                                                      
            align-items: center;          
            justify-content: center;
            box-shadow: 0 2px 6px rgba(0,0,0,0.3);                                                
            font-weight: 700;
            font-size: 13px;                                                                      
            color: #1d4ed8;                                                                     
          ">${count}</div>
          <div style="                                                                            
            width: 0; height: 0;
            border-left: 6px solid transparent;                                                   
            border-right: 6px solid transparent;                                                
            border-top: 8px solid #2563eb;
            margin: 0 auto;
            margin-top: -2px;                                                                     
          "></div>                            
        </div>                                                                                    
      `, className: '', iconSize: [36, 48], iconAnchor: [18, 44],
  })
}

function IncidentMap({incidents}) {
  const mapped = incidents.filter(i => {
    const [lat, lng] = i.location.gps.split(',').map(Number)
    return lat !== 0 && lng !== 0
  })

  return (<MapContainer
    center={SWEDEN_CENTER}
    zoom={5}
    className='h-full w-full'>
    <TileLayer
      url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
      attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a>'
    />
    <MarkerClusterGroup iconCreateFunction={createClusterIcon}>
      {mapped.map(incident => {
        const [lat, lng] = incident.location.gps.split(',').map(Number)
        return (<Marker key={incident.id} position={[lat, lng]}>
          <Popup>
            <strong>{incident.type}</strong><br/>
            {incident.location.name}<br/>
            <a href={`https://polisen.se${incident.url}`} target="_blank" rel="noreferrer">Läs mer</a>
          </Popup>
        </Marker>)
      })}
    </MarkerClusterGroup>
  </MapContainer>)
}

export default IncidentMap