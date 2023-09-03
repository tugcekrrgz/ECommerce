using ECommerce.Entity.Enum;
using ECommerce.Entity.Interface;

namespace ECommerce.Entity.Base
{
    public abstract class BaseClass : IEntity<Guid>
    {
        public BaseClass()
        {
            Status = Status.Active;
            CreatedDate = DateTime.Now;
            CreatedComputerName = Environment.MachineName;
            CreatedIpAddress = "192.161.1.1";//todo
            MasterID = Guid.NewGuid();
        }

        public int Id { get ; set ; }
        public Status Status { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string CreatedComputerName { get ; set ; }
        public string CreatedIpAddress { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public string? UpdatedComputerName { get ; set ; }
        public string? UpdatedIpAddress { get ; set ; }
        public Guid MasterID { get ; set ; }
        
    }
}
