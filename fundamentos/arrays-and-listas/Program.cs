var inteiros = new int[10]; 

for(int i = 0; i < inteiros.Length; i++) {
    inteiros[i] = (i + 1) * 2;
}

Console.WriteLine("Tabuada do 2");
for(int i = 0; i < inteiros.Length; i++) {
    Console.WriteLine($"{i + 1} * 2 = {inteiros[i]}");
}