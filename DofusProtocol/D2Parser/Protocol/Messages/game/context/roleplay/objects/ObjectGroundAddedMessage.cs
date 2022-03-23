

// Generated on 03/23/2022 09:50:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectGroundAddedMessage : NetworkMessage
    {
        public const uint Id = 8096;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        public uint objectGID;
        
        public ObjectGroundAddedMessage()
        {
        }
        
        public ObjectGroundAddedMessage(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)cellId);
            writer.WriteVarShort((short)objectGID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadVarUShort();
            objectGID = reader.ReadVarUShort();
        }
        
    }
    
}