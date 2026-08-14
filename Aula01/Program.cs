//int anosAutonomia = 450;
//double capacidadeBateria = 75.5;
//string modeloVeiculo = "Byd";
//bool carregamentoRapido = true;

//Console.WriteLine($"Veículo: {modeloVeiculo}");
//Console.WriteLine($"Autonomia: {anosAutonomia} Km | Bateria: {capacidadeBateria} Kmh");
//Console.WriteLine($"Possui Carregamento Rápido: {carregamentoRapido}");

////Verificar quanto pagar de imposto ao comprar um carro Elétrico

//const double juros = 0.10; // 10%
//double precoVeiculo = 20000.00;

//double valorImposto = precoVeiculo * juros;
//Console.WriteLine($"O valor do Imposto é R$ {valorImposto:N2}");

string nomeCliente = "Gabriel";
int idadeCliente = 16;
int valorBike = 1500;
string modeloBike = "Raio";
bool clienteAtivo = true;

Console.WriteLine($"Nome do cliente: {nomeCliente}");
Console.WriteLine($"Idade do Cliente: {idadeCliente}");
Console.WriteLine($"Modelo da bicicleta: {modeloBike}");
Console.WriteLine($"O cliente está ativo?: {clienteAtivo}");

const double jurosBike = 0.10;
double valorImpostoBike = valorBike * jurosBike;

Console.WriteLine($"O valor do Imposto da bicicleta é R$ {valorImpostoBike}");