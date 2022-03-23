

// Generated on 03/23/2022 09:51:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FinishMoveInformations
    {
        public const short Id = 9080;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int finishMoveId;
        public bool finishMoveState;
        
        public FinishMoveInformations()
        {
        }
        
        public FinishMoveInformations(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
        }
        
    }
    
}