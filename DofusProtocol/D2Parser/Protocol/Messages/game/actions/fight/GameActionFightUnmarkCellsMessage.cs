

// Generated on 02/01/2023 12:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightUnmarkCellsMessage : AbstractGameActionMessage
    {
        public const uint Id = 8111;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short markId;
        
        public GameActionFightUnmarkCellsMessage()
        {
        }
        
        public GameActionFightUnmarkCellsMessage(uint actionId, double sourceId, short markId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(markId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            markId = reader.ReadShort();
        }
        
    }
    
}