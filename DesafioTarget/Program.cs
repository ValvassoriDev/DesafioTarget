
static void ExercicioUm()
{
    int INDICE = 13, SOMA = 0, K = 0;

    while (K < INDICE)
    {
        K = K + 1;
        SOMA = SOMA + K;
    }
    Console.WriteLine(SOMA);
}
ExercicioUm();

static void ExercicioDois() 
{
    int numero = 21;

    if (VerificarFibonacci(numero))
        Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
    else
        Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");


    static bool VerificarFibonacci(int num)
    {
        int a = 0;
        int b = 1;

        while (b < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == num;
    }
}
ExercicioDois();

/*
ExercicioTres

a) 1, 3, 5, 7, 9 (Lógica +2)

b) 2, 4, 8, 16, 32, 64, 128 (Lógica *2)

c) 0, 1, 4, 9, 16, 25, 36, 49 (Soma o proximo numero impar)

d) 4, 16, 36, 64, 100 (Quadrado do proximo numero par)

e) 1, 1, 2, 3, 5, 8, 13 (Sequencia de Fibonacci)

f) 2,10, 12, 16, 17, 18, 19, 200 (Sequencia de numeros naturais começando com D)

*/

/*
 ExercicioQuatro
Ligaria um dos interruptores e esperaria uns minutos, 
após isso desligaria e ligaria um segundo interruptor. 
Por ultimo, iria até a sala,  a lâmpada desligada e quente corresponderia ao primeiro interruptor, 
a lâmpada acesa ao segundo e a lâmpada apagada e fria ao terceiro.
*/


void ExercicioCinco()
{

    string stringOriginal = "Hello, world!";

    string stringInvertida = InverterString(stringOriginal);

    Console.WriteLine("Texto original: " + stringOriginal);
    Console.WriteLine("Texto invertido: " + stringInvertida);
    static string InverterString(string invert)
    {
        char[] caracteres = invert.ToCharArray();
        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temporaria = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temporaria;

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}
ExercicioCinco();