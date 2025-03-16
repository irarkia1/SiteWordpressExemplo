using System;
using System.Collections.Generic;

class aula55{
    static void Main(){
        Dictionary <int,string> nome = new Dictionary <int,string>();
            nome.Add(1,"ola");
            nome.Add(2,"mundo");


        foreach(var pair in nome){
            Console.WriteLine($"chave: {pair.Key}, valor: {pair.Value}");
        }
        

    }
}