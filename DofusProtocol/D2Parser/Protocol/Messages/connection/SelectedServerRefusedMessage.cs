

// Generated on 06/13/2023 16:59:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SelectedServerRefusedMessage : NetworkMessage
    {
        public const uint Id = 9623;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint serverId;
        public sbyte error;
        public sbyte serverStatus;
        
        public SelectedServerRefusedMessage()
        {
        }
        
        public SelectedServerRefusedMessage(uint serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)serverId);
            writer.WriteSbyte(error);
            writer.WriteSbyte(serverStatus);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            serverId = reader.ReadVarUShort();
            error = reader.ReadSbyte();
            serverStatus = reader.ReadSbyte();
        }
        
    }
    
}