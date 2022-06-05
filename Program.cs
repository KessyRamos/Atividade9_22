double n1 = 10;
double n2 = 15;
double resto;

Console.WriteLine("Calcular o resto da divisão!!!");

resto = n1 % n2;

if (n2 == 0){
    Console.WriteLine("Não é possível realizar divisão por 0!");
}else{
    Console.Write($"O resto da divisão entre {n1} e {n2} é {resto}");
}

