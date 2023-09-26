using System;
using System.Collections.Generic;

public class Table {

    public List<Team> Teams {get; set;}

    public Table () {
        Teams = new();
    }
    public void Display(){

        foreach (Team team in Teams) {
            Console.WriteLine(team.Name);
        }
    }

    public void UpdateTable (Match match) {
/*         Team teamA = new("Real");
        Team teamB = new("Juve");
        int aSocre = 1;
        int bScore = 2;
 */
        Team teamA = match.TeamA;
        Team teamB = match.TeamB;
        int aSocre = match.Ascore;
        int bScore = match.Bscore;
        //update information about a team
        //each team has a list of integers, they represent the stats
        //get this list
        List<int> aStats = teamA.Statistics;
        List<int> bStats = teamB.Statistics;
        //update their values one by one
        if(aSocre > bScore) {
            aStats[0] ++;
            bStats[2] ++;
            }
        else if(bScore > aSocre){
            aStats[2] ++;
            bStats[0] ++;
        } else {
            aStats[1] ++;
            bStats[1] ++;
        } 

                

        Console.Write($"{teamA.Name} stats: ");
        foreach (int stats in aStats)
        {
            Console.Write(stats + " ");
        }

        Console.Write($"{teamB.Name} stats: ");
        foreach (int stats in bStats)
        {
            Console.Write(stats + " ");
        }

    }


}