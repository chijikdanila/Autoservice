using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Entities.Enums
{
    public enum RepairStatus
    {
        ServiceableOperated = 1,
        ServiceableNotExploit,
        FaultyBeingRepaired,
        DeffectiveCannotBeRepaired,
        Decommissioned,
    }
}
