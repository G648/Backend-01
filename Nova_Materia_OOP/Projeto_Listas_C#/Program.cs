using Projeto_Listas_C_;

//criar uma lista de objetos referenciando a classe Produto e criando a lista com o nome de listProduto
List<Produto> listProduto = new List<Produto>();

//CREATE

//inserir objetos de produtos dentro da lista
//através de uma instância direta (Construtor)
listProduto.Add(
    new Produto(1234, "camiseta fina", 19.99f)
);

//através de uma instância básica de objeto
Produto camisetaArmani = new Produto(1235, "camiseta armani", 45.56f);
listProduto.Add(camisetaArmani);


//READ
foreach (var item in listProduto)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");

}

//UPDATE
//acessar um objeto da lista para poder manipulá-lo
//objeto  nome da caixa   = encontrar produto ( função lambda = valor a procurar)
Produto produtoEncontrado = listProduto.Find(x => x.Nome == "camiseta armani");

//encontrar o índice do produto encontrado
int index = listProduto.IndexOf(produtoEncontrado);

//exibir o índice no console
Console.WriteLine($"O índice do produto encontrado é o : {index}");

//fazer alterações depois de ter encontrado o valor que estavamos trabalhando
produtoEncontrado.Nome = "camiseta polo larga ";

//remover o item antigo da lista
//aqui eu tenho que remover o que está no indice
listProduto.RemoveAt(index);

//devolver o item atualizado no lugar 
listProduto.Insert(index, produtoEncontrado);

Console.WriteLine($"Valor depois de atualizado");

foreach (var item in listProduto)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
    
}