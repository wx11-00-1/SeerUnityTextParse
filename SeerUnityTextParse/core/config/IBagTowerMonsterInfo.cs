using System;

namespace core.config
{
	// Token: 0x02001EFB RID: 7931
	public class IBagTowerMonsterInfo : IConfigItem
	{
		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600EAC2 RID: 60098 RVA: 0x0042C494 File Offset: 0x0042A694
		// (set) Token: 0x0600EAC3 RID: 60099 RVA: 0x0042C49C File Offset: 0x0042A69C
		public string name { get; set; }

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600EAC4 RID: 60100 RVA: 0x0042C4A5 File Offset: 0x0042A6A5
		// (set) Token: 0x0600EAC5 RID: 60101 RVA: 0x0042C4AD File Offset: 0x0042A6AD
		public int[] issplit { get; set; }

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x0600EAC6 RID: 60102 RVA: 0x0042C4B6 File Offset: 0x0042A6B6
		// (set) Token: 0x0600EAC7 RID: 60103 RVA: 0x0042C4BE File Offset: 0x0042A6BE
		public int id { get; set; }

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x0600EAC8 RID: 60104 RVA: 0x0042C4C7 File Offset: 0x0042A6C7
		// (set) Token: 0x0600EAC9 RID: 60105 RVA: 0x0042C4CF File Offset: 0x0042A6CF
		public int initialatk { get; set; }

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x0600EACA RID: 60106 RVA: 0x0042C4D8 File Offset: 0x0042A6D8
		// (set) Token: 0x0600EACB RID: 60107 RVA: 0x0042C4E0 File Offset: 0x0042A6E0
		public int initialhp { get; set; }

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x0600EACC RID: 60108 RVA: 0x0042C4E9 File Offset: 0x0042A6E9
		// (set) Token: 0x0600EACD RID: 60109 RVA: 0x0042C4F1 File Offset: 0x0042A6F1
		public int monstertype { get; set; }

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600EACE RID: 60110 RVA: 0x0042C4FA File Offset: 0x0042A6FA
		// (set) Token: 0x0600EACF RID: 60111 RVA: 0x0042C502 File Offset: 0x0042A702
		public int move { get; set; }

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600EAD0 RID: 60112 RVA: 0x0042C50B File Offset: 0x0042A70B
		// (set) Token: 0x0600EAD1 RID: 60113 RVA: 0x0042C513 File Offset: 0x0042A713
		public int range { get; set; }

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600EAD2 RID: 60114 RVA: 0x0042C51C File Offset: 0x0042A71C
		// (set) Token: 0x0600EAD3 RID: 60115 RVA: 0x0042C524 File Offset: 0x0042A724
		public int speed { get; set; }

		// Token: 0x0600EAD4 RID: 60116 RVA: 0x0042C530 File Offset: 0x0042A730
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initialatk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initialhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.issplit = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.issplit[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monstertype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.move = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.range = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
