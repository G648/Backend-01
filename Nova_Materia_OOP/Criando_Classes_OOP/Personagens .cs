using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Criando_Classes_OOP
{
    public class Personagens 
    {
        //primeiro definir os atributos (caracteristicas)
        List <Personagens> listaPersona = new List<Personagens>();
        public string nome;
        public int idade;
        public string armadura;
        public string IA;

        public void Atacar(){
            Console.WriteLine($"O personagem {nome} acabou de Atacar o adversário;");
            
        }

        public void Defender(){
            Console.WriteLine($"O personagem  {nome} acabou de defender");
            
        }

        public void RestaurarArmadura(){
            Console.WriteLine($"O personagem {nome} acabou de restaurar a armadura!");
            
        }
    }
}