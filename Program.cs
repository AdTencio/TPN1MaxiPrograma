using System;

namespace TPFinal_AdrianTournour
{
    class Program
    {
        static void Main(string[] args)
        {
//             Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

//                      a. El mayor de los números pares.
//                      b. La cantidad de números impares.
//                      c. El menor de los números primos.

//               Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

//               Entregar carpeta comprimida del proyecto con el TP resuelto.
//               Poner nombre tanto al proyecto como al zip: TPFinal_Apellido >> por ejemplo: TPFinal_SarFernandez

                    int n = -1, conIm = 0, MayorPar = 0, MenorPrimo = 0;
              

            while(n != 0){
                    Console.WriteLine("Ingrese un número: ");
                    n = int.Parse(Console.ReadLine());
                    if (FuncIm(n)){
                        conIm++; //Contar numeros impares

                    }
                    else {
                        if (n > MayorPar) //Almacenar Mayor par
                        MayorPar = n;
                        else continue;
                    };
                    if (FuncPrimo(n)){
                        if (MenorPrimo == 0){
                            MenorPrimo = n;
                        }
                        else if (MenorPrimo > n){
                            MenorPrimo = n;
                        }
                    }
                }
                Console.WriteLine("El mayor de los numeros pares es: " + MayorPar);
                Console.WriteLine("La cantidad de numeros impares es: " + conIm);
                Console.WriteLine("El menor numero primo es: " + MenorPrimo);

            static bool FuncIm(int n){
                    if (n % 2 == 1){
                        return true; 
                        }
                    else return false;
                    
            };
            static bool FuncPrimo(int n){
                    int con = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                            con++;   
                        
                        
                    }
                    if (con == 2) 
                    return true;
                    else 
                        return false;
            };






        }
    }
}
