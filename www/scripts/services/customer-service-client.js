
const API_HOME = 'http://localhost:3000/api'

class CustomerServiceClient {
  /**
   * Retorna um identificador único
   * @example
   * getUid() // Retorna 1234567899
   */
  getUid () {
    return new Date().getTime().toString()
  }

  async getById (id) {
    const res = await axios.get(`${API_HOME}/customers/${id}`)
    return res.data
  }

  getVersaoComPromise () {
    return new Promise((resolve, reject) => {
      axios.get(`${API_HOME}/customers.json`)
        .then(response => {
          resolve(response.data.data || [])
        })
        .catch(error => {
          reject(error)
        })
    })
  }

  async get () {
    const result = await axios.get(`${API_HOME}/customers`)
    console.log(result)
    return result.data
  }

  async set (data) {
    const res = await axios({
      method: 'post',
      url: `${API_HOME}/customers`,
      data
    })
    return res.data
  }
}
