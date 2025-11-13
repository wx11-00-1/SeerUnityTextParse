using System;

namespace core.config
{
	// Token: 0x02001D3A RID: 7482
	public class IDungeonEnterInfo : IConfigItem
	{
		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600DA9E RID: 55966 RVA: 0x003D1F28 File Offset: 0x003D0128
		// (set) Token: 0x0600DA9F RID: 55967 RVA: 0x003D1F30 File Offset: 0x003D0130
		public string name { get; set; }

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600DAA0 RID: 55968 RVA: 0x003D1F39 File Offset: 0x003D0139
		// (set) Token: 0x0600DAA1 RID: 55969 RVA: 0x003D1F41 File Offset: 0x003D0141
		public string openParam { get; set; }

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600DAA2 RID: 55970 RVA: 0x003D1F4A File Offset: 0x003D014A
		// (set) Token: 0x0600DAA3 RID: 55971 RVA: 0x003D1F52 File Offset: 0x003D0152
		public string res { get; set; }

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x0600DAA4 RID: 55972 RVA: 0x003D1F5B File Offset: 0x003D015B
		// (set) Token: 0x0600DAA5 RID: 55973 RVA: 0x003D1F63 File Offset: 0x003D0163
		public string timeLimit { get; set; }

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x0600DAA6 RID: 55974 RVA: 0x003D1F6C File Offset: 0x003D016C
		// (set) Token: 0x0600DAA7 RID: 55975 RVA: 0x003D1F74 File Offset: 0x003D0174
		public int[] reward { get; set; }

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600DAA8 RID: 55976 RVA: 0x003D1F7D File Offset: 0x003D017D
		// (set) Token: 0x0600DAA9 RID: 55977 RVA: 0x003D1F85 File Offset: 0x003D0185
		public int[] times { get; set; }

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600DAAA RID: 55978 RVA: 0x003D1F8E File Offset: 0x003D018E
		// (set) Token: 0x0600DAAB RID: 55979 RVA: 0x003D1F96 File Offset: 0x003D0196
		public int id { get; set; }

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600DAAC RID: 55980 RVA: 0x003D1F9F File Offset: 0x003D019F
		// (set) Token: 0x0600DAAD RID: 55981 RVA: 0x003D1FA7 File Offset: 0x003D01A7
		public int isOpen { get; set; }

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600DAAE RID: 55982 RVA: 0x003D1FB0 File Offset: 0x003D01B0
		// (set) Token: 0x0600DAAF RID: 55983 RVA: 0x003D1FB8 File Offset: 0x003D01B8
		public int isShow { get; set; }

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600DAB0 RID: 55984 RVA: 0x003D1FC1 File Offset: 0x003D01C1
		// (set) Token: 0x0600DAB1 RID: 55985 RVA: 0x003D1FC9 File Offset: 0x003D01C9
		public int moduleID { get; set; }

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600DAB2 RID: 55986 RVA: 0x003D1FD2 File Offset: 0x003D01D2
		// (set) Token: 0x0600DAB3 RID: 55987 RVA: 0x003D1FDA File Offset: 0x003D01DA
		public int order { get; set; }

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600DAB4 RID: 55988 RVA: 0x003D1FE3 File Offset: 0x003D01E3
		// (set) Token: 0x0600DAB5 RID: 55989 RVA: 0x003D1FEB File Offset: 0x003D01EB
		public int redbadge { get; set; }

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600DAB6 RID: 55990 RVA: 0x003D1FF4 File Offset: 0x003D01F4
		// (set) Token: 0x0600DAB7 RID: 55991 RVA: 0x003D1FFC File Offset: 0x003D01FC
		public int showType { get; set; }

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600DAB8 RID: 55992 RVA: 0x003D2005 File Offset: 0x003D0205
		// (set) Token: 0x0600DAB9 RID: 55993 RVA: 0x003D200D File Offset: 0x003D020D
		public int type { get; set; }

		// Token: 0x0600DABA RID: 55994 RVA: 0x003D2018 File Offset: 0x003D0218
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isOpen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moduleID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.openParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.res = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.showType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timeLimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.times = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.times[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
