# Primeira Web API em ASP.NET :wave:

Este repositório contém uma Web API em ASP.NET que implementa três endpoints diferentes para atender a diferentes propósitos. A API foi criada para demonstrar funcionalidades simples e pode ser usada como base para desenvolvimentos mais complexos.

<br>

## Endpoints

### 1. Exibindo a mensagem "Hello World!"

- **Endpoint:** `/hello`
- **Método HTTP:** GET
- **Descrição:** Este endpoint retorna a mensagem "Hello World!" quando acessado.

#### Exemplo de Uso:

```shell
curl -X GET https://sua-api.com/hello
```

#### Resposta:

```json
{
  "message": "Hello World!"
}
```

<br>

### 2. Exibindo a lista de BSM's da Generation Brasil

- **Endpoint:** `/bsm`
- **Método HTTP:** GET
- **Descrição:** Este endpoint retorna uma lista de BSM's (Bolsa de Valores, Sociedade e Mercadorias) relacionados à Generation Brasil.

#### Exemplo de Uso:

```shell
curl -X GET https://sua-api.com/bsm
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

### 3. Exibindo uma lista de objetivos de aprendizagem desta semana

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

2. Clone este repositório em seu computador:

```shell
git clone https://github.com/seu-usuario/sua-api-aspnet.git
```

3. Navegue até o diretório do projeto:

```shell
cd sua-api-aspnet
```

4. Execute o aplicativo:

```shell
dotnet run
```

A API estará acessível em `http://localhost:5000` por padrão, mas você pode configurar a porta desejada no arquivo de configuração.

<br>

## Contribuições

Contribuições são bem-vindas! Se você quiser melhorar ou expandir esta API, sinta-se à vontade para enviar pull requests.

---

Divirta-se explorando e desenvolvendo com esta Web API em ASP.NET! Se tiver alguma dúvida ou precisar de assistência, não hesite em entrar em contato com os mantenedores deste repositório.