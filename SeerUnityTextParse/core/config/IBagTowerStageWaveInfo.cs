using System;

namespace core.config
{
	// Token: 0x02001F03 RID: 7939
	public class IBagTowerStageWaveInfo : IConfigItem
	{
		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x0600EB18 RID: 60184 RVA: 0x0042CB04 File Offset: 0x0042AD04
		// (set) Token: 0x0600EB19 RID: 60185 RVA: 0x0042CB0C File Offset: 0x0042AD0C
		public string opengrid { get; set; }

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x0600EB1A RID: 60186 RVA: 0x0042CB15 File Offset: 0x0042AD15
		// (set) Token: 0x0600EB1B RID: 60187 RVA: 0x0042CB1D File Offset: 0x0042AD1D
		public string weight1 { get; set; }

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600EB1C RID: 60188 RVA: 0x0042CB26 File Offset: 0x0042AD26
		// (set) Token: 0x0600EB1D RID: 60189 RVA: 0x0042CB2E File Offset: 0x0042AD2E
		public string weight2 { get; set; }

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600EB1E RID: 60190 RVA: 0x0042CB37 File Offset: 0x0042AD37
		// (set) Token: 0x0600EB1F RID: 60191 RVA: 0x0042CB3F File Offset: 0x0042AD3F
		public string weight3 { get; set; }

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600EB20 RID: 60192 RVA: 0x0042CB48 File Offset: 0x0042AD48
		// (set) Token: 0x0600EB21 RID: 60193 RVA: 0x0042CB50 File Offset: 0x0042AD50
		public int getreward { get; set; }

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600EB22 RID: 60194 RVA: 0x0042CB59 File Offset: 0x0042AD59
		// (set) Token: 0x0600EB23 RID: 60195 RVA: 0x0042CB61 File Offset: 0x0042AD61
		public int id { get; set; }

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600EB24 RID: 60196 RVA: 0x0042CB6A File Offset: 0x0042AD6A
		// (set) Token: 0x0600EB25 RID: 60197 RVA: 0x0042CB72 File Offset: 0x0042AD72
		public int loop { get; set; }

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x0042CB7B File Offset: 0x0042AD7B
		// (set) Token: 0x0600EB27 RID: 60199 RVA: 0x0042CB83 File Offset: 0x0042AD83
		public int refresh { get; set; }

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600EB28 RID: 60200 RVA: 0x0042CB8C File Offset: 0x0042AD8C
		// (set) Token: 0x0600EB29 RID: 60201 RVA: 0x0042CB94 File Offset: 0x0042AD94
		public int reward1 { get; set; }

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x0042CB9D File Offset: 0x0042AD9D
		// (set) Token: 0x0600EB2B RID: 60203 RVA: 0x0042CBA5 File Offset: 0x0042ADA5
		public int reward2 { get; set; }

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x0600EB2C RID: 60204 RVA: 0x0042CBAE File Offset: 0x0042ADAE
		// (set) Token: 0x0600EB2D RID: 60205 RVA: 0x0042CBB6 File Offset: 0x0042ADB6
		public int stage { get; set; }

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x0600EB2E RID: 60206 RVA: 0x0042CBBF File Offset: 0x0042ADBF
		// (set) Token: 0x0600EB2F RID: 60207 RVA: 0x0042CBC7 File Offset: 0x0042ADC7
		public int wave { get; set; }

		// Token: 0x0600EB30 RID: 60208 RVA: 0x0042CBD0 File Offset: 0x0042ADD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.getreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.loop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opengrid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.refresh = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wave = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.weight1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.weight2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.weight3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
