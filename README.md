# Curso de programação web

## Preparação do ambiente

### 1 - Instalar o node v10 ou mais recente
Endereço para download: https://nodejs.org/en/

### 2 - Instalar o servidor de testes
```sh
# instala o serve globalmente
npm install -g serve
```

### 3 - Iniciar o servidor de testes
```sh
serve
```

### Servidor NODE
```sh
# instala o servidor com recarregamento automático
npm install nodemon -g

# para instalar todas as dependências
cd server
npm install

# para rodar o servidor com autoreload
nodemon server.js

# para rodar o servidor simples
npm run start

# para atualizar pacotes
npm update
```