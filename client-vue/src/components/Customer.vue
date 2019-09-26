<template>
  <div>
    <h1>{{ form.name || 'Clientes' }}</h1>

    <div class="botoes">
      <button @click="clearForm" type="button">Novo</button>
      <button @click="saveForm" type="button">Salvar</button>
    </div>

    <table v-if="data.length" class="table-data">
      <thead>
        <tr>
          <th>ID</th>
          <th>Nome</th>
          <th class="text-center">Opções</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="customer in data" :key="customer.id">
            <td>{{ customer.id }}</td>
            <td>{{ customer.name }}</td>
            <td class="text-center">
              <a href="#editar" @click="loadForm($event, customer)">Editar</a>
            </td>
        </tr>
      </tbody>
    </table>
    <div v-else class="info">
      Você ainda não possui clientes cadastrados!
    </div>

    <form>
      <p>
        <label>Id:<br />
          <input v-model="form.id" type="text" disabled />
        </label>
      </p>
      <p>
        <label>Nome:<br />
          <input v-model="form.name" type="text" />
        </label>
      </p>
    </form>
  </div>
</template>

<script>
import { CustomerService } from '../services'
const customerService = new CustomerService()

export default {
  name: 'Customer',
  data () {
    return {
      form: {},
      data: []
    }
  },
  methods: {
    clearForm () {
      this.form = {}
    },
    async loadForm (event, data) {
      event.preventDefault()
      this.form = await customerService.getById(data.id)
    },
    async saveForm () {
      const customer = await customerService.set(this.form)
      const index = this.data.findIndex(x => x.id === customer.id)
      if (index >= 0) {
        // Verifico se o liente já existe no array
        this.data[index].name = customer.name
      } else {
        this.data.push(customer)
      }
    }
  },
  async mounted () {
    this.data = await customerService.get()
  }
}
</script>

<style scoped>
.info {
  background-color: #eaeaea;
  border-color: solid 1px #cccccc;
  border-radius: 6px;
  padding: 1em;
  font-size: 14px;
  color: #666666;
}
</style>
