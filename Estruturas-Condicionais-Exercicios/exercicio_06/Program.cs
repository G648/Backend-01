// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado

//entrada de dados
// = inserir a média dos aluno --ok 
// = inserir a frequencia do aluno --ok

//procesasmento de dados
// = primeiro determinar a frequencia do aluno, se for menor que 75% ele será automaticamente reprovado; -- ok
// = depois realizar a média do aluno e determinar se ele vai passar com base na média e na frequência do aluno; --ok
// = se a média foi maior igual a 7 e frequencia maior ou igual a 75% então ele será aprovado também; --ok
// = se a frequencia do aluno for de 75% e uma média entre 3 e 7 então ele vai para a recuperaçã; --ok

//saida de dados
// = mostrar se o aluno foi aprovado ou reprovado com base na frequencia dele
// = mostrar se o aluno foi aprovado ou reprovado com base na frequencia e na média dele
// = mostrar se o aluno está de recuperação com base na frequencia e na média dele


int media = 7;
int mediaAluno;
int frequencia = 75;
int frequenciaAluno;

Console.WriteLine($"Por gentileza, informe a média do aluno: ");
mediaAluno = int.Parse(Console.ReadLine());

Console.WriteLine($"Por gentileza, informe a frequência do aluno: ");
frequenciaAluno = int.Parse(Console.ReadLine());

if (frequenciaAluno < frequencia)
{
    Console.WriteLine($"O aluno foi reprovado com sucesso por não ter a frequencia suficiente");
}
else if (mediaAluno >= media && frequenciaAluno >= frequencia)
{
    Console.WriteLine($"O aluno foi aprovado com média e frequencia ok");

}
else if (mediaAluno > 3 )
{
    Console.WriteLine($"o aluno está de recuperação por não ter alcançado a média suficiente, porém está com a frequencia ok");
}
else
{
    Console.WriteLine($"o aluno está reprovado");   
}