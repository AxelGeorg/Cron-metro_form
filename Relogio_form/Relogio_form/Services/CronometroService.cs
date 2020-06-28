using Newtonsoft.Json;
using Relogio_form.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Relogio_form.Services
{
    public class CronometroService
    {
        private const string urlWebApi = @"http://localhost:5000/api/";

        public async Task<List<Cronometro>> GetHistorico()//por padrão retorna o ranking por id
        {
            var retorno = new List<Cronometro>();

            using (HttpClient client = new HttpClient())
            {
                var tget = client.GetAsync(string.Concat(urlWebApi, "cronometro/obterHistorico"));
                tget.Wait();

                var resposta = tget.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<List<Cronometro>>(respostaComoString);
                }
            }

            return retorno;
        }

        public async Task<Resposta> PostHistorico(Cronometro cronometro)
        {
            var retorno = new Resposta();


            var json = JsonConvert.SerializeObject(cronometro);
            var dados = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var tpost = client.PostAsync(string.Concat(urlWebApi, "cronometro/cadastrarCronometro"), dados);
                tpost.Wait();

                var resposta = tpost.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<Resposta>(respostaComoString);
                }
                else
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno.Status = false;
                    retorno.Mensagem = string.Concat(resposta.ReasonPhrase, " - ", respostaComoString);
                }
            }

            return retorno;
        }

        public async Task<Resposta> DeleteHistorico()
        {
            var retorno = new Resposta();

            using (HttpClient client = new HttpClient())
            {
                var tdelete = client.DeleteAsync(string.Concat(urlWebApi, "cronometro/deletarHistorico"));
                tdelete.Wait();

                var resposta = tdelete.Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno = JsonConvert.DeserializeObject<Resposta>(respostaComoString);
                }
                else
                {
                    var respostaComoString = await resposta.Content.ReadAsStringAsync();

                    retorno.Status = false;
                    retorno.Mensagem = string.Concat(resposta.ReasonPhrase, " - ", respostaComoString);
                }
            }

            return retorno;
        }
    }
}
