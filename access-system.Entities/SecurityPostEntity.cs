using System.Collections.Generic;

namespace access_system.Entities
{
    public class SecurityPostEntity
    {
        public List<UserEntity> Users { get; set; }
        public List<ElectronicPassEntity> ElectronicPasses { get; set; }
    }
}
