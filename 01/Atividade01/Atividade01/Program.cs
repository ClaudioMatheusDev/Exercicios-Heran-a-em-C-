
using Atividade01;


Funcionario funcionario = new Funcionario("Claudio Matheus", 2200);
funcionario.addAumento(500);
Console.WriteLine("Dados do Funcionário: ");
Console.WriteLine();
funcionario.exibeDados();
Console.WriteLine($"Ganho anual: {funcionario.GanhoAnual()}");

Console.WriteLine();

Assistente assistente = new Assistente("Lucas Pereira", 2500, 1232);
assistente.addAumento(500);
Console.WriteLine("Dados do Assistente");
Console.WriteLine();
assistente.exibeDados();
Console.WriteLine($"Ganho anual: {assistente.GanhoAnual()}");

Console.WriteLine();

Tecnico tecnico = new Tecnico("Kathe", 2314, 2141, 313);
tecnico.addAumento(500);
Console.WriteLine("Dados da técnica");
Console.WriteLine();
tecnico.exibeDados();
Console.WriteLine($"Ganho anual: {tecnico.GanhoAnual()}");


