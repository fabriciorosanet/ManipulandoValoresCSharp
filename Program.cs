using ManipulandoValores.Models;
using System.Globalization;


Pessoa pessoa1 = new Pessoa(name: "Fabricio", lastname: "Rosa");
Pessoa pessoa2 = new Pessoa(name: "Bianca", lastname: "Silva");


Curso cursoOfIngles = new Curso();
cursoOfIngles.Name = "Ingles";
cursoOfIngles.Student = new List<Pessoa>();

cursoOfIngles.AddStudent(pessoa1);
cursoOfIngles.AddStudent(pessoa2);
cursoOfIngles.ListStudent();

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 145672320.00M;

Console.WriteLine($"{valorMonetario:C}");

double porcetagem = .3421;

Console.WriteLine(porcetagem.ToString("P"));

int numero = 543210;

Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;
DateTime data1 = DateTime.Parse("11/11/1970 15:20");

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(data.ToShortTimeString());

Console.WriteLine(data.ToShortDateString());


string dataString = "17-04-2024 17:00";

DateTime.TryParseExact(dataString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2);

//DateTime data2 = DateTime.Parse (dataString);
Console.WriteLine(data2);