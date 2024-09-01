using Atividade03.Entidades;

Novo imovelNovo = new Novo("Alameda Curitiba, 445", 241415, 50000);
Console.WriteLine("Dados do Imóvel Novo:");
Console.WriteLine($"Endereço: {imovelNovo.Endereco}");
Console.WriteLine($"Preço Base: {imovelNovo.Preco}");
Console.WriteLine($"Adicional no Preço: {imovelNovo.AdicionalPreco}");
Console.WriteLine($"Preço Total: {imovelNovo.PrecoImovel()}");
Console.WriteLine();


Velho imovelVelho = new Velho("Avenida dos velhinhos, 412", 250000, 30000);
Console.WriteLine("Dados do Imóvel Velho:");
Console.WriteLine($"Endereço: {imovelVelho.Endereco}");
Console.WriteLine($"Preço Base: {imovelVelho.Preco}");
Console.WriteLine($"Desconto no Preço: {imovelVelho.DescontoPreco}");
Console.WriteLine($"Preço com Desconto: {imovelVelho.PrecoImovel()}");