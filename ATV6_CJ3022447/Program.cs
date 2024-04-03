namespace ATV6_CJ3022447
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int n = 0;
            int contador = 1;

            Console.WriteLine("Até q número deseja contar?");
            n = int.Parse(Console.ReadLine());
            while (contador <= n)
                Console.WriteLine("{0}", contador);
            n++;
            

            int i, numero;

            Console.WriteLine("digite um numero");
            numero = int.Parse(Console.ReadLine());
            i = 1;
            while (i <= numero)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            
            int i, numer;

            Console.WriteLine("digite um numero menor que 1000");
            numer = int.Parse(Console.ReadLine());
            i = 1;
            while (i <= numer)
            {
                if (i == 1000 || i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            

            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Os divisores de {numero} são:");

            int divisor = 1;
            while (divisor <= numero)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                }
                divisor++;
            
            int contador = 1;
            int maior, menor;

            Console.Write($"Digite o {contador}º número: ");
            int numero = int.Parse(Console.ReadLine());

            maior = numero;
            menor = numero;

            contador++;

            while (contador <= 10)
            {
                Console.Write($"Digite o {contador}º número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                contador++;
            }

            Console.WriteLine($"O maior número digitado foi: {maior}");
            Console.WriteLine($"O menor número digitado foi: {menor}");
            */
            int somaPares = 0;
            int somaImpares = 0;

            Console.WriteLine("Digite uma sequência de números inteiros (digite 0 para parar):");

            int numero;
            do
            {
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero % 2 == 0)
                    {
                        somaPares += numero;
                    }
                    else
                    {
                        somaImpares += numero;
                    }
                }

            } while (numero != 0);

            Console.WriteLine($"A soma dos números pares é: {somaPares}");
            Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");
        }
    }
}
    









