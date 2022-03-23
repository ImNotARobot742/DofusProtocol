

// Generated on 03/23/2022 09:50:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SelectedServerDataMessage : NetworkMessage
    {
        public const uint Id = 9579;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint serverId;
        public string address;
        public uint[] ports;
        public bool canCreateNewCharacter;
        public sbyte[] ticket;
        
        public SelectedServerDataMessage()
        {
        }
        
        public SelectedServerDataMessage(uint serverId, string address, uint[] ports, bool canCreateNewCharacter, sbyte[] ticket)
        {
            this.serverId = serverId;
            this.address = address;
            this.ports = ports;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.ticket = ticket;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)serverId);
            writer.WriteUTF(address);
            writer.WriteShort((short)ports.Length);
            foreach (var entry in ports)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteBoolean(canCreateNewCharacter);
            writer.WriteVarInt((int)(ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            serverId = reader.ReadVarUShort();
            address = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            ports = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ports[i] = reader.ReadVarUShort();
            }
            canCreateNewCharacter = reader.ReadBoolean();
            limit = (ushort)reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}