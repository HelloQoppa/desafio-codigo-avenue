using hospedagem.models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa = new Pessoa(nome: "Pedro", sobrenome: "Paulo");
Pessoa pessoa1 = new Pessoa(nome: "Luiz", sobrenome: "Alberto");

hospedes.Add(pessoa1);
hospedes.Add(pessoa);

var suite = new Suite("Deluxe", 1, 150.00m);

Reserva reserva = new Reserva(hospedes, suite, diasReservados: 5);
reserva.CadastarSuite(suite);
reserva.CadastarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"{reserva.CalcularValorDiaria()}");