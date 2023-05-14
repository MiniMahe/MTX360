const baseUrl = 'https://photo-sphere-viewer-data.netlify.app/assets/';
const base = 'https://minimahe.github.io/MTX360/fotos/';
const base2 = 'https://minimahe.github.io/MTX360/MTXView/MVC/wwwroot/lib/imgs/';
function promesa() {
    $.ajax({
        url: "/Access/ObtenerListaImagenes",
        type: "GET",
        success: function (datosListaImagenes) {
            let listaImagenes = JSON.parse(datosListaImagenes);
            let imagenes = [];

            listaImagenes.forEach(function (imagen) {
                let nombreId = imagen.id;
                let nombreImagen = imagen.Name;
                let colors = '#FF99F6';
                let urlImagen = imagen.ruta;
                let cordenadax = imagen.x;
                let cordenaday = imagen.y;
                let piso = imagen.piso
                let flechas = []
                
                
                if ((piso != pisoimg)) {
                    cordenadax = 6000;
                    cordenaday = 6000;
                    colors = '#FFF'; 
                } else if (cordenadax == 0 && cordenaday == 0) {
                    cordenadax = 385;
                    cordenaday = 370;
                    colors = '#FFF'; }
                        
                
                imagen.flechas.forEach(function (flecha) {
                    let lineaflechas = { nodeId: flecha.nodeid, position: { pitch: 0, yaw: flecha.posicion } };
                    flechas.push(lineaflechas)
                });
                let imagenObj = {
                    id: nombreId,
                    panorama: base + urlImagen,
                    thumbnail: null,
                    name: nombreImagen,
                    links: flechas,
                    panoData: { poseHeading: 100 },
                    map: { x: cordenadax, y: cordenaday, color: colors, marker: false}
,                
                };
                imagenes.push(imagenObj);

            });
            PhotoSphere(imagenes);
        }
    });
}

promesa();

function PhotoSphere(nodes) {
    const nodesById = {};
    nodes.forEach((node) => (nodesById[node.id] = node));

    const viewer = new PhotoSphereViewer.Viewer({
        lang: {
            zoom: 'Zoom',
            moveUp: 'Move up',
            moveDown: 'Move down',
            moveLeft: 'Move left',
            moveRight: 'Move right',
            fullscreen: 'Pantalla completa',
            menu: 'Menu',
            close: 'Cerrar',
            loadError: 'Error de imagen',
        },
        navbar: [
            'fullscreen',
            'move',
            'zoom',
            {
                id: 'my-button',
                content: '<svg...>',
                title: 'Hello world',
                className: 'custom-button',
                onClick: (viewer) => {
                    alert('Hola mundo');
                }
            },
        ],
        container: 'photosphere',
        loadingImg: baseUrl + 'loader.gif',
        defaultYaw: '100deg',
        plugins: [
            PhotoSphereViewer.MarkersPlugin,
            PhotoSphereViewer.CompassPlugin,
            PhotoSphereViewer.GalleryPlugin,
            [PhotoSphereViewer.MapPlugin, {
                static: true,
                maxZoom: 100,
            }],
            [PhotoSphereViewer.VirtualTourPlugin, {
                positionMode: 'manual',
                renderMode: '3d',
                startNodeId: nodes[startnode].id,
                preload: true,
                // transition   : false,
                // rotateSpeed  : false,
                arrowPosition: 'bottom',

                // client mode
                dataMode: 'client',
                nodes: nodes,

                map: {
                    imageUrl: base2 + 'Mapa_Planta.png',
                    size: { width: 666, height: 956 },
                },
            }],
        ],
    });
    const virtualTour = viewer.getPlugin(PhotoSphereViewer.VirtualTourPlugin);
}