

// Generated on 06/13/2023 17:00:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
    {
        public const short Id = 7192;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int immuneSpellId;
        
        public FightTemporarySpellImmunityEffect()
        {
        }
        
        public FightTemporarySpellImmunityEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, int immuneSpellId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.immuneSpellId = immuneSpellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(immuneSpellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            immuneSpellId = reader.ReadInt();
        }
        
    }
    
}