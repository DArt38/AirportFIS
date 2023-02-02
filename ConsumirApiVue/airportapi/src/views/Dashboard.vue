<template>
        <div>
            <HeaderItem/>
            <br><br>

            <div class="container">
                <table class="table table-striped table-dark">
                    <thead>
                        <caption>ARRIVALS</caption>
                        <tr>
                        <th scope="col">#</th>
                        <th scope="col">TIME</th>
                        <th scope="col">FROM</th>
                        <th scope="col">FLIGHT NO.</th>
                        <th scope="col">REMARKS</th>
                        </tr>
                    </thead>
                <tbody>
                    <tr v-for="llegada in Listallegadas" :key="llegada.id">
                    <th scope="row">{{ llegada.id }}</th>
                    <td>{{ llegada.hora }}</td>
                    <td>{{ llegada.desde }}</td>
                    <td>{{ llegada.vuelo_No }}</td>
                    <td>{{ llegada.observaciones }}</td>
                    </tr>
                   
                </tbody>
                </table>
            </div>

            <div class="container">
                <table class="table table-striped table-dark">
                    <thead>
                        <caption>DEPARTURES</caption>
                        <tr>
                        <th scope="col">#</th>
                        <th scope="col">TIME</th>
                        <th scope="col">TO</th>
                        <th scope="col">FLIGHT NO.</th>
                        <th scope="col">GATE</th>
                        <th scope="col">REMARKS</th>
                        </tr>
                    </thead>
                <tbody>
                    <tr v-for="salida in Listasalidas" :key="salida.id">
                    <th scope="row">{{ salida.id }}</th>
                    <td>{{ salida.hora }}</td>
                    <td>{{ salida.hasta }}</td>
                    <td>{{ salida.vuelo_No }}</td>
                    <td>{{ salida.puerta }}</td>
                    <td>{{ salida.observaciones }}</td>
                    </tr>
                </tbody>
                </table>
            </div>
               
            <br><br>
            <FooterItem/>
        </div>
</template>


<script>
import HeaderItem from '@/components/HeaderItem.vue'
import FooterItem from '@/components/FooterItem.vue'
import axios from 'axios'

export default{
    name: 'DashBoard',
    data(){
        return{
             Listallegadas:null,
             Listasalidas: null,
             pagina:1
        }
    },
    components:{
        HeaderItem,
        FooterItem
    },
    mounted: function(){
            let direccion = "https://localhost:7048/api/Llegada";
            let direccion2 = "https://localhost:7048/api/Salida";
            axios.get(direccion).then(data =>{
                this.Listallegadas = data.data;            
            })
            axios.get(direccion2).then(data =>{
                this.Listasalidas = data.data;            
            })
    }
}

</script>

<style scoped>
</style>