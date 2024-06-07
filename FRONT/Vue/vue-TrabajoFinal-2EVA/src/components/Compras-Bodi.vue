<template>
<div class="container">
    <div style="color: white; padding-top: 50px;">
        <div>
            <h2>Detalles de la obra seleccionada</h2>
            <div v-if="obraSeleccionada">
            <p><strong>Título:</strong> {{ obraSeleccionada.name }}</p>
            <p><strong>Fecha:</strong> {{ fechaSesion?.toLocaleString()}}</p>
            <p><strong>Descripción:</strong> {{ obraSeleccionada.synopsis }}</p>
            <!-- Puedes mostrar cualquier otra información de la obra aquí -->
            </div>
            <div v-else>
            <p>No se ha seleccionado ninguna obra.</p>
            </div>
        </div>
    </div>
    <div class="center-cont">
        <div class="grid-container" id="gridContainer"></div>
    </div>        
    <div style="padding-top: 50px;">
        <v-data-table
        style="max-height: 780px;"
        v-model:page="page"
        :items="items"
        :items-per-page="itemsPerPage"
        hide-default-footer
        hide-default-header
        >
            <template v-slot:top>
                <div class="d-flex justify-space-around py-2" style="height: 0px; background-color: rgba(38,50,58,1); border: 2px solid white"></div>
            </template>
            <template v-slot:item="{ item }">
                <tr>
                    <td>{{ item.obra }}</td>
                    <td>{{ item.fecha }}</td>
                    <td>{{ item.precio }}€</td>
                    <td>{{ item.asiento }}</td>
                </tr>
            </template>
            <template v-slot:bottom>
                <v-col class="pt-2" style="display: none;">
                    <v-col
                    v-for="(input, index) in inputs"
                    :key="index"
                    >
                    <v-text-field
                        v-model="input.model"
                        :label="input.label"
                        dense
                    ></v-text-field>
                    </v-col>
                </v-col>
                <v-dialog max-width="500">
                    <template v-slot:activator="{ props: activatorProps }">
                    <v-btn style="width: 200px; align-self: center; margin: 20px;"
                        v-bind="activatorProps"
                        color="surface-variant"
                        text="COMPRAR"
                        variant="flat"
                        :disabled="!obraSeleccionada || items.length === 0"
                        @onClick="addItem"
                    ></v-btn>
                    </template>

                    <template v-slot:default="{ isActive }">
                    <v-card title="¡ATENCIÓN!">
                        <v-card-text>
                            Antes de proceder con tu compra, asegurate de que los asientos seleccionados son los correctos, si es así, puede prodeceder a la compra/reserva pulsando
                            el boton comprar, si no es así, pulse el boton "Seguir comprando", para completar su selección.
                        </v-card-text>

                        <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn
                            id="btn-enviar"
                            style="background-color: #C72271;"
                            color="white"
                            text="REALIZAR COMPRA"
                            @click="isActive.value = false, buyItem()"
                        ></v-btn>
                        <v-btn
                            text="SEGUIR COMPRANDO"
                            @click="isActive.value = false"
                        ></v-btn>
                        </v-card-actions>
                    </v-card>
                    </template>
                </v-dialog>
            </template>
        </v-data-table>
    </div>
</div>
</template>
<style scoped>

.container {
    height: auto;
    width: auto;
    display: grid;
    grid-template-columns: 300px auto 550px;
    margin-block: 2%;
    margin-inline: 5%;
    font-size: 20px;
    gap: 20px;
}

.grid-container {
    display: grid;
    grid-template-columns: auto auto auto auto auto auto auto auto auto auto;
    justify-items: center;
    margin-inline: 50px;
    margin-top: 50px;
    height: fit-content;
    background-color: rgba(38,50,56,1);
    padding: 20px;
    border: 2px solid white;
}

.center-cont {
    display: flex;
    flex-direction: column;
}

@media (max-width: 1670px) {

    .container {
        display: flex;
        flex-direction: column;
    }

}

</style>
<script setup lang="ts">
import { onMounted, ref } from 'vue';
import { ObraStore, type Obra } from '@/stores/obraStore';
import { PedidoStore } from '@/stores/pedidosStore';

const obraSeleccionadaStore = ObraStore(); // Instanciamos la store

// Obtenemos la obra seleccionada de la store
const obraSeleccionada = ref< Obra | null>(null);
let  fechaSesion: Date|null =  null
let SesionId = 0 
const price = 10

