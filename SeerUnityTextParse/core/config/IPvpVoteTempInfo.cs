using System;

namespace core.config
{
	// Token: 0x02001DEE RID: 7662
	public class IPvpVoteTempInfo : IConfigItem
	{
		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x0600E218 RID: 57880 RVA: 0x003DB46C File Offset: 0x003D966C
		// (set) Token: 0x0600E219 RID: 57881 RVA: 0x003DB474 File Offset: 0x003D9674
		public string name { get; set; }

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x0600E21A RID: 57882 RVA: 0x003DB47D File Offset: 0x003D967D
		// (set) Token: 0x0600E21B RID: 57883 RVA: 0x003DB485 File Offset: 0x003D9685
		public string result { get; set; }

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x0600E21C RID: 57884 RVA: 0x003DB48E File Offset: 0x003D968E
		// (set) Token: 0x0600E21D RID: 57885 RVA: 0x003DB496 File Offset: 0x003D9696
		public string time { get; set; }

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x0600E21E RID: 57886 RVA: 0x003DB49F File Offset: 0x003D969F
		// (set) Token: 0x0600E21F RID: 57887 RVA: 0x003DB4A7 File Offset: 0x003D96A7
		public int id { get; set; }

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x0600E220 RID: 57888 RVA: 0x003DB4B0 File Offset: 0x003D96B0
		// (set) Token: 0x0600E221 RID: 57889 RVA: 0x003DB4B8 File Offset: 0x003D96B8
		public int number { get; set; }

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x0600E222 RID: 57890 RVA: 0x003DB4C1 File Offset: 0x003D96C1
		// (set) Token: 0x0600E223 RID: 57891 RVA: 0x003DB4C9 File Offset: 0x003D96C9
		public int ranklimit1 { get; set; }

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x0600E224 RID: 57892 RVA: 0x003DB4D2 File Offset: 0x003D96D2
		// (set) Token: 0x0600E225 RID: 57893 RVA: 0x003DB4DA File Offset: 0x003D96DA
		public int ranklimit2 { get; set; }

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x0600E226 RID: 57894 RVA: 0x003DB4E3 File Offset: 0x003D96E3
		// (set) Token: 0x0600E227 RID: 57895 RVA: 0x003DB4EB File Offset: 0x003D96EB
		public int subkey { get; set; }

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x0600E228 RID: 57896 RVA: 0x003DB4F4 File Offset: 0x003D96F4
		// (set) Token: 0x0600E229 RID: 57897 RVA: 0x003DB4FC File Offset: 0x003D96FC
		public int time1 { get; set; }

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x0600E22A RID: 57898 RVA: 0x003DB505 File Offset: 0x003D9705
		// (set) Token: 0x0600E22B RID: 57899 RVA: 0x003DB50D File Offset: 0x003D970D
		public int time2 { get; set; }

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x0600E22C RID: 57900 RVA: 0x003DB516 File Offset: 0x003D9716
		// (set) Token: 0x0600E22D RID: 57901 RVA: 0x003DB51E File Offset: 0x003D971E
		public int type { get; set; }

		// Token: 0x0600E22E RID: 57902 RVA: 0x003DB528 File Offset: 0x003D9728
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ranklimit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ranklimit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.result = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
