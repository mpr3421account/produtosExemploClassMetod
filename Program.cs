﻿using produtosExemploClassMetod;
using System.Globalization;



Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Console.Write("Quantidade no estoque: ");
//int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome,preco);

Console.WriteLine();

Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: " + p);