

// Generated on 05/18/2023 16:29:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristicDetailed : CharacterCharacteristic
    {
        public const short Id = 7776;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int @base;
        public int additional;
        public int objectsAndMountBonus;
        public int alignGiftBonus;
        public int contextModif;
        
        public CharacterCharacteristicDetailed()
        {
        }
        
        public CharacterCharacteristicDetailed(short characteristicId, int @base, int additional, int objectsAndMountBonus, int alignGiftBonus, int contextModif)
         : base(characteristicId)
        {
            this.@base = @base;
            this.additional = additional;
            this.objectsAndMountBonus = objectsAndMountBonus;
            this.alignGiftBonus = alignGiftBonus;
            this.contextModif = contextModif;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)@base);
            writer.WriteVarInt((int)additional);
            writer.WriteVarInt((int)objectsAndMountBonus);
            writer.WriteVarInt((int)alignGiftBonus);
            writer.WriteVarInt((int)contextModif);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            @base = reader.ReadVarInt();
            additional = reader.ReadVarInt();
            objectsAndMountBonus = reader.ReadVarInt();
            alignGiftBonus = reader.ReadVarInt();
            contextModif = reader.ReadVarInt();
        }
        
    }
    
}