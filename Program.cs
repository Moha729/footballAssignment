
using System;
using System.IO;

class Program {

    static void Main (string[] args){
        print("hello");

        Table table = new();



        Team t1 = new("Barcelona");
        Team t2 = new ("Inter");
        Team t3 = new("United");
        Team t4 = new("Real");
        Team t5 = new("Juve");

        table.Teams.Add(t1);
        table.Teams.Add(t2);
        table.Teams.Add(t3);  
        
        //Program can write to file
        updateTabelToFile(table.Teams);



        table.Display();

        Match m1 = new(t1, t2, 2, 3);

        table.UpdateTable(m1);

        updateTabelToFile(table.Teams);
        
    }

    static void updateTabelToFile (List<Team> teams){

        string FilePath_TeamsCSV = "teams.csv";

        using(StreamWriter streamWriter = new(FilePath_TeamsCSV)){

            foreach (Team team in teams)
            {
                streamWriter.WriteLine(team.ToString());
            }
        }
    }



    static void print(string value){
        Console.WriteLine(value);
    }
}