const cargarObraSeleccionada = async () => {
  await obraSeleccionadaStore.cargarObras; 
  const obraData = localStorage.getItem('ObraSesion');
  
  if (obraData) {
    const parsedData = JSON.parse(obraData);
    const obraId = parsedData.obraId;
    fechaSesion = new Date(parsedData.date)
    SesionId = parsedData.sesionId
    const obra = await obraSeleccionadaStore.obtenerObra(obraId) ;
    if (obra ) {
        obraSeleccionada.value = obra  
    }
  }
};

onMounted(() => {
  cargarObraSeleccionada();
});
const svgCounter = ref(0);
const pedidoStore = PedidoStore(); // Instanciamos la store
const agregarSVG = (numSVGs: number) => {
  const gridContainer = document.getElementById('gridContainer');
  const centerCont = document.getElementsByClassName('center-cont');
  if (!gridContainer) {
    console.error('No se encontró el elemento gridContainer.');
    return;
  }

  // Asigna la cantidad de asientos por fila
  const asientosPorFila = 10;

  for (let i = 0; i < numSVGs; i++) {
    svgCounter.value++; // Incrementa el contador para el siguiente id

    // Cálculos para la fila y columna
    const fila = String.fromCharCode(65 + Math.floor(i / asientosPorFila)); // Convierte el número de fila a letra (65 es 'A' en ASCII)
    const columna = (i % asientosPorFila) + 1;
    // Crea el elemento SVG
    const svgElement = document.createElementNS("http://www.w3.org/2000/svg", "svg");
    svgElement.setAttribute("id", svgCounter.value.toString()); // Usa el id autoincremental
    svgElement.setAttribute("width", "60px");
    svgElement.setAttribute("height", "100px");
    svgElement.setAttribute("viewBox", "0 0 64 64");
    svgElement.setAttribute("xmlns", "http://www.w3.org/2000/svg");
    svgElement.setAttribute("xmlns:xlink", "http://www.w3.org/1999/xlink");
    svgElement.setAttribute("aria-hidden", "true");
    svgElement.setAttribute("role", "img");
    svgElement.setAttribute("class", "iconify iconify--emojione");
    svgElement.setAttribute("preserveAspectRatio", "xMidYMid meet");

    // Crea el primer path
    var path1 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path1.setAttribute("id", "1");
    path1.setAttribute("d", "M54.5 32c.2 2.2-1.3 4-3.4 4H12.9c-2.1 0-3.6-1.8-3.4-4l2.1-22.2c.2-2.2 2.1-4 4.2-4h32.4c2.1 0 4 1.8 4.2 4L54.5 32");
    path1.setAttribute("fill", "#c4c4c4");
    svgElement.appendChild(path1);

    // Crea el grupo g
    var group1 = document.createElementNS("http://www.w3.org/2000/svg", "g");
    group1.setAttribute("fill", "#3e4347");

    // Crea los paths dentro del grupo g
    var path2 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path2.setAttribute("d", "M8.9 30.5h6v8h-6z");
    path2.setAttribute("id", "4");
    group1.appendChild(path2);

    var path3 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path3.setAttribute("d", "M49.1 30.5h6v8h-6z");
    path3.setAttribute("id", "4");
    group1.appendChild(path3);

    var path4 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path4.setAttribute("d", "M14.6 50.9h6V61h-6z");
    path4.setAttribute("id", "4");
    group1.appendChild(path4);

    var path5 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path5.setAttribute("d", "M43.4 50.9h6V61h-6z");
    path5.setAttribute("id", "4");
    group1.appendChild(path5);

    svgElement.appendChild(group1);

    // Crea el segundo path
    var path6 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path6.setAttribute("id", "2");
    path6.setAttribute("d", "M41.4 25c-.3 2.6-2.4 4.8-4.5 4.8h-9.8c-2.2 0-4.2-2.1-4.5-4.8l-1.8-14.6c-.3-2.6 1.2-4.8 3.3-4.8h15.7c2.2 0 3.7 2.2 3.3 4.8L41.4 25");
    path6.setAttribute("fill", "#949494");
    svgElement.appendChild(path6);

    // Crea el grupo g
    var group2 = document.createElementNS("http://www.w3.org/2000/svg", "g");
    group2.setAttribute("fill", "#94989b");

    // Crea los paths dentro del grupo g
    var path7 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path7.setAttribute("d", "M23 58.9c-.2-.5-.8-1-1.3-1h-8c-.6 0-1.1.4-1.3 1L10.9 63c-.2.5.1 1 .7 1h12c.6 0 .9-.4.7-1L23 58.9");
    path7.setAttribute("id", "4");
    group2.appendChild(path7);

    var path8 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path8.setAttribute("d", "M53.1 63l-1.4-4.1c-.2-.5-.8-1-1.3-1h-8c-.6 0-1.1.4-1.3 1L39.7 63c-.2.5.1 1 .7 1h12c.5 0 .8-.4.7-1");
    path8.setAttribute("id", "4");
    group2.appendChild(path8);

    svgElement.appendChild(group2);

    // Crea el grupo g
    var group3 = document.createElementNS("http://www.w3.org/2000/svg", "g");
    group3.setAttribute("id", "3");
    group3.setAttribute("fill", "#5e5e5e");

    // Crea los paths dentro del grupo g
    var path9 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path9.setAttribute("d", "M46.2 6c0 2.2-1.7 4-3.8 4H21.5c-2.1 0-3.8-1.8-3.8-4V4c0-2.2 1.7-4 3.8-4h20.9c2.1 0 3.8 1.8 3.8 4v2");
    group3.appendChild(path9);

    var path10 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path10.setAttribute("d", "M15.5 29.2l-.3-2.1c-.2-1.1-1.1-2-2.1-2h-2.7c-1 0-1.9.9-2.1 2L8 29.2c-.2 1.1.5 2 1.5 2H14c1 0 1.7-.9 1.5-2");
    path10.setAttribute("id", "4");
    group3.appendChild(path10);

    var path11 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path11.setAttribute("d", "M55.8 29.2l-.3-2.1c-.2-1.1-1.1-2-2.1-2h-2.7c-1 0-1.9.9-2.1 2l-.3 2.1c-.2 1.1.5 2 1.5 2h4.5c1 0 1.6-.9 1.5-2");
    path11.setAttribute("id", "4");
    group3.appendChild(path11);

    var path12 = document.createElementNS("http://www.w3.org/2000/svg", "path");
    path12.setAttribute("d", "M51.5 36h-39c-3.1 0-5 3-4.4 6.7l.4 2.6c.6 3.7 3.7 6.7 6.7 6.7h33.4c3.1 0 6.1-3 6.7-6.7l.5-2.6c.7-3.6-1.3-6.7-4.3-6.7");
    group3.appendChild(path12);

    svgElement.appendChild(group3);
    svgElement.addEventListener('click', () => cambiarColor(svgElement));
    svgElement.addEventListener('click', () => animarSVG(svgElement));

    const texto = document.createElementNS("http://www.w3.org/2000/svg", "text");
    texto.setAttribute("x", "30"); // Centra el texto en el eje X (ajusta si tu SVG es de diferente tamaño)
    texto.setAttribute("y", "80"); // Posición en el eje Y, coloca el texto debajo del gráfico
    texto.setAttribute("font-size", "15"); // Tamaño del texto, ajusta según sea necesario
    texto.setAttribute("text-anchor", "middle"); // Asegura que el texto se centre respecto a `x`
    texto.setAttribute("fill", "white"); // Establece el color del texto para asegurar contraste
    texto.textContent = `${fila}${columna}`; // Texto que se mostrará
    svgElement.setAttribute('data-asiento-id', `Fila ${fila} Col ${columna}`);
    svgElement.appendChild(texto);

    gridContainer.appendChild(svgElement);
    

    
/*
    console.log('Agregando evento click a', svgElement);
    svgElement.addEventListener('click', () => cambiarColor(svgElement));
    console.log('Evento click agregado.');
*/
  }
  if (centerCont) { // Comprueba si gridContainer no es null
    const escenario = document.createElement('div');
    escenario.style.height = '60px';
    escenario.style.fontSize = '30px';
    escenario.style.backgroundColor = 'rgba(38,50,56,1)';
    escenario.style.color = 'white';
    escenario.style.display = 'flex';
    escenario.style.border = '2px solid white'
    escenario.style.justifyContent = 'center';
    escenario.style.alignItems = 'center';
    escenario.style.marginTop = '20px';
    escenario.style.fontFamily = "'Lato', sans-serif";
    escenario.textContent = 'ESCENARIO';
    gridContainer.after(escenario); // Esto coloca el escenario justo debajo del contenedor de los SVGs
  } else {
    console.error('No se encontró el elemento gridContainer.');
  } 
};

