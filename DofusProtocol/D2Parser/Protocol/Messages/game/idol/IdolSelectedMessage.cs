

// Generated on 03/23/2022 09:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdolSelectedMessage : NetworkMessage
    {
        public const uint Id = 2306;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool activate;
        public bool party;
        public uint idolId;
        
        public IdolSelectedMessage()
        {
        }
        
        public IdolSelectedMessage(bool activate, bool party, uint idolId)
        {
            this.activate = activate;
            this.party = party;
            this.idolId = idolId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteVarShort((short)idolId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            idolId = reader.ReadVarUShort();
        }
        
    }
    
}