using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_POCOs
{
    public class DevTeam
    {

        public DevTeam(){}

        public DevTeam(string teamName, List<Developer> developers)
        {
            TeamName = teamName;
            Developers = developers; 
        }

        public int ID { get; set; }
        public string TeamName { get; set; }
        public List<Developer> Developers { get; set; }

    }
}
