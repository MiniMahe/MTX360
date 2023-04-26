const baseUrl = 'https://photo-sphere-viewer-data.netlify.app/assets/';
const base = 'https://minimahe.github.io/MTX360/fotos/';

function promesa() {
    const nodes = [
        {
            id: '0',
            panorama: base + '1.JPG',
            thumbnail: baseUrl + 'tour/key-biscayne-1-thumb.jpg',
            name: 'One',
            links: [{ nodeId: '2', position: { pitch: 0, yaw: '100deg' } }],
            gps: [-80.156350, 25.666750, 3],
            panoData: { poseHeading: 327 },
            map: { x: 660, y: 570, color: '#fffd99' },
        },
        {
            id: '200',
            panorama: base + '1.JPG',
            thumbnail: baseUrl + 'tour/key-biscayne-1-thumb.jpg',
            name: 'One',
            links: [{ nodeId: '1', position: { pitch: 0, yaw: '100deg' } }],
            gps: [-80.156350, 25.666750, 3],
            panoData: { poseHeading: 327 },
            map: { x: 660, y: 570, color: '#fffd99' },
        },
    ];
    $.ajax({
        url: "/Access/ObtenerListaImagenes",
        type: "GET",
        success: function (datosListaImagenes) {
            let listaImagenes = JSON.parse(datosListaImagenes);
            listaImagenes.forEach(function (item) {
                const newNode = { ...nodes[item.id], id: item.id.toString(), ...nodes[item.Name], name: item.Name.toString(), ...nodes[item.ruta], panorama: base + item.ruta };
                nodes.push(newNode);
            })
            photoSphere(nodes);
        }
    });
}

promesa();

function photoSphere(nodes) {
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
                positionMode: 'gps',
                renderMode: '3d',
                startNodeId: nodes[0].id,
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

                //server mode (mock)
                //dataMode: 'server',
                //getNode: (nodeId) => {
                //    console.log('GET node ' + nodeId);
                //    return Promise.resolve({
                //        ...nodesById[nodeId],
                //        links: nodesById[nodeId].links.map((link) => ({
                //            ...link,
                //            name: nodesById[link.nodeId].name,
                //            gps: nodesById[link.nodeId].gps,
                //        })),
                //    });
                //},
            }],
        ],
    });
    const virtualTour = viewer.getPlugin(PhotoSphereViewer.VirtualTourPlugin);
}