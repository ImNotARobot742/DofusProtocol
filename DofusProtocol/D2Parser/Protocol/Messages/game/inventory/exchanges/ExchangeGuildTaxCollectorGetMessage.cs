

// Generated on 05/18/2023 16:29:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeGuildTaxCollectorGetMessage : NetworkMessage
    {
        public const uint Id = 2404;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string collectorName;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        public string userName;
        public double callerId;
        public string callerName;
        public double experience;
        public uint pods;
        public Types.ObjectItemGenericQuantity[] objectsInfos;
        
        public ExchangeGuildTaxCollectorGetMessage()
        {
        }
        
        public ExchangeGuildTaxCollectorGetMessage(string collectorName, short worldX, short worldY, double mapId, uint subAreaId, string userName, double callerId, string callerName, double experience, uint pods, Types.ObjectItemGenericQuantity[] objectsInfos)
        {
            this.collectorName = collectorName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.userName = userName;
            this.callerId = callerId;
            this.callerName = callerName;
            this.experience = experience;
            this.pods = pods;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(collectorName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteUTF(userName);
            writer.WriteVarLong(callerId);
            writer.WriteUTF(callerName);
            writer.WriteDouble(experience);
            writer.WriteVarShort((short)pods);
            writer.WriteShort((short)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            collectorName = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUShort();
            userName = reader.ReadUTF();
            callerId = reader.ReadVarULong();
            callerName = reader.ReadUTF();
            experience = reader.ReadDouble();
            pods = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            objectsInfos = new Types.ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemGenericQuantity();
                 objectsInfos[i].Deserialize(reader);
            }
        }
        
    }
    
}