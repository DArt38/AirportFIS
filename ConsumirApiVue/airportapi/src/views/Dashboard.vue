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
                    <tr>
                    <th scope="row">1</th>
                    <td>10:30</td>
                    <td>New York</td>
                    <td>LY4839</td>
                    <td>A1</td>
                    <td>BAGS DELIVERED</td>
                    </tr>
                    <tr>
                    <th scope="row">2</th>
                    <td>10:45</td>
                    <td>Toronto</td>
                    <td>FJ7252</td>
                    <td>C2</td>
                    <td>BAGS DELIVERED</td>
                    </tr>
                    <tr>
                    <th scope="row">3</th>
                    <td>11:00</td>
                    <td>Dubai</td>
                    <td>LV2317</td>
                    <td>E3</td>
                    <td>EXPECTED 11:20</td>
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
             pagina:1
        }
    },
    components:{
        HeaderItem,
        FooterItem
    },
    mounted: function(){
            let direccion = "https://localhost:7048/api/Llegada";
            axios.get(direccion).then(data =>{
                this.Listallegadas = data.data;            
            })
    }
}

</script>

<style scoped>
</style>