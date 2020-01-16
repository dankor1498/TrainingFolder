window.onload = function() {
  //Створення сцени, налаштування камери, світла
    var width = window.innerWidth;
    var height = window.innerHeight;
    var canvas = document.getElementById('canvas');

    canvas.setAttribute('width', width);
    canvas.setAttribute('height', height);

    var renderer = new THREE.WebGLRenderer({canvas: canvas});
    renderer.setClearColor(0x050505);

    var scene = new THREE.Scene();

    var camera = new THREE.PerspectiveCamera(35, width / height, 0.1, 5000);

    var light = new THREE.AmbientLight(0xffffff);
    scene.add(light);
//Організація повороту камери, зміна масштабу
    var controls = new THREE.OrbitControls( camera, renderer.domElement );
    camera.position.set(300, 200, 1000);
    controls.update();
//Створення куба
    var geometry = new THREE.BoxGeometry(100,100,100,1);
    var material = new THREE.MeshBasicMaterial({color: 0xffff00, wireframe: true});
    var cube = new THREE.Mesh(geometry, material);
    cube.position.set(150, 150, 150);
    scene.add(cube);
//Функція яка обновлює сцену

    var btn1 = document.getElementById('btn1');
    var p1 = document.getElementById('p1');
    function loop() {
        btn1.onclick = function(){
            var x11 = document.getElementById('11').value;
            var x12 = document.getElementById('12').value;
            var x13 = document.getElementById('13').value;
            var x14 = document.getElementById('14').value;
            var x21 = document.getElementById('21').value;
            var x22 = document.getElementById('22').value;
            var x23 = document.getElementById('23').value;
            var x24 = document.getElementById('24').value;
            var x31 = document.getElementById('31').value;
            var x32 = document.getElementById('32').value;
            var x33 = document.getElementById('33').value;
            var x34 = document.getElementById('34').value;
            var x41 = document.getElementById('41').value;
            var x42 = document.getElementById('42').value;
            var x43 = document.getElementById('43').value;
            var x44 = document.getElementById('44').value;

            var translationMatrix = new THREE.Matrix4();
                translationMatrix.set(
                        1, 0, 0, x14,
                        0, 1, 0, x24,
                        0, 0, 1, x34,
                        0, 0, 0, 1
                );
            cube.applyMatrix(translationMatrix);
            cube.updateMatrix();

            var m = new THREE.Matrix4();
            m.set(x11,x12,x13,0, 
                  x21,x22,x23,0, 
                  x31,x32,x33,0, 
                  x41,x42,x43,x44);
            cube.geometry.applyMatrix( m );
            cube.geometry.verticesNeedUpdate = true;
            cube.updateMatrix();

            m.elements[12]=x14;
            m.elements[13]=x24;
            m.elements[14]=x34;
            p1.innerHTML += '</br>' + m.elements; 
        };
        renderer.render(scene, camera);
        requestAnimationFrame(function(){loop();});
    } 
    loop();
//створення осей 
    var materialX = new THREE.LineBasicMaterial( { color: 0xff0000 } );
    var geometryX = new THREE.Geometry();

    geometryX.vertices.push(new THREE.Vector3( -10000, 0, 0) );
    geometryX.vertices.push(new THREE.Vector3( 10000, 0, 0) );

    var lineX = new THREE.Line( geometryX, materialX );
    scene.add(lineX);

    var materialY = new THREE.LineBasicMaterial( { color: 0x00ff00 } );
    var geometryY = new THREE.Geometry();

    geometryY.vertices.push(new THREE.Vector3( 0, -10000, 0) );
    geometryY.vertices.push(new THREE.Vector3( 0, 10000, 0) );

    var lineY = new THREE.Line( geometryY, materialY );
    scene.add(lineY);

    var materialZ = new THREE.LineBasicMaterial( { color: 0x0000ff } );
    var geometryZ = new THREE.Geometry();

    geometryZ.vertices.push(new THREE.Vector3( 0, 0, -10000) );
    geometryZ.vertices.push(new THREE.Vector3( 0, 0, 10000) );

    var lineZ = new THREE.Line( geometryZ, materialZ );
    scene.add(lineZ);

    renderer.render( scene, camera );
}
