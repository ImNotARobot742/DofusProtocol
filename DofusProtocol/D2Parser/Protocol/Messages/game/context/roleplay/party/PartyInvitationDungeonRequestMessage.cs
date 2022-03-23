

// Generated on 03/23/2022 09:50:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
    {
        public const uint Id = 3384;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        
        public PartyInvitationDungeonRequestMessage()
        {
        }
        
        public PartyInvitationDungeonRequestMessage(Types.AbstractPlayerSearchInformation target, uint dungeonId)
         : base(target)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            dungeonId = reader.ReadVarUShort();
        }
        
    }
    
}