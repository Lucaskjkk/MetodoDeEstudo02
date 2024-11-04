using ExemploExplorando.Models;
using System.Globalization;

int numero = 20;
bool ehPar = false;

//IF TERNARIO
ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));











// if(numero % 2 == 0)
// {
//     Console.WriteLine("Par");
// }
// else
// {
//     Console.WriteLine("Ímpar");
// }







































// Pessoa p1 = new Pessoa("Lucas", "Balduino");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoleitura.txt");


// if(sucesso)
// {
//     //Console.WriteLine($"Quantidades de linhas do arquivo: {quantidadeDeLinhas}");
//     foreach (string linha in linhasArquivo) 
//     {
//         Console.WriteLine(linha);
//     }
    
// }
// else
// {
//     Console.WriteLine("Não foi possívle ler o arquvo");
// }





































// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Lucas", "Balduino", 1.93M); //Melhor maneira de usar tupla
// // ValueTuple<int, string, string, decimal> outroTipoTupla = (1, "Lucas", "Balduino", 1.93M);
// // var outroExemploTupla = Tuple.Create(1, "Lucas", "Balduino", 1.93M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"NOME: {tupla.Item2}");
// Console.WriteLine($"SOBRENOME: {tupla.Item3}");
// Console.WriteLine($"ALTURA: {tupla.Item4}");

































// Dictionary<string, string> estados = new Dictionary<string, string>();


// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");


// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// Console.WriteLine("-----------------------");

// // estados.Remove("BA");
// // estados["SP"] = "São paulo - Valor alterado";

// // foreach(var item in estados)
// // {
// //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// // }


// string chave = "BA2";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente");
// }
// else
// {
//     Console.WriteLine("É seguro adicionar a chave, pois a mesma não existe");
// }































// Stack<int> pilha = new Stack<int>();

// pilha.Push(30);
// pilha.Push(320);
// pilha.Push(12);
// pilha.Push(4);
// pilha.Push(164);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemtno do topo: {pilha.Pop()}");
// pilha.Push(20);
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(22);
// fila.Enqueue(3);
// fila.Enqueue(44);
// fila.Enqueue(8);


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }





































//new ExemploExcecao().Metodo1();






































// try 
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Falha na localização do arquivo {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
// }finally
// {
//     Console.WriteLine("Leia até aqui");
// }











































// // DateTime data = DateTime.Now; 

// string dataString = "2024-13-04 12:02";
// // DateTime data = DateTime.Parse(dataString);
// // Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Imprimi personalizado 
// // Console.WriteLine(data.ToShortDateString()); //Somente data
// // Console.WriteLine(data.ToShortTimeString()); //Somente hora
// //DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data); //Validar uma data invalida, para uma data valida
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso. Data: {dataString}");
// }else
// {
//     Console.WriteLine($"{dataString}, não é uma data válda");
// }
// //Console.WriteLine(data);





































// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// //Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("C"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));









































// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);






































// Pessoa p1 = new Pessoa(nome:"Lucas",sobrenome: "Balduino");
// Pessoa p2 = new Pessoa(nome: "Rogerio",sobrenome: "Fernandes");



// Curso cursoDeingles = new Curso();
// cursoDeingles.Nome = "Inglês";
// cursoDeingles.Alunos = new List<Pessoa>();

// cursoDeingles.AdicionarAluno(p1);
// cursoDeingles.AdicionarAluno(p2);
// cursoDeingles.ListarAlunos();

 


























// Pessoa p1 = new Pessoa();

// p1.Nome = "Lucas";
// p1.Sobrenome = "Balduino";
// p1.Idade = 20;

// p1.Apresentar();