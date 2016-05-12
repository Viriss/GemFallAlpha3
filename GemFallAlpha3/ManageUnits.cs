using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GemFallAlphaLib;
using Newtonsoft.Json;

namespace GemFallAlpha3
{
    public class ManageUnits
    {
        public oUnit CreateUnits()
        {
            oUnit x = new oUnit();
            x.Name = "Bob";
            x.Stats = new UnitStat() { Attack = 10, Defense = 10, Luck = 2, Magic = 2, Resistance = 4, MaxHealth = 20, MaxMana = 4 };
            x.Color = GemColor.Blue;
            x.CurMana = x.Stats.MaxMana;
            x.CurHealth = x.Stats.MaxHealth;

            return x;
        }
        public void CreateTeam()
        {
            oTeam team = new oTeam();
            team.UserName = "Andrew";
            team.Units.Add(CreateUnits());

            string u = "";
            u = JsonConvert.SerializeObject(team);

            StreamWriter sw = new StreamWriter("Team.json");
            sw.Write(u);
            sw.Close();
        }
        public oTeam LoadTeam()
        {
            StreamReader sr = new StreamReader("Team.json");
            string data = "";

            data = sr.ReadToEnd();

            oTeam team;
            team = JsonConvert.DeserializeObject<oTeam>(data);

            return team;
        }
    }
}
