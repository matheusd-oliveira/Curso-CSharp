// Mês de Abril - O evento precisa iniciar e terminar dentro de Abril.
// Quanto tempo esse evento vai durar?
/* Exemplo:
 * Dia x
 * hh : mm : ss
 * Dia y
 * hh : mm : ss
 */

// Criando variáveis importantes
using System.Diagnostics;

int resto, quantidadeDeDias, tempoEmSegundos, diaDeInicio, diaDoTermino, horas, minutos, segundos;


// Lendo o dia de inicio do evento
Console.Write("Dia ");
diaDeInicio = int.Parse(Console.ReadLine());

string[] vetHorario = Console.ReadLine().Split(':');
horas = int.Parse(vetHorario[0]);
minutos = int.Parse(vetHorario[1]);
segundos = int.Parse(vetHorario[2]);

// Armazenando a data inicial
var data1 = new DateTime(2023, 04, diaDeInicio, horas, minutos, segundos);

// Lendo o dia de término do evento
Console.Write("Dia ");
diaDoTermino = int.Parse(Console.ReadLine());
vetHorario = Console.ReadLine().Split(':');
horas = int.Parse(vetHorario[0]);
minutos = int.Parse(vetHorario[1]);
segundos = int.Parse(vetHorario[2]);

// Armazenando a data final
var data2 = new DateTime(2023, 04, diaDoTermino, horas, minutos, segundos);

// Criando o TimeSpan para saber a diferença entre as datas.
TimeSpan diferencaDosDias = data2 - data1;


// Calculando o tempo passado
Console.WriteLine($"{((int)Math.Abs(diferencaDosDias.TotalDays))} dia(s)");
Console.WriteLine($"{(int)diferencaDosDias.TotalHours <= 24} hora(s)");
Console.WriteLine($"{(int)diferencaDosDias.TotalMinutes <= 60} minuto(s)");
Console.WriteLine($"{(int)diferencaDosDias.TotalSeconds <= 60} segundo(s)");

Console.ReadKey();

