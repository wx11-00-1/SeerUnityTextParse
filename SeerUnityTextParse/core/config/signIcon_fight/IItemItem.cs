using System;

namespace core.config.signIcon_fight
{
	// Token: 0x02001F24 RID: 7972
	public class IItemItem : IConfigItem
	{
		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x0600EEDA RID: 61146 RVA: 0x003F2E42 File Offset: 0x003F1042
		// (set) Token: 0x0600EEDB RID: 61147 RVA: 0x003F2E4A File Offset: 0x003F104A
		public string className { get; set; }

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x0600EEDC RID: 61148 RVA: 0x003F2E53 File Offset: 0x003F1053
		// (set) Token: 0x0600EEDD RID: 61149 RVA: 0x003F2E5B File Offset: 0x003F105B
		public string dec { get; set; }

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x0600EEDE RID: 61150 RVA: 0x003F2E64 File Offset: 0x003F1064
		// (set) Token: 0x0600EEDF RID: 61151 RVA: 0x003F2E6C File Offset: 0x003F106C
		public string Des { get; set; }

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x0600EEE0 RID: 61152 RVA: 0x003F2E75 File Offset: 0x003F1075
		// (set) Token: 0x0600EEE1 RID: 61153 RVA: 0x003F2E7D File Offset: 0x003F107D
		public string[] frame { get; set; }

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x0600EEE2 RID: 61154 RVA: 0x003F2E86 File Offset: 0x003F1086
		// (set) Token: 0x0600EEE3 RID: 61155 RVA: 0x003F2E8E File Offset: 0x003F108E
		public string NumDes { get; set; }

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x0600EEE4 RID: 61156 RVA: 0x003F2E97 File Offset: 0x003F1097
		// (set) Token: 0x0600EEE5 RID: 61157 RVA: 0x003F2E9F File Offset: 0x003F109F
		public string[] spDes { get; set; }

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x0600EEE6 RID: 61158 RVA: 0x003F2EA8 File Offset: 0x003F10A8
		// (set) Token: 0x0600EEE7 RID: 61159 RVA: 0x003F2EB0 File Offset: 0x003F10B0
		public string[] spicon { get; set; }

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x0600EEE8 RID: 61160 RVA: 0x003F2EB9 File Offset: 0x003F10B9
		// (set) Token: 0x0600EEE9 RID: 61161 RVA: 0x003F2EC1 File Offset: 0x003F10C1
		public string[] sptips { get; set; }

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x0600EEEA RID: 61162 RVA: 0x003F2ECA File Offset: 0x003F10CA
		// (set) Token: 0x0600EEEB RID: 61163 RVA: 0x003F2ED2 File Offset: 0x003F10D2
		public string tips { get; set; }

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x0600EEEC RID: 61164 RVA: 0x003F2EDB File Offset: 0x003F10DB
		// (set) Token: 0x0600EEED RID: 61165 RVA: 0x003F2EE3 File Offset: 0x003F10E3
		public int id { get; set; }

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600EEEE RID: 61166 RVA: 0x003F2EEC File Offset: 0x003F10EC
		// (set) Token: 0x0600EEEF RID: 61167 RVA: 0x003F2EF4 File Offset: 0x003F10F4
		public int isShowNum { get; set; }

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x0600EEF0 RID: 61168 RVA: 0x003F2EFD File Offset: 0x003F10FD
		// (set) Token: 0x0600EEF1 RID: 61169 RVA: 0x003F2F05 File Offset: 0x003F1105
		public int showmonster { get; set; }

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x0600EEF2 RID: 61170 RVA: 0x003F2F0E File Offset: 0x003F110E
		// (set) Token: 0x0600EEF3 RID: 61171 RVA: 0x003F2F16 File Offset: 0x003F1116
		public int showtime { get; set; }

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x0600EEF4 RID: 61172 RVA: 0x003F2F1F File Offset: 0x003F111F
		// (set) Token: 0x0600EEF5 RID: 61173 RVA: 0x003F2F27 File Offset: 0x003F1127
		public int sort { get; set; }

		// Token: 0x0600EEF6 RID: 61174 RVA: 0x003F2F30 File Offset: 0x003F1130
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.NumDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.className = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dec = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.frame = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.frame[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isShowNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showmonster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.spDes = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.spDes[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.spicon = new string[num3];
				for (int k = 0; k < num3; k++)
				{
					this.spicon[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.sptips = new string[num4];
				for (int l = 0; l < num4; l++)
				{
					this.sptips[l] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
