using System;
using System.Collections.Generic;
using System.Text;

namespace InterweaveMobile.Repositories
{
    class ParticipantRepositoryFactory
    {
        public static IParticipantRepository GetParticipantRepository()
        {
            return new DemoParticipantRepository();
        }
    }
}
