// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI.models;

Console.WriteLine("Hello, World!");

//Instanciar um Aluno
Aluno aluno = new Aluno();
//Atribuir o nome ao aluno
aluno.Nome = "Luís Felipe";
aluno.Cpf = "12345678912";
//Exibir o nome
Console.WriteLine(aluno.Nome);

// PRATICANDO
Cachorro cao = new Cachorro();
cao.Genero = "Macho";
cao.Idade = 4;
cao.Peso = 5.6;
cao.Raca = "Golden Retriver";
cao.Nome = "Thor";
cao.Dono = "Thiago";

Console.WriteLine("Nome do Dono: " + cao.Dono + "\nNome do Cachorro: " + cao.Nome + 
    "\nRaca do Cachorro: " + cao.Raca + "\nGenero do Cachorro " + cao.Genero + 
    "\nIdade do Cachorro: " + cao.Idade + "\nPeso do Cachorro " + cao.Peso);