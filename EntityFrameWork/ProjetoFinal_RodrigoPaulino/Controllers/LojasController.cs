﻿using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_RodrigoPaulino.Models;
using ProjetoFinal_RodrigoPaulino.Repositorio;

namespace ProjetoFinal_RodrigoPaulino.Controllers
{/// <summary>
/// Meu terceiro passo foi criar uma controller vazia 
/// </summary>
    public class LojasController : Controller
    {
        private readonly ILojasRepositorio _lojasRepositorio;
        public LojasController(ILojasRepositorio lojasRepositorio)
        {
            _lojasRepositorio = lojasRepositorio;
        }
        //clico com o botao direito em View e adiciono uma nova view vazia
        public IActionResult Index()
        {
           List<LojasModel> lojas = _lojasRepositorio.BuscarTodos();
            return View(lojas);
        }
        /// <summary>
        /// Quinto passo será criar as actions das paginas de cadastro, ediçao  e deleção 
        /// e a criação das views de cada action
        /// </summary>
        /// <returns></returns>
        public IActionResult Cadastrar()
        {
            return View();
        }

        /// <summary>
        /// assinamos o método de cadastrar como httppost
        /// é ele que recebe e cadastra a informação
        /// </summary>
        /// <param name="lojas"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(LojasModel lojas)
        {
            try
            {
                //criando condição : se o valor da modelstate for valida o if ira passar os comandos de cadastro
                if (ModelState.IsValid)
                {
                    _lojasRepositorio.Cadastrar(lojas);
                    // criando menssagem temporária para exibir o exito no cadastro
                    TempData["MenssagemSucesso"] = "Cadastro realizado com sucesso";
                    //retorno redirecionando a index 
                    return RedirectToAction("Index");
                }
                return View(lojas);
            }
            catch (Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao efetuar o cadastro, tente novamente mais tarde, {erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }

        }
        //depois de terminar o método de cadastrar vamos a program para configurar
        //a injeção de dependencia da ILojasRepositório   

        /// <summary>
        /// passar para o método de ediçao o id de que ele ira editar
        /// </summary>
        /// <returns></returns>
        public IActionResult Editar(int id)
        {
            //variável com o método de buscar o id
           LojasModel lojas = _lojasRepositorio.BuscarId(id);
            //retornamos na view o id do banco 
            return View(lojas);
        }

        /// <summary>
        /// depois de fazer o método de edição
        /// crio o método de alterar a loja
        /// </summary>
        /// <param name="lojas"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Alterar(LojasModel lojas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _lojasRepositorio.Atualizar(lojas);
                    TempData["MenssagemSucesso"] = "Alterações realizadas com sucesso";
                    //retorno redirecionando a index 
                    return RedirectToAction("Index");
                }
                //forçamos o retorno da view 
                return View("Editar", lojas);
            }
            catch (Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao alterar as informações, tente novamente mais tarde, {erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }

        }

        /// <summary>
        /// método para confirmação de deleção
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ApagarConfirmacao(int id)
        {
            LojasModel lojas = _lojasRepositorio.BuscarId(id);
            return View(lojas);
        }


        public IActionResult Apagar(int id) 
        {
            try
            {
                bool apagado = _lojasRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MenssagemSucesso"] = "Informações apagadas com sucesso";
                }
                else
                {
                    TempData["MenssagemErro"] = $"Erro ao apagar as informações, tente novamente mais tarde";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao apagar as informações, tente novamente mais tarde,{erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }
            
        }


       


    }
}
