using System;

namespace core.model
{
	// Token: 0x02001972 RID: 6514
	public class ServerNotifyInfo
	{
		// Token: 0x0600CC71 RID: 52337 RVA: 0x003B5A60 File Offset: 0x003B3C60
		public ServerNotifyInfo(ByteArray by)
		{
			this.type = (int)by.ReadUnsignedInt();
			this.sender_id = (int)by.ReadUnsignedInt();
			this.nick = by.ReadUTFByte(16);
			this.accept = (int)by.ReadUnsignedInt();
			this.online_id = (int)by.ReadUnsignedInt();
			this.map_type = (int)by.ReadUnsignedInt();
			this.map_low_id = (int)by.ReadUnsignedInt();
			this.map_name = by.ReadUTFByte(64);
		}

		// Token: 0x0400E2CC RID: 58060
		public int type;

		// Token: 0x0400E2CD RID: 58061
		public int sender_id;

		// Token: 0x0400E2CE RID: 58062
		public string nick;

		// Token: 0x0400E2CF RID: 58063
		public int accept;

		// Token: 0x0400E2D0 RID: 58064
		public int online_id;

		// Token: 0x0400E2D1 RID: 58065
		public int map_type;

		// Token: 0x0400E2D2 RID: 58066
		public int map_low_id;

		// Token: 0x0400E2D3 RID: 58067
		public string map_name;
	}
}
