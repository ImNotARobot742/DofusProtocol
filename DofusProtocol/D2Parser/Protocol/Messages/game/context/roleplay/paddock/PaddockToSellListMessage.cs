

// Generated on 05/18/2023 16:28:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockToSellListMessage : NetworkMessage
    {
        public const uint Id = 7251;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint pageIndex;
        public uint totalPage;
        public Types.PaddockInformationsForSell[] paddockList;
        
        public PaddockToSellListMessage()
        {
        }
        
        public PaddockToSellListMessage(uint pageIndex, uint totalPage, Types.PaddockInformationsForSell[] paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)pageIndex);
            writer.WriteVarShort((short)totalPage);
            writer.WriteShort((short)paddockList.Length);
            foreach (var entry in paddockList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            pageIndex = reader.ReadVarUShort();
            totalPage = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            paddockList = new Types.PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockList[i] = new Types.PaddockInformationsForSell();
                 paddockList[i].Deserialize(reader);
            }
        }
        
    }
    
}