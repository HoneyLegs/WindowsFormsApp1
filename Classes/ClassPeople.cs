using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinFormsApp1.Classes
{
    public class People
    {
        public string Name, Surname;
        public string Team;
        public string House;
        public int RoomID;
        public string Age;
        public bool InRoom;

        public People()
        {
            this.Name = "";
            this.Surname = "";
            this.Team = "";
            this.House = "";
            this.RoomID = 0;
            this.Age = "";
            this.InRoom = false;
        }

        public Dictionary<string,List<People>> ToTeamDictionary(List<People> peoples)
        {
            var Teams = new Dictionary<string, List<People>>();
            foreach (People people in peoples)
            {
                if (!Teams.ContainsKey(people.Team))
                {
                    Teams.Add(people.Team, new List<People>());
                }
                Teams[people.Team].Add(people);
            }
            return Teams;
        }

        public void PrintDebug()
        {
            Debug.WriteLine(Surname + Name);
        }
    }
}