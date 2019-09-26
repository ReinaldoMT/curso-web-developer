<template>
  <div id="app">
    <div class="main-menu">
      <router-link to="/">Home</router-link>  |
      <router-link to="/customers">Clientes</router-link>
    </div>
    <div class="container">
      <router-view/>
    </div>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
body {
  padding: 0;
  margin: 0;
}
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
.main-menu {
  padding: 12px;
  border-bottom: solid 1px #cccccc;
  background-color: #eaeaea;
}
.main-menu a {
  text-decoration: none;
  color: #666666;
}
.main-menu a.router-link-exact-active {
  font-weight: bold;
}
.container {
  /* 0 12px 0 12px */
  margin: 0 12px;
}
select, input[type='text'] {
  padding: 6px;
}

input[type='text'] {
  min-width: 400px;
}

button {
  padding: 10px;
  background-color: #3399FF;
  color: #FFFFFF;
  border: solid 1px #2277CC;
}

button:hover {
  background-color: #2277CC;
}

code {
  background-color: #CCCCCC;
}

.caixa {
  background-color: #EAEAEA;
  border: solid 1px #DDDDDD;
  padding: 5px;
  box-shadow: 0 0 2px 2px #CCCCCC;
  border-radius: 5px;
  margin-bottom: 1em;
}

.table-data {
  width: 100%;
  border: solid 1px #DDDDDD;
}

.table-data th,
.table-data td {
  text-align: left;
  border-bottom: solid 1px #DDDDDD;
  padding: 8px;
}

.table-data tr:last-child td {
  border-bottom: none;
}

.table-data tr:hover td {
  background-color: #f0f0f0;
}

.text-center {
  text-align: center !important;
}

.botoes {
  margin-bottom: 1em;
}
</style>
