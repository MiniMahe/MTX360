﻿
    const baseUrl = 'https://photo-sphere-viewer-data.netlify.app/assets/';
    const base = 'https://minimahe.github.io/MTX360/fotos/';
    const markerLighthouse = {
        id: 'marker-1',
    image: baseUrl + 'pictos/pin-red.png',
    tooltip: 'Cape Florida Light, Key Biscayne',
    size: {width: 32, height: 32 },
    anchor: 'bottom center',
    gps: [-80.155975, 25.666680, 29 + 3],
    data: {
        compass: 'red',
    map: {image: baseUrl + 'pictos/pin-red.png', size: 25 },
                },
            };

    // links.position is used in manual mode
    // links.gps or node.gps is used in GPS mode
    const nodes = [
    {
        id: '1',
    panorama: base + '1.JPG',
    thumbnail: baseUrl + 'tour/key-biscayne-1-thumb.jpg',
    name: 'One',
    links: [{nodeId: '2', position: {pitch: 0, yaw: '100deg' } }],
    markers: [{
        ...markerLighthouse,
        position: {yaw: '105deg', pitch: '35deg' }, // only used in manual mode
                    }],
    gps: [-80.156350, 25.666750, 3],
    panoData: {poseHeading: 327 },
    map: {x: 660, y: 570, color: '#fffd99' },
                },
    {
        id: '2',
    panorama: base + '1.JPG',
    thumbnail: baseUrl + 'tour/key-biscayne-2-thumb.jpg',
    name: 'Two',
    links: [
    {nodeId: '3', position: {pitch: 0, yaw: '120deg' } },
    {nodeId: '1', position: {pitch: 0, yaw: '280deg' } },
    ],
    markers: [{
        ...markerLighthouse,
        position: {yaw: '100deg', pitch: '55deg' }, // only used in manual mode
                    }],
    gps: [-80.156210, 25.666700, 4],
    panoData: {poseHeading: 318 },
    map: {x: 700, y: 590, color: '#ffb075' },
                },
    {
        id: '3',
    panorama: base + '1.jpg',
    thumbnail: baseUrl + 'tour/key-biscayne-3-thumb.jpg',
    name: 'Three',
    links: [
    {nodeId: '2', position: {pitch: 0, yaw: '310deg' } },
    {nodeId: '4', position: {pitch: 0, yaw: '220deg' } },
    {nodeId: '5', position: {pitch: 0, yaw: '270deg' } },
    ],
    gps: [-80.156230, 25.666450, 3],
    panoData: {poseHeading: 328 },
    map: {x: 695, y: 695, color: '#b7c1ff' },
                },
    {
        id: '4',
    panorama: base + 'img.jpg',
    thumbnail: baseUrl + 'tour/key-biscayne-4-thumb.jpg',
    name: 'Four',
    links: [
    {nodeId: '3', position: {pitch: 0, yaw: '40deg' } },
    {nodeId: '5', position: {pitch: 0, yaw: '300deg' } },
    ],
    gps: [-80.156110, 25.666435, 3],
    panoData: {poseHeading: 78 },
    map: {x: 750, y: 705, color: '#64dbdb' },
                },
    {
        id: '5',
    panorama: base + 'pasillo.jpg',
    thumbnail: baseUrl + 'tour/key-biscayne-5-thumb.jpg',
    name: 'Five',
    links: [
    {nodeId: '6', position: {pitch: 0, yaw: '280deg' } },
    {nodeId: '3', position: {pitch: 0, yaw: '70deg' } },
    {nodeId: '4', position: {pitch: 0, yaw: '150deg' } },
    ],
    gps: [-80.156280, 25.666485, 3],
    panoData: {poseHeading: 190 },
    map: {x: 685, y: 685, color: '#9c9af9' },
                },
    {
        id: '6',
    panorama: baseUrl + 'tour/key-biscayne-6.jpg',
    thumbnail: baseUrl + 'tour/key-biscayne-6-thumb.jpg',
    name: 'Six',
    links: [
    {nodeId: '7', position: {pitch: 0, yaw: '-60deg' } },
    {nodeId: '5', position: {pitch: 0, yaw: '130deg' } },
    ],
    gps: [-80.156465, 25.666486, 2],
    panoData: {poseHeading: 328 },
    map: {x: 615, y: 685, color: '#de91f2' },
                },
    {
        id: '7',
    panorama: baseUrl + 'tour/key-biscayne-7.jpg',
    thumbnail: baseUrl + 'tour/key-biscayne-7-thumb.jpg',
    name: 'Seven',
    links: [{nodeId: '6', position: {pitch: 0, yaw: '80deg' } }],
    gps: [-80.157090, 25.666340, 3],
    panoData: {poseHeading: 250 },
    map: {x: 385, y: 745, color: '#8bed82' },
                },
    ];

    const nodesById = { };
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
            startNodeId: nodes[1].id,
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
