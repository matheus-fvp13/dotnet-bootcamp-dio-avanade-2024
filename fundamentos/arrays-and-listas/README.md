# Arrays e Listas

## O que é um array?
O array é uma estrutura de dados que armazena de forma contígua na memória valores de um mesmo tipo e que possui um número de elementos fixo.
- Os dados são indexados através de um índice numérico.
- Recuperar ou salvar em uma posicão específica é uma operação constante, basta utilizar o indice do elemento desejado.

### Declaração de um Array em C#
```c#
int[] array = new int[4];
int[] array2 = new int[]{42, 75, 45, 67}
string[] meses = {"Janeiro", "Fevereiro"}
```

### Recuperando dados de um array
```c#
meses[0]; //Janeiro
meses[1]; // Fevereiro
meses[1] = "Março"; //Fevereiro -> Março
```
