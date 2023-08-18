
Console.WriteLine("Digite a idade do indivíduo em dias.");

int idade, anos, meses, dias;

idade = int.Parse(Console.ReadLine());
anos = idade / 365;
meses = idade % 365/30;
dias = idade % 365%30;

Console.WriteLine("O indivíduo tem:");
Console.WriteLine(anos+" ano(s)");
Console.WriteLine(meses+" mes(es)");
Console.WriteLine(dias+" dia(s)");

