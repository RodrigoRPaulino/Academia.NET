
//função para enviar o formulario
function enviarFormulario(e)
{
    e.preventDefault();
    document.getElementById('tabela-dados').classList.remove('d-nome');
    exibirDados();
    console.log('submetido');
}
// códigos para pegar o formulário pelo id e adicionar a função enviar formulario
document.getElementById('formulario').addEventListener('submit',enviarFormulario);
document.getElementById('nome').addEventListener('focusout', gerarLogin);
document.getElementById('sobrenome').addEventListener('focusout', gerarLogin);
document.getElementById('cep').addEventListener('focusout', buscarCep);

//função para gerarmos o login do usuário
function gerarLogin()
{   //variável que pega o elemto pelo id e o seu valor
    const nome = document.getElementById('nome').value;
    //variável que pega o sobrenome pelo id e o seu valor
    const sobrenome = document.getElementById('sobrenome').value;
    //variável criada para concatenar o nome adicionando o . e o sobrenome
    const login = nome + '.' + sobrenome;
    //pegamos o id do login com seu valor e dissemos que o login será impresso com letras minusculas
    document.getElementById('login').value = login.toLowerCase();
}
//funçao que exibe os dados do formulario na tabela
 function exibirDados()
 {
    // criamos uma array dos itens pedidos no formulario
    const itens = 
    [
        'nome',
        'sobrenome',
        'email',
        'login',
        'senha',
        'cep',
        'endereco',
        'complemento',
        'bairro',
        'cidade',
        'estado',
        'github',
        'academia',
        'professores',
        'termos',
        'info',
    ]
    //geramos o login novamente para ser exibido na tabela
     gerarLogin();

     // percorremos a lista de itens pegando os elementos 
    itens.forEach(element => {
        //condição onde o elemento é igual a info
        if(element == 'info')
        {
            //O querySelector() é um método da interface Element. 
            //O método querySelector() permite selecionar o primeiro elemento que corresponde a um ou mais seletores
            //pegamos o input name
            var valor = document.querySelector('input[name="info"]:checked').value;
        }else
        {
            var valor = document.getElementById(element).value; 
        }
     
      console.log(valor);
      document.getElementById('t-'+ element).innerHTML = valor;
    });


 }
     // método para buscar o cep
    function buscarCep(){
        //crio a variavel pegando o elemento cep com seu valor 
        let cep = document.getElementById('cep').value;
        //condição que executa o código quando o cep for diferente de vazio
        if(cep!==""){
            //concatenado a url com o cep
            let url="https://brasilapi.com.br/api/cep/v1/"+cep;
            // cria uma nova requisição 
            let req = new XMLHttpRequest();
               //pega a url
                req.open("GET",url);
                //envia a requisição
                req.send();
                //agora o tratamento da resposta da requisição
                req.onload=function(){
                    //condição para sabermos se os dados funcionaram
                    if(req.status===200){

                        let endereco =JSON.parse(req.response);
                        document.getElementById("endereco").value= endereco.street;
                        document.getElementById("bairro").value= endereco.neighborhood;
                        document.getElementById("cidade").value= endereco.city;
                        document.getElementById("estado").value= endereco.state;   }
                        // caso o cep seja invalido se exibe um alerta
                        else if(req.status===404){    
                            alert("CEP inválido");    
                        }
                        
                        else {    
                            alert("Erro ao fazer a requisição");                      
                        }
                    }
            }       
            //funçao para preencher o campo ao sair do campo cep
             window.onload=function(){    
                 let txtCep= document.getElementById("cep");   
                 txtCep.addEventListener("blur",buscarCep);   
             }    
            }







