class CustomerServiceLocal {

  /**
   * Retorna um identificador único
   * @example
   * getUid() // Retorna 1234567899
   */
  getUid () {
    return new Date().getTime().toString()
  }

  getById (id) {
    return JSON.parse(localStorage.getItem(`customer_${id}`))
  }

  get () {
    let arr = []
    for (let i = 0; i < localStorage.length; i++) {
      const key = localStorage.key(i)
      if (key.startsWith('customer_')) {
        arr.push(JSON.parse(localStorage.getItem(key)))
      }
    }
    return arr
  }

  set (data) {
    if (!data.id) {
      data.id = this.getUid()
    }
    const jsonData = JSON.stringify(data)
    localStorage.setItem(`customer_${data.id}`, jsonData)
  }
}
