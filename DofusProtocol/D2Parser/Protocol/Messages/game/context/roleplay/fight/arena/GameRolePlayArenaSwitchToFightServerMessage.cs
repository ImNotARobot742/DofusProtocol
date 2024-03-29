

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaSwitchToFightServerMessage : NetworkMessage
    {
        public const uint Id = 3638;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string address;
        public uint[] ports;
        public sbyte[] ticket;
        
        public GameRolePlayArenaSwitchToFightServerMessage()
        {
        }
        
        public GameRolePlayArenaSwitchToFightServerMessage(string address, uint[] ports, sbyte[] ticket)
        {
            this.address = address;
            this.ports = ports;
            this.ticket = ticket;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(address);
            writer.WriteShort((short)ports.Length);
            foreach (var entry in ports)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteVarInt((int)(ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            address = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            ports = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ports[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}