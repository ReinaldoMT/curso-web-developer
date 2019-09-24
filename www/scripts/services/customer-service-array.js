class CustomerServiceArray {
  constructor () {
    this.data = []
  }

  /**
   * Retorna um identificador único
   * @example
   * getUid() // Retorna 1234567899
   */
  getUid () {
    return new Date().getTime().toString()
  }

  getById (id) {
    return this.data.find(x => x.id === id)
  }

  get () {
    return this.data
  }

  set (data) {
    if (data.id) {
      const index = this.data.findIndex(x => x.id === data.id)
      this.data[index] = data
    } else {
      // Se eu não tenho id no data, então é um novo registro
      // Neste caso eu crio um novo uid para os novos dados
      data.id = this.getUid()
      this.data.push(data)
    }
  }
}
