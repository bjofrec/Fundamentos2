// See https://aka.ms/new-console-template for more information
class Program{
    static void Main()
    {
        PrintNumbers();
        PrintOdds();
        PrintSum();
        int[] numbers = {1,2,3};
        LoopArray(numbers);

        int[] numbers1 = {5, 12, 3, 10};
        int numeroMayor = FindMax(numbers1);
        Console.WriteLine($"El numero mayor de la matriz es: {numeroMayor}");

        int[] numbers2 = {2, 10, 3};
        int average = GetAverage(numbers2);
        Console.WriteLine($"El promedio de la matriz es {average}");

        List<int> numImpar = OddList();
        foreach(int o in numImpar){
            Console.WriteLine(o + " ");
        }

        List<int> lista1 = new List<int> {1, 3, 5, 7};
        int y = 3;
        int cont = GreaterThanY(lista1, y);
        Console.WriteLine($"La cantidad de valores mas grandes que y = {y}, son {cont}"); 

        List<int> numbers3 = new List<int> {1, 5, 10, -10};
        SquareArrayValues(numbers3);
        PrintList(numbers3);

        List<int> lista2 = new List<int> {1, 5, 10, -2};
        EliminateNegatives(lista2);
        PrintList2(lista2);

        
    }
    static void PrintNumbers(){
    for(int i = 1; i <= 255; i++){
        Console.WriteLine(i);
    }
    }

    static void PrintOdds(){
        for(int j = 1; j <= 255; j++){
            if(j % 2 != 0){
                Console.WriteLine(j);
            }
        }
    }

    static void PrintSum(){
        int suma = 0;
        for(int k = 0; k <= 255; k++){
            suma += k;
            Console.WriteLine($"New number: {k}, Sum: {suma}");

        }
    }

    static void LoopArray(int[] numbers){
        for(int l = 0; l < numbers.Length; l++){
            Console.WriteLine(numbers[l]);
        }
    }


    static int FindMax(int[] numbers1){
        if(numbers1 == null || numbers1.Length == 0){
            throw new ArgumentException("La matriz no puede estar vacia");
        }


        int numeroMayor = numbers1[0];
        for(int m = 1; m < numbers1.Length; m++){
            if(numbers1[m] > numeroMayor){
                numeroMayor = numbers1[m];
            }
        }

        return numeroMayor;
    }

    static int GetAverage(int[] numbers2){
       int suma = numbers2[0];
       for(int n = 1; n < numbers2.Length; n++){
        suma += numbers2[n];                         
       }
        int average = suma / numbers2.Length;
        return average;
    }
    static List<int> OddList(){
        List<int> numImpar = new List<int>();
        for(int o = 1; o <= 255; o += 2){
            numImpar.Add(o);

        }
        return numImpar;
    }

    static int GreaterThanY(List<int> lista1, int y){
        int cont = 0;
        foreach(int valor in lista1){
            if(valor > y){
                cont++;
            }
        }
        return cont;
    }

    static void SquareArrayValues(List<int> lista2){
        for (int p = 0; p < lista2.Count; p++){
            lista2[p] = lista2[p] * lista2[p];
        }
    }

    static void PrintList(List<int> lista2){
        foreach (int numero in lista2)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }

    static void EliminateNegatives(List<int> numbers4){
        for(int q = 0; q < numbers4.Count; q++){
            if(numbers4[q] < 0){
                numbers4[q] = 0;
            }
        }
    }
    static void PrintList2(List<int> numbers4){
        foreach(int numero in numbers4){
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
    
    


