using MatterManager.Interfaces.Entities;
using MatterManager.Interfaces.Repositories;

namespace MatterManager.Persistence
{
    public class MatterSqlRepository : IMatterRepository
    {
        private MatterManagerContext _context;

        public MatterSqlRepository(string connectionString)
        {
            _context = new MatterManagerContext(connectionString);
        }

        public void Create(IMatter matter)
        {
            _context.Matters.Add(new Matter
            {
                matter_name = matter.Name,
                network_matter_number = matter.NetworkMatterNumber,
                network_work_area = matter.Workarea,
                responsible_professional = matter.ResponsibleProfessional
            });

            _context.SaveChanges();
        }
    }
}