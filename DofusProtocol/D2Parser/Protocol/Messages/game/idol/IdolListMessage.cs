

// Generated on 02/01/2023 12:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdolListMessage : NetworkMessage
    {
        public const uint Id = 5686;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] chosenIdols;
        public uint[] partyChosenIdols;
        public Types.PartyIdol[] partyIdols;
        
        public IdolListMessage()
        {
        }
        
        public IdolListMessage(uint[] chosenIdols, uint[] partyChosenIdols, Types.PartyIdol[] partyIdols)
        {
            this.chosenIdols = chosenIdols;
            this.partyChosenIdols = partyChosenIdols;
            this.partyIdols = partyIdols;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)chosenIdols.Length);
            foreach (var entry in chosenIdols)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)partyChosenIdols.Length);
            foreach (var entry in partyChosenIdols)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)partyIdols.Length);
            foreach (var entry in partyIdols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            chosenIdols = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 chosenIdols[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            partyChosenIdols = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyChosenIdols[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            partyIdols = new Types.PartyIdol[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyIdols[i] = ProtocolTypeManager.GetInstance<Types.PartyIdol>(reader.ReadUShort());
                 partyIdols[i].Deserialize(reader);
            }
        }
        
    }
    
}