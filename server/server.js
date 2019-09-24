const express = require('express')
const bodyParser = require('body-parser')
const cors = require('cors')
var app = express()

app.use(cors({ origin: true }))
app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: false }))

const data = [
  { id: 1, name: 'Reinaldo' },
  { id: 2, name: 'Gabriel' },
  { id: 3, name: 'Oscar' },
  { id: 4, name: 'Maestri' },
  { id: 5, name: 'Joana' },
  { id: 6, name: 'Felipe' }
]

app.get('/api/customers', function (req, res) {
  res.json(req.query.term ? data.filter(x => x.name.match(req.query.term)) : data)
})

app.get('/api/customers/:id', function (req, res) {
  const id = parseInt(req.params.id)
  const result = data.find(x => x.id === id)
  if (result) {
    res.json(result)
  } else {
    res.sendStatus(404)
  }
})

app.post('/api/customers', function (req, res) {
  let newData
  if (req.body.id) {
    const index = data.findIndex(x => x.id === req.body.id)
    data[index] = req.body
    newData = data[index]
  } else {
    newData = { ...req.body, id: (new Date()).getTime() }
    data.push(newData)
  }
  res.json(newData)
})

app.listen(3000, function () {
  console.log('Example app listening on port 3000!')
})
