const baseUrl = 'https://photo-sphere-viewer-data.netlify.app/assets/';
const base = 'https://minimahe.github.io/MTX360/fotos/';

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
                let urlImagen = imagen.ruta;
                let flechas = []
                imagen.flechas.forEach(function (flecha) {
                    let lineaflechas = { nodeId: flecha.nodeid, position: { pitch: 0, yaw: flecha.posicion } };
                    flechas.push(lineaflechas)
                });
                let imagenObj = {
                    id: nombreId,
                    panorama: base + urlImagen,
                    thumbnail: baseUrl + 'tour/key-biscayne-1-thumb.jpg',
                    name: nombreImagen,
                    links: flechas,
                    panoData: { poseHeading: 100 },
                    map: { x: 660, y: 570, color: '#fffd99' },
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
            //[PhotoSphereViewer.MapPlugin, {
            //    static: true,
            //    maxZoom: 150,
            //}],
            [PhotoSphereViewer.VirtualTourPlugin, {
                //positionMode: 'gps',
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
                    imageUrl: base + 'mapa.jpg',
                    size: { width: 1600, height: 1200 },
                    extent: [-80.158123, 25.668050, -80.153824, 25.660408],
                },
            }],
        ],
    });
    const virtualTour = viewer.getPlugin(PhotoSphereViewer.VirtualTourPlugin);
}