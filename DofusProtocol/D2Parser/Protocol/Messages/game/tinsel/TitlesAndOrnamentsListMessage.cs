

// Generated on 05/18/2023 15:10:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TitlesAndOrnamentsListMessage : NetworkMessage
    {
        public const uint Id = 4106;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] titles;
        public uint[] ornaments;
        public uint activeTitle;
        public uint activeOrnament;
        
        public TitlesAndOrnamentsListMessage()
        {
        }
        
        public TitlesAndOrnamentsListMessage(uint[] titles, uint[] ornaments, uint activeTitle, uint activeOrnament)
        {
            this.titles = titles;
            this.ornaments = ornaments;
            this.activeTitle = activeTitle;
            this.activeOrnament = activeOrnament;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)titles.Length);
            foreach (var entry in titles)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)ornaments.Length);
            foreach (var entry in ornaments)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteVarShort((short)activeTitle);
            writer.WriteVarShort((short)activeOrnament);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            titles = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 titles[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            ornaments = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ornaments[i] = reader.ReadVarUShort();
            }
            activeTitle = reader.ReadVarUShort();
            activeOrnament = reader.ReadVarUShort();
        }
        
    }
    
}