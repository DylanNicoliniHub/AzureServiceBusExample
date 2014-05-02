namespace MatterManager.Interfaces.Entities
{
    public interface IMatter
    {
         int Id { get; set; }
         string Name { get; set; }
         string NetworkMatterNumber { get; set; }
         string Workarea { get; set; }
         string ResponsibleProfessional { get; set; }
    }
}