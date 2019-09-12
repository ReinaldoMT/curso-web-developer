const data = []

function addData (obj) {
  data.push(obj)
}

function getData () {
  return data
}

function getById (id) {
  return data.find(x => x.id === id)
}
