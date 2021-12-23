
using DevTeams_POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository // dev repo
{
    public class DeveloperRepository
    {
        private readonly List<Developer> _developerContext = new List<Developer>();
        private int _count;

        //Create 
        public bool AddDeveloper(Developer developer)
        {
            if (developer is null)
            {
                return false;
            }
            else
            {
                _count++;
                developer.ID = _count;
                _developerContext.Add(developer);
                return true;
            }
        }

       

        //Read

        public List<Developer> LookUpAllDevelopers()
        {
            List<Developer> foundDeveloper = new List<Developer>();
            foreach (Developer dev in _developerContext)
            {
                if (_developerContext != null)
                {
                    foundDeveloper.Add(dev);
                }
                else
                {
                    return null;
                }
            }
            return foundDeveloper;
        }

        // helper method returns one dev by id 

        public Developer LookupOneDveloper(int DevID)
        {
            foreach (Developer dev in _developerContext)
            {
                if (dev.ID == DevID)
                {
                    return dev;
                }
            }
            return null;
        }

        
        // Challenge list all devs who need pluransight license
        public List<Developer> LookUpDevelopersWhoNeedPluralsight()
        {
            List<Developer> foundDeveloper = new List<Developer>();
            foreach (Developer dev in _developerContext)
            {
                if(dev.HasPluralsight == true)
                {
                    foundDeveloper.Add(dev);
                }
                return foundDeveloper;
            }
            return null;
        }


        //Update
        public bool UpdateExistingDeveloper(int DevID, Developer updatedContent )
        {
            // was making this type List OK?  Had to do this to avoid type conflict fromn loopup1dev
            Developer oldContent = LookupOneDveloper(DevID); 
           if (oldContent != null)
            {
                // changeing type of dev to list is cause error with oldContent varaible
                oldContent.FirstName= updatedContent.FirstName;
                oldContent.LastName = updatedContent.LastName;
                oldContent.HasPluralsight = updatedContent.HasPluralsight;
                return true;
            }
           return false;
        }
       
        //Delete

        public bool DeleteExistingDeveloper (Developer ExistingDev)
        {
            bool deleteDevloper = _developerContext.Remove(ExistingDev);
            return deleteDevloper;

        }












    }


}















