 do{
    Menu();
} while (true);

static void Menu(){

    Console.Clear();

    Console.WriteLine("Qual operação você deseja realizar?");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("------------------------------------");
    Console.WriteLine(" ");

    Console.WriteLine("Selecione uma opção: ");
    short opcao = short.Parse(Console.ReadLine());

    switch(opcao){
        case 1: 
            Soma();
        break;

        case 2:
            Subtracao();
        break;

        case 3:
            Divisao();
        break;

        case 4:
            Multiplicacao();
        break;

        case 5:
            System.Environment.Exit(0);
        break;

        default:
            Menu();
        break;
    }


}

static void Soma(){

    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");

    /* Usando o ReadLine o retorno é sempre uma string, é preciso fazer a conversão com o Parse. */

    float v1 = float.Parse(Console.ReadLine()); 

    Console.WriteLine(" ");

    Console.WriteLine("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 + v2; 
    Console.WriteLine($"O resultado da soma é: {resultado}");

    // Console.WriteLine("O resultado da soma é: " + resultado);
    // Console.WriteLine($"O resultado da soma é: {v1 + v2}" );
    // Console.WriteLine("O resultado da soma é: " + (v1 + v2));

    Console.WriteLine("Pressione qualquer tecla para continuar...");

    /* Esse comando não para a execução do programa, só para após o uso do ctrl + c.*/
    Console.ReadKey();
}

static void Subtracao(){

    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine()); 

    Console.WriteLine(" ");

    Console.WriteLine("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 - v2; 
    Console.WriteLine($"O resultado da subtração é: {resultado}");

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}

static void Divisao(){

    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine()); 

    Console.WriteLine(" ");

    Console.WriteLine("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 / v2; 
    Console.WriteLine($"O resultado da divisão é: {resultado}");

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}

static void Multiplicacao(){

    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine()); 

    Console.WriteLine(" ");

    Console.WriteLine("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 * v2; 
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}