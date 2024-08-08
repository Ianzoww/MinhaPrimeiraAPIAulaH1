using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;


namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("API/Aluno")] //CONTROLLER
    public class AlunoController : ControllerBase // É UMA CLASSE QUE ATENDE AS REQUISICOES FEITAS A UMA API
                                                  // PARA O CONTROLLER USAR O PROTOCOLO HTTP(HERANCA)
                                                  // USADO PARA COMUNICACAO DO SISTEMA COM O CONTROLLER DA API
                                                  // CONTROLADOR REALIZA ACOES(FUNCOES)
                                                  // ACOES EM UMA API, USAMOS VERBOS HTTP(GET, PUT, DELETE, POST)
                                                  // ROTA, O CAMINHO PARA SE CHEGAR A UMA FUNCAO
                                                  // https://localhost:7140/API/Aluno/Saudacao -> ROTA
                                                  // PROTOCOLO HTTP - SERVIDOR E PORTA - CONTROLLER - ACAO
    {
        [HttpGet]
        [Route("Saudacao")]
        public IActionResult Saudacao()
        {
            return Ok("Hello World");
        }

        [HttpGet]
        [Route("SaudacaoNome")]
        public IActionResult SaudacaoNome(string nome)
        {
            return Ok($"Hello World {nome}"); // STATUS 200
        }

       [HttpPost]
       public IActionResult CriarAluno(Aluno aluno)
        {
            // COLOCAR UMA ACAO PARA UM BANCO DE DADOS
            return Ok($"ALUNO {aluno.Nome} CRIADO COM SUCESSO!");
        }
    }
}
