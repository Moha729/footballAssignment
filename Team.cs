
using System;
using System.Collections.Generic;


public class Team {

    public string Name { get; set;}

    public List<int> Statistics {get; set;}

    public Team (string name){
        Name = name;
        Statistics = new List<int>{0, 0, 0};
    }

    public override string ToString() {
        string stats = "";
        foreach (int stat in Statistics)
            stats += ","+stat;
        
        return $"{Name}{stats}";
    }
}