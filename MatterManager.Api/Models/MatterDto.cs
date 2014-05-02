using MatterManager.Interfaces.Entities;

namespace MatterManager.Api.Models
{
    public class MatterDto :IMatter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NetworkMatterNumber { get; set; }
        public string Workarea { get; set; }
        public string ResponsibleProfessional { get; set; }
    }
}