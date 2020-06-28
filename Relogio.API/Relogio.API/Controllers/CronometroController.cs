using Microsoft.AspNetCore.Mvc;
using Relogio.API.Entities;
using Relogio.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relogio.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CronometroController : ControllerBase
    {
        CronometroDAO dao = new CronometroDAO();

        [HttpGet]
        [Route("obterHistorico")]
        public async Task<IActionResult> GetHistorico()
        {
            try
            {
                // retorna uma lista simples de cronometros.
                List<Cronometro> historico = new List<Cronometro>();
                historico = dao.BuscarHistorico();

                return Ok(historico);
            }
            catch (Exception ex)
            {
                // se houver alguma exceção ele retorna o erro 500 e uma mensagem do erro.
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("cadastrarCronometro")]
        public async Task<IActionResult> PostCronometro([FromBody] Cronometro cronometro)
        {

            try
            {
                if (cronometro == null)
                    throw new Exception("O objeto cronometro não pode ser nulo.");

                // faz a inserção na base de dados...
                dao.cadastrarCronometro(cronometro.cro_data, cronometro.cro_horario, cronometro.cro_tempo);

                // fez a inserção na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "Cronômetro cadastrado com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("deletarHistorico")]
        public async Task<IActionResult> DeletarHistorico()
        {
            try
            { 
                // deleta na base de dados...
                dao.deletarHistorico();

                // deletou na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "Histórico deletado com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("criaTable")]
        public async Task<IActionResult> criaTable()
        {

            try
            {
                // cria a tabela na base de dados...
                dao.criaTabela();

                // fez a inserção na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "Table criada com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("criaDataBase")]
        public async Task<IActionResult> criaDataBase()
        {

            try
            {
                // cria a tabela na base de dados...
                dao.criaDataBase();

                // fez a inserção na base de dados com sucesso, então retorna uma resposta de ok.
                var resposta = new Resposta { Status = true, Mensagem = "DATABASE criada com sucesso." };

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
