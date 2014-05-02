using System.Collections.Generic;
using System.Linq;
using MatterManager.WebUi.Models;

namespace MatterManager.WebUi.Repositories
{
    public class MatterRepository : BaseRepository
    {
        public List<Matter> GetMatters()
        {
            return GetList<Matter>().Values.ToList();
        }

        public void Save(Matter matter)
        {
            Save<Matter>(matter);
        }
    }
}