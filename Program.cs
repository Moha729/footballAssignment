
using System;

class Program {

    static void Main (string[] args){
        print("hello");



        Table table = new Table();

        Team t1 = new Team ("Barcelona");
        Team t2 = new Team ("Inter");
        Team t3 = new Team ("United");

        table.Teams.Add(t1);
        table.Teams.Add(t2);
        table.Teams.Add(t3);    

        table.display();



        
    }



    static void print(string value){
        Console.WriteLine(value);
    }
}

