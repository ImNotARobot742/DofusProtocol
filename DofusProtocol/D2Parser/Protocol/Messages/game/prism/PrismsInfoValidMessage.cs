

// Generated on 03/23/2022 09:50:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismsInfoValidMessage : NetworkMessage
    {
        public const uint Id = 4883;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.PrismFightersInformation[] fights;
        
        public PrismsInfoValidMessage()
        {
        }
        
        public PrismsInfoValidMessage(Types.PrismFightersInformation[] fights)
        {
            this.fights = fights;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)fights.Length);
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            fights = new Types.PrismFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fights[i] = new Types.PrismFightersInformation();
                 fights[i].Deserialize(reader);
            }
        }
        
    }
    
}