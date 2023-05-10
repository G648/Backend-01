//     1. Crie uma classe denominada Elevador para armazenar as informações de um elevadordentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos: 
//Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de  andares no prédio (os elevadores sempre começam no térreo e vazio);

//  a- Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
//  b- Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
//  c- Subir : para subir um andar (não deve subir se já estiver no último andar);
//  d -Descer : para descer um andar (não deve descer se já estiver no térreo);
//  e- Encapsular todos os atributos da classe (criar os métodos set e get).    


using Lista_Exercicios_05._05;

Elevador elevador = new Elevador();

Console.Clear();
Console.WriteLine(@$"
===========================================
|                                          |
|Seja bem vindo ao programa de Elevadores  |
|                                          |
===========================================
");
do
{

    Console.WriteLine(@$"
    
     Selecione uma opção
[1] - Entrar no elevador;
[2] - Subir andares;
[3] - Descer andares;
[0] - Sair do elevador;
");

    elevador.escolhaMenu = int.Parse(Console.ReadLine());

    switch (elevador.escolhaMenu)
    {
        case 1:

            elevador.EntrarNoElevador(elevador.pessoasPresentesNoElevador);
            elevador.startOfLoop = true;

            break;
        case 2:

            elevador.SubirAndares(elevador.informeAndar);
            elevador.startOfLoop = true;

            break;
        case 3:
            elevador.DescerAndares(elevador.informeAndar);
            elevador.startOfLoop = true;

            break;
        case 4:

            elevador.startOfLoop = true;

            break;
        case 0:

            elevador.startOfLoop = false;

            break;
        default:
            break;
    }

} while (elevador.startOfLoop == true);