

// Generated on 01/01/2022 14:39:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ActivityHideRequestMessage : NetworkMessage
    {
        public const uint Id = 9127;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint activityId;
        
        public ActivityHideRequestMessage()
        {
        }
        
        public ActivityHideRequestMessage(uint activityId)
        {
            this.activityId = activityId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)activityId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            activityId = reader.ReadVarUShort();
        }
        
    }
    
}