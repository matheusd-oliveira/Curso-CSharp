// Mês de Abril - O evento precisa iniciar e terminar dentro de Abril.
// Quanto tempo esse evento vai durar?
/* Exemplo:
 * Dia x
 * hh : mm : ss
 * Dia y
 * hh : mm : ss
 */

// Criando variáveis importantes
int diaDeInicio, diaDoTermino, horas, minutos, segundos;


// Lendo o dia de inicio do evento
string[] dia = Console.ReadLine().Split(' ');
diaDeInicio = int.Parse(dia[1]);

string[] vetHorario = Console.ReadLine().Trim().Split(':');
horas = int.Parse(vetHorario[0]);
minutos = int.Parse(vetHorario[1]);
segundos = int.Parse(vetHorario[2]);

// Armazenando a data inicial
var data1 = new TimeSpan(diaDeInicio, horas, minutos, segundos);

// Lendo o dia de término do evento
dia = Console.ReadLine().Split(' ');
diaDoTermino = int.Parse(dia[1]);
vetHorario = Console.ReadLine().Trim().Split(':');
horas = int.Parse(vetHorario[0]);
minutos = int.Parse(vetHorario[1]);
segundos = int.Parse(vetHorario[2]);

// Armazenando a data final em um TimeSpan
var data2 = new TimeSpan(diaDoTermino, horas, minutos, segundos);

// Criando o TimeSpan para saber a diferença entre as datas
TimeSpan diferencaDosDias = data2 - data1;


// Mostrando o tempo passado
Console.WriteLine($"{diferencaDosDias.Days} dia(s)");
Console.WriteLine($"{diferencaDosDias.Hours} hora(s)");
Console.WriteLine($"{diferencaDosDias.Minutes} minuto(s)");
Console.WriteLine($"{diferencaDosDias.Seconds} segundo(s)");

Console.ReadKey();

