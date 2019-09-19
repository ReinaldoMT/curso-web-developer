class UserService {
  getById (id) {
    return { id, name: 'Reinaldo' }
  }

  get () {
    return [{ id: 1, name: 'Reinaldo' }, { id: 2, name: 'Pedro Henrique' }]
  }

  set (data) {
    console.table(data)
  }

  setActive (isActive) {
    console.log(isActive)
  }

  setPassword (newPassword) {
    console.log(newPassword)
  }
}
