using DevTeams_POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository //dev team repo
{
    public class DeveloperTeamRepository
    {
        private readonly List<DevTeam> _devTeamsContext = new List<DevTeam>();
        private DeveloperRepository _devRepo;
        private int _count;

        public DeveloperTeamRepository(DeveloperRepository devRepo)
        {
            _devRepo = devRepo;
        }

        //Create 

        public bool AddContentToInventory()
        {
            return true;
        }

        public bool AddContentToInventory(DevTeam content)
        {
            if (content == null)
            {
                return false;
            }
            else
            {
                _count++;
                content.ID = _count;
                _devTeamsContext.Add(content);
                return true;    
            }
        }

        //Read 
        public List<DevTeam> GetAllTeams()
        {
            return _devTeamsContext;
        }

        public DevTeam GetOneTeam(int TeamID)
        {
            foreach (DevTeam team in _devTeamsContext)
            {
                if (team.ID == TeamID)
                    return team;
            }
            return null;
        }

        // Update 

        public bool UpdateDevTeam(int id, DevTeam team)
        {
            DevTeam devTeam =  GetOneTeam(id);

            if (devTeam != null)
            {
                devTeam.TeamName = team.TeamName;
                devTeam.Developers = team.Developers;
                return true;
            }
            return false;
        }


        public bool AddMultipleDevelopers(int teamID, List<Developer> developers)
        {
            DevTeam devTeam = GetOneTeam(teamID);
            if (devTeam != null)
            {
                devTeam.Developers.AddRange(developers);
                return true;
            }
            return false;

        }

        // Delete 

        // 

        public bool AddDevloperToTeam(int teamID, int devID)
        {
            DevTeam devTeam = GetOneTeam(teamID);

            if (devTeam == null)
            {
                return false;
            } 
            Developer developer = _devRepo.LookupOneDveloper(devID);
            if (developer == null)
            {
                return false;
            }
            devTeam.Developers.Add(developer);
            return true;

        }


        public bool AddMultipleDevelopersToTeam(int teamID, List<Developer> developers)
        {
            DevTeam devTeam = GetOneTeam(teamID);

            if (devTeam == null)
            {
                return false;
            }
            devTeam.Developers.AddRange(developers);
            return true;
        }
    }
}
