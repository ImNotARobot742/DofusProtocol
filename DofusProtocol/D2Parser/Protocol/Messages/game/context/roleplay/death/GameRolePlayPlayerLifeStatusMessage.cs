

// Generated on 06/13/2023 16:59:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
    {
        public const uint Id = 240;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte state;
        public double phenixMapId;
        
        public GameRolePlayPlayerLifeStatusMessage()
        {
        }
        
        public GameRolePlayPlayerLifeStatusMessage(sbyte state, double phenixMapId)
        {
            this.state = state;
            this.phenixMapId = phenixMapId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(state);
            writer.WriteDouble(phenixMapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            state = reader.ReadSbyte();
            phenixMapId = reader.ReadDouble();
        }
        
    }
    
}