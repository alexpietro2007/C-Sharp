Console.WriteLine("## Struct DateTime ##\n");

//Obtemos dados atuais do sistema
DateTime hoje = DateTime.Now;

//Criar uma data específica usa o formato: aaaa, mm, dd aqui o horairo vai ser 00:00:00 pois n foi especificado
DateTime dataHoje = new DateTime(2022, 09, 06);

//Definir as Horas, as horas são definidas usando o formato: aaaa, mm, dd, hh, mm, ss
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);

Console.WriteLine("------------------------------");
Console.WriteLine("Obtendo a Data Atual com DateTime:\n");
Console.WriteLine("Data Atual: " + hoje);
Console.WriteLine("------------------------------");
Console.WriteLine("Criando uma data específica:\n");
Console.WriteLine("Data Específica: " + dataHoje);
Console.WriteLine("Data com Hora: " + dataHoraHoje);
Console.WriteLine("------------------------------");
Console.WriteLine("Extraindo Informações Da Data de Hoje:\n");
Console.WriteLine("Ano: " + hoje.Year);
Console.WriteLine("Mês: " + hoje.Month);
Console.WriteLine("Dia: " + hoje.Day);
Console.WriteLine("Hora: " + hoje.Hour);
Console.WriteLine("Minuto: " + hoje.Minute);
Console.WriteLine("Segundo: " + hoje.Second);
Console.WriteLine("Milisegundo: " + hoje.Millisecond);
Console.WriteLine("------------------------------");
Console.WriteLine($"Adicionado valores a data Atual {hoje}:\n");
Console.WriteLine("Adicionando Dias: "+ hoje.AddDays(30));
Console.WriteLine("Adicionando Meses: "+ hoje.AddMonths(1));
Console.WriteLine("Adicionando Horas: "+ hoje.AddHours(2));
Console.WriteLine("Adicionando Anos: "+ hoje.AddYears(5));
Console.WriteLine("------------------------------");
Console.WriteLine("Obter dia da semana e do ano:\n");
Console.WriteLine("Dia da Semana: " + hoje.DayOfWeek);
Console.WriteLine("Dia do Ano: " + hoje.DayOfYear);
Console.WriteLine("------------------------------");
Console.WriteLine("Data no Formato Longo e Curto\n");
Console.WriteLine("Data Longa: " + hoje.ToLongDateString());
Console.WriteLine("Data Curta: " + hoje.ToShortDateString());
Console.WriteLine("------------------------------");
Console.WriteLine("Hora no Formato Longo e Curto\n");
Console.WriteLine("Hora Longa: " + hoje.ToLongTimeString());
Console.WriteLine("Hora Curta: " + hoje.ToShortTimeString());
Console.WriteLine("------------------------------");