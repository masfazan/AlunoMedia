//float nota1, nota2, media;

Console.WriteLine("Digite a nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota: ");
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

if (media <= 3)
{
    Console.WriteLine("Reprovado");
}
else
if (media < 5)
{
    Console.WriteLine("Exame");
}
else
{
    Console.WriteLine("Aprovado");
}
Console.ReadLine();