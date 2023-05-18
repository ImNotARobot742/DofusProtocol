

// Generated on 05/18/2023 16:28:51
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseToSellListMessage : NetworkMessage
    {
        public const uint Id = 4025;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint pageIndex;
        public uint totalPage;
        public Types.HouseInformationsForSell[] houseList;
        
        public HouseToSellListMessage()
        {
        }
        
        public HouseToSellListMessage(uint pageIndex, uint totalPage, Types.HouseInformationsForSell[] houseList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.houseList = houseList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)pageIndex);
            writer.WriteVarShort((short)totalPage);
            writer.WriteShort((short)houseList.Length);
            foreach (var entry in houseList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            pageIndex = reader.ReadVarUShort();
            totalPage = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            houseList = new Types.HouseInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 houseList[i] = new Types.HouseInformationsForSell();
                 houseList[i].Deserialize(reader);
            }
        }
        
    }
    
}