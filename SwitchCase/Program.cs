// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Entre com numero para ver o dia da semana de 1 a 7:  ");
int day = int.Parse(Console.ReadLine());


    
    Console.WriteLine();
    
    switch (day) {
        case 1:
            Console.WriteLine("Sunday / Domingo");
            break;
        case 2:
            Console.WriteLine("Monday / Segunda-feira");
            break;
        case 3:
            Console.WriteLine("Tuesday / Terça-feira");
            break;
        case 4:
            Console.WriteLine("Wednesday / Quarta-feira");
            break;
        case 5:
            Console.WriteLine("Thursday / Quinta-feira");
            break;
        case 6:
            Console.WriteLine("Friday / Sexta-feira");
            break;
        case 7:
            Console.WriteLine("saturday / Sábado");
            break;
        default:
            Console.WriteLine("Número digitado inválido ");
            break;
    }
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Digite um nome para saber se a pessoa é linda ou feia ");
string name = Console.ReadLine();

switch (name) {
    case "thalles":
        Console.Write("Feio! ");
        break;
    case  "Thalles":
        Console.Write("Feio! ");
        break;
    default:
        Console.Write("Lindo(A)! ");
        break;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


