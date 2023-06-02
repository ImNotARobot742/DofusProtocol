

// Generated on 06/02/2023 19:00:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameContextCreateMessage : NetworkMessage
    {
        public const uint Id = 7801;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte context;
        
        public GameContextCreateMessage()
        {
        }
        
        public GameContextCreateMessage(sbyte context)
        {
            this.context = context;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(context);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            context = reader.ReadSbyte();
        }
        
    }
    
}