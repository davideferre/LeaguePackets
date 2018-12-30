﻿using System;
using LeaguePackets.Common;

namespace LeaguePackets.CommonData.Events
{
    public class ArgsSurrenderVotes : ArgsBase
    {
        public int ForVote { get; set; }
        public int AgainstVote { get; set; }
        public TeamID TeamID { get; set; }
        public override void ReadArgs(PacketReader reader)
        {
            base.ReadArgs(reader);
            //FIXME: this doesn't appear to be serialized?
            ForVote = reader.ReadInt32();
            AgainstVote = reader.ReadInt32();
            TeamID = (TeamID)reader.ReadUInt16();
        }
        public override void WriteArgs(PacketWriter writer)
        {
            base.WriteArgs(writer);
            writer.WriteInt32(ForVote);
            writer.WriteInt32(AgainstVote);
            writer.WriteUInt16((ushort)TeamID);
        }
    }
}
