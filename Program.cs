
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
        Team t6 = new("FCK");

        table.Teams.Add(t1);
        table.Teams.Add(t2);
        table.Teams.Add(t3);  
        table.Teams.Add(t4);  
        table.Teams.Add(t5);  
        table.Teams.Add(t6);  
        
        //Program can write to file
        UpdateTabelToFile(table.Teams);

        //Program can create Rounds full of matches
        //Program makes all the matches from 1 - however
        //The algorithm says from 1 - however is round 1 etc.

        List<Match> matches = new();

        int Y = table.Teams.Count();
        int i = 0;
        int j = Y - (Y - (i + 1));
        int roundCount = 1;

        for (i = 0; i < (Y - 1); i++){
            //roundCount = 1 + i;
            //Console.WriteLine(Y-1+"for y and i:"+i);
            //if(roundCount < (Y - i)) roundCount = 1;
            for (j = Y - (Y - (i + 1)); j < Y; j++){

            Console.WriteLine("j:"+j);
                matches.Add(new(roundCount, table.Teams[i], table.Teams[j]));
                //roundCount = ((roundCount % (Y - 1)) + 1);
                roundCount += 1;
                //if(j == Y) roundCount = 1;
            };
        }

        foreach (Match match in matches)
        {
            print(match.RoundCount + ": " + match.TeamA+" vs. "+match.TeamB);
        }

        //Sort matches in rounds
        //each team has to be represented in a round once!
        //a how many matches are there in each round? table.count / 2




        table.Display();

        Match m1 = new(t1, t2, 2, 3);

        table.UpdateTable(m1);

        UpdateTabelToFile(table.Teams);
        
    }

    static void UpdateTabelToFile (List<Team> teams){

        string FilePath_TeamsCSV = "teams.csv";

        using StreamWriter streamWriter = new(FilePath_TeamsCSV);
        foreach (Team team in teams)
        {
            streamWriter.WriteLine(team.ToString());
        }
    }



    static void print(string value){
        Console.WriteLine(value);
    }
}

