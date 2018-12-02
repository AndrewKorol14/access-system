using System.Collections.Generic;

namespace access_system.Entities
{
    class SecurityPostEntity
    {
        private List<User> _users;
        private List<ElectronicPass> _electronicPasses;

        public SecurityPostEntity()
        {
            _users = new List<User>();
            _electronicPasses = new List<ElectronicPass>();
        }
    }
}
