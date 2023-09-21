# Primeira Web API em ASP.NET :wave:

Este repositório contém uma Web API em ASP.NET que implementa três endpoints diferentes para atender a diferentes propósitos. A API foi criada para demonstrar funcionalidades simples e pode ser usada como base para desenvolvimentos mais complexos.

<br>

## Endpoints

### 1. Exibindo a mensagem "Hello ASP.NET!"

- **Endpoint:** `~/`
- **Método HTTP:** GET
- **Descrição:** Este endpoint retorna a mensagem "Hello ASP.NET" quando acessado.

#### Exemplo de Uso:

```shell
curl -X GET https://sua-api.com/
```

#### Resposta:

```json
{
  "message": "Hello ASP.NET!"
}
```

<br>

### 2. Exibindo a mensagem "Hello {name}!"

- **Endpoint:** `/{name}`
- **Método HTTP:** GET
- **Descrição:** Este endpoint retorna a mensagem "Hello {name}!" quando acessado.

#### Exemplo de Uso:

```shell
curl -X GET https://sua-api.com/{name}
```

#### Resposta:

```json
{
  "message": "Hello {name}!"
}
```

<br>

### 3. Exibindo a lista de BSM's da Generation Brasil

- **Endpoint:** `/bsms`
- **Método HTTP:** GET
- **Descrição:** Este endpoint retorna uma lista de BSM's relacionados à Generation Brasil.

#### Exemplo de Uso:

```shell
curl -X GET https://sua-api.com/bsms
```

#### Resposta:

```json
{
  "bsms": [
    "BSM 1",
    "BSM 2",
    "BSM 3"
    // Outras BSMs da Generation Brasil
  ]
}
```

<br>

### 4. Exibindo uma lista de objetivos de aprendizagem desta semana

- **Endpoint:** `/objetivos`
- **Método HTTP:** GET
- **Descrição:** Este endpoint retorna uma lista de objetivos de aprendizagem para a semana atual.

#### Exemplo de Uso:

```shell
curl -X GET https://sua-api.com/objetivos
```

#### Resposta:

```json
{
  "objetivos": [
    "Aprender ASP.NET",
    "Desenvolver habilidades em Web API",
    "Praticar testes de API",
    // Outros objetivos de aprendizagem
  ]
}
```

<br>

## Configuração e Execução

Para executar esta Web API em sua máquina local, siga estas etapas:

1. Certifique-se de que você possui o ambiente de desenvolvimento .NET instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

2. Clone este repositório em seu computador

3. Navegue até o diretório do projeto

4. Execute o aplicativo

A API estará acessível em `http://localhost:5000` por padrão, mas você pode configurar a porta desejada no arquivo de configuração.

<br>

## Contribuições

Contribuições são bem-vindas! Se você quiser melhorar ou expandir esta API, sinta-se à vontade para enviar pull requests.

---

Divirta-se explorando e desenvolvendo com esta Web API em ASP.NET! Se tiver alguma dúvida ou precisar de assistência, não hesite em entrar em contato com os mantenedores deste repositório.