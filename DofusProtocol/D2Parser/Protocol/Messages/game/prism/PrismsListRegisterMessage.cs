

// Generated on 01/01/2022 14:39:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismsListRegisterMessage : NetworkMessage
    {
        public const uint Id = 4105;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte listen;
        
        public PrismsListRegisterMessage()
        {
        }
        
        public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(listen);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            listen = reader.ReadSbyte();
        }
        
    }
    
}