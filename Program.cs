
using DIO.Models;

int quantidadeEstoque = 10;
int quantidadeVenda = 4;
bool possivelVenda = quantidadeEstoque >= quantidadeVenda;

Console.WriteLine($"Quantidade em Estoque:{quantidadeEstoque}");
Console.WriteLine($"Quantidade Venda:{quantidadeVenda}");
Console.WriteLine($"É possivel realizar a venda:{possivelVenda}");


if (possivelVenda)
{
    Console.WriteLine("Venda Autorizada");
}
else
{
    Console.WriteLine("Venda não Autorizada");
}