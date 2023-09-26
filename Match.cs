
using System;

public class Match {

    public Round Round {get; set;}

    public Team TeamA {get; set;}

    public Team TeamB {get; set;}


    public int Ascore {get; set;}
    
    public int Bscore {get; set;}

    public Match (Team teamA, Team teamB, int aScore, int bScore){
        TeamA = teamA;
        TeamB = teamB;
        Ascore = aScore;
        Bscore = bScore;
    }

    public void UpdateTable(){ //den skal sende værdier i en tuble
        //return team_A
        //return team_B
        //return A_socre
        //return B_score
        //table uses these values to update it self

    }
}