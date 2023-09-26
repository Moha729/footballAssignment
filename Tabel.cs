using System;
using System.Collections.Generic;

public class Table {

    public List<Team> Teams {get; set;}

    public Table () {
        Teams = new List<Team>();
    }
    

    

    
    public void display(){

        foreach (Team team in Teams) {
            Console.WriteLine(team.Name);
        }
        
    }


}