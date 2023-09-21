using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

[Route("~/")]
[ApiController]
public class HelloController
{
    [HttpGet]
    public string Hello()
    {
        return "Hello ASP.NET!";
    }
    
    [HttpGet("/{name}")]
    public string MeuNome(string name)
    {
        return $"Hello {name}!";
    }
    
    [HttpGet("/bsms")]
    public string Bsms()
    {
        return "Lista de BSMS\n\n" +
               "Mentalidade de Crescimento\n" +
               "Persistência\n" +
               "Responsabilidade Pessoal\n" +
               "Orientação ao Futuro\n" +
               "Comunicação\n" +
               "Orientação aos detalhes\n" +
               "Proatividade\n" +
               "Trabalho em equipe\n" +
               "Gestão de Tempo";
    }
    [HttpGet("/objetivos")]
    public string Objetivos()
    {
        return "Objetivos de aprendizagem da semana\n\n" +
               "Aprender ASP.NET\n" +
               "Desenvolver habilidades em Web API\n" +
               "Praticar testes de API";
    }
}