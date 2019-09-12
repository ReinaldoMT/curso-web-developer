'strict'
/**
 * Obtém um elemento através do ID do mesmo
 * @param {string} elementId
 * @returns {HTMLElement}
 */
function _e (elementId) {
  return document.getElementById(elementId)
}

/**
 * Adiciona ou modifica o HTML de um elemento
 * @param {string} elementoId
 * @param {string} conteudo
 * @param {string} adiciona
 * @returns {void}
 */
function defineHtml (elementoId, conteudo, adiciona) {
  const elemento = _e(elementoId)
  if (adiciona) {
    elemento.innerHTML += `<p>${conteudo}</p>` // elemento.innerHTML = elemento.innerHTML + '<p>' + conteudo + '</p>'
  } else {
    elemento.innerHTML = conteudo
  }
}
