/**
 * Abreviação de document.getElementById(containerId)
 * @param {string} containerId
 */
function _e (containerId) {
  return document.getElementById(containerId)
}

/**
 * Adiciona ou troca o HTML de um elemento
 * @param {string} containerId
 * @param {string} content
 * @param {boolean} add
 */
function setHtml (containerId, content, add) {
  if (add) {
    _e(containerId).innerHTML += `<p>${content}</p>` // '<p>' + content + '</p>'
  } else {
    _e(containerId).innerHTML = content
  }
}