const animarSVG = (svgElement: SVGElement) => {
    const asientoID = svgElement.getAttribute('data-asiento-id');
    let transformOrigin = 'center center';
    const elementos = svgElement.querySelectorAll('[id^="1"], [id^="2"], [id^="3"], [id^="4"]');
    elementos.forEach((elemento) => {
        if(elemento.getAttribute('scale') == '1') {
            animateElement(elemento, 1, 1.2, 500, transformOrigin);
        } else {
            animateElement(elemento, 1.2, 1, 500, transformOrigin);
        }
    })

    function animateElement(
    element: Element, // Cambiado a SVGElement para reflejar el uso correcto con elementos SVG
    fromScale: number, 
    toScale: number, 
    duration: number, 
    transformOrigin: string
    ) {
        // Para elementos SVG, es mejor utilizar setAttribute para transformar propiedades
        element.setAttribute('style', `transition: transform ${duration}ms; transform-origin: ${transformOrigin};`);
        element.setAttribute('transform', `scale(${fromScale})`);
        setTimeout(() => {
            element.setAttribute('transform', `scale(${toScale})`);
        }, duration);
    }
}

const cambiarColor = (svgElement: Element) => {
    const asientoID = svgElement.getAttribute('id'); // Asegúrate de haber asignado este atributo al crear el SVG
    const obra = obraSeleccionada.value?.name;
    const fecha = fechaSesion?.toLocaleString();
    const precio = price;
    console.log(asientoID)
    if (asientoID) {
        items.value.push({
            obra: obra, // Modifica según corresponda
            fecha: fecha, // Modifica según corresponda
            precio: precio, // Modifica según corresponda
            asiento: asientoID, // Aquí usamos el ID del asiento que hemos guardado
        });
    }
    
    const elementos = svgElement.querySelectorAll('[id^="1"], [id^="2"], [id^="3"]');
    elementos.forEach((elemento) => {
        setTimeout(() => { // Usar setTimeout para cambiar el color después de 500 ms
            if(elemento.getAttribute('fill') == '#c4c4c4' || elemento.getAttribute('fill') == '#949494' || elemento.getAttribute('fill') == '#5e5e5e'){
                var currentFill = elemento.getAttribute('fill');
                if (currentFill === null) {
                    currentFill = '';
                }
                let newFill = '';
                switch (currentFill) {
                    case '#c4c4c4':
                        newFill = '#ffa6d0';
                        break;
                    case '#949494':
                        newFill = '#f558a3';
                        break;
                    case '#5e5e5e':
                        newFill = '#C72271';
                        break;
                }
                if (newFill) {
                    elemento.setAttribute('fill', newFill);
                }
            } else if(elemento.getAttribute('fill') == '#ffa6d0' || elemento.getAttribute('fill') == '#f558a3' || elemento.getAttribute('fill') == '#C72271'){
                var newFill = elemento.getAttribute('fill');
                currentFill = '';
                switch(newFill) {
                    case '#ffa6d0':
                        currentFill = '#c4c4c4';
                        break;
                    case '#f558a3':
                        currentFill = '#949494';
                        break;
                    case '#C72271':
                        currentFill = '#5e5e5e';
                        break;
                }                    
                elemento.setAttribute('fill', currentFill);
                if (currentFill == '#c4c4c4' || currentFill == '#949494' || currentFill == '#5e5e5e') {
                    const asientoID = svgElement.getAttribute('data-asiento-id');
                    if (asientoID) {
                        const index = items.value.findIndex(item => item.asiento === asientoID);
                        if (index !== -1) {
                            items.value.splice(index, 1);
                        }
                    }
                }
            }
        }, 500); // Espera 500 ms antes de cambiar el color
    });
};



onMounted(() => {
  agregarSVG(70); // Llama a la función agregarSVG con el número de SVGs que deseas generar
});

interface Item {
  obra: any;
  fecha: any;
  precio: any;
  asiento: any;
}

const page = ref(1);
const itemsPerPage = ref(70); // Puedes ajustar esto según tus necesidades
const items = ref<Item[]>([]);
const inputs = ref([
  { label: 'OBRA', model: '' },
  { label: 'FECHA', model: '' },
  { label: 'PRECIO', model: '' },
  { label: 'ASIENTO', model: '' },
]);

const addItem = () => {
  items.value.push({
    obra: inputs.value[0].model,
    fecha: inputs.value[1].model,
    precio: inputs.value[2].model,
    asiento: inputs.value[3].model,
  });
  // Limpiar inputs después de añadir
  inputs.value.forEach(input => {
    input.model = '';
  });
};

const buyItem = () => {
    const userId = JSON.parse(localStorage.getItem('user')||'').nameid
    const newPedido = {userId:parseInt(userId, 10), sesionId : SesionId, asientosId: items.value.map(v => v.asiento) }
    pedidoStore.addPedido(newPedido)

}


</script> 
@/stores/obraStore