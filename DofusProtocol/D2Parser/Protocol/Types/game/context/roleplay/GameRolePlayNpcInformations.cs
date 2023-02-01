

// Generated on 02/01/2023 12:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayNpcInformations : GameRolePlayActorInformations
    {
        public const short Id = 9237;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint npcId;
        public bool sex;
        public uint specialArtworkId;
        
        public GameRolePlayNpcInformations()
        {
        }
        
        public GameRolePlayNpcInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, uint npcId, bool sex, uint specialArtworkId)
         : base(contextualId, disposition, look)
        {
            this.npcId = npcId;
            this.sex = sex;
            this.specialArtworkId = specialArtworkId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)npcId);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((short)specialArtworkId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            npcId = reader.ReadVarUShort();
            sex = reader.ReadBoolean();
            specialArtworkId = reader.ReadVarUShort();
        }
        
    }
    
}