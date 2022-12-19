
using ConsoleApp1;

Console.WriteLine("Exercicio 1");

Console.WriteLine("Digite um valor em reais para conversão em dolar : ");

var real = Console.ReadLine();

if (real.Contains('.'))
{
    real = real.Replace(".", ",");
}

var resultado = MetodosExercicios.ConverteDeRealParaDolar(Convert.ToDecimal(real));

Console.WriteLine($"O valor em dolar é : {resultado.ToString("C")}");

// Fim Ex. 1

Console.WriteLine("Exercicio 2");

Console.WriteLine("Digite uma sequência numerica");

var sequencia = Console.ReadLine();

var resultado2 = MetodosExercicios.MostraNumero(sequencia);

Console.WriteLine($"O número que mais se repete é esse : {resultado2}");

//Fim Ex 2:

Console.WriteLine("Exercicio 3");
Console.WriteLine("Escolha o seu Pedido: Para escolher digite a quantidade do produto que voce quer. Se não quiser o produto digite 0");

Console.WriteLine("1: lanche de carne:");

var lanchecarne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2: lanche de frango:");

var lanchefrango = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3: batata frita:");

var batata = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("4: Refrigerante:");

var refrigerante = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("5: salada:");

var salada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("6: maionese:");

var maionese = Convert.ToInt32(Console.ReadLine());

var Pedido = new ProdutosLanchonete()
{
    LancheCarne = lanchecarne > 0 ? lanchecarne * 20 : 0,
    LancheFrango = lanchefrango > 0 ? lanchefrango * 16 : 0,
    Batafrita = batata > 0 ? batata * 6 : 0,
    Refrigerante = refrigerante > 0 ? refrigerante * 4 : 0,
    Salada = salada > 0 ? salada * 2 : 0,
    Maionese = maionese

};

var resultado4 = Pedido.CalculaValorLanche(Pedido);

Console.WriteLine($"O valor total do seu pedido é : {resultado4.ToString("C")} ");

// Fim Ex 3:

// Ex 4
MetodosExercicios.ExPalindromoCorrecao();
// Fim Ex4

// Ex 5
MetodosExercicios.Golomb(5);