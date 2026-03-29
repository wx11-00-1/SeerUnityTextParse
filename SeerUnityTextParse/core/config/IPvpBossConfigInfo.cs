using System;

namespace core.config
{
	// Token: 0x02002315 RID: 8981
	public class IPvpBossConfigInfo : IConfigItem
	{
		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06011174 RID: 70004 RVA: 0x004964C4 File Offset: 0x004946C4
		// (set) Token: 0x06011175 RID: 70005 RVA: 0x004964CC File Offset: 0x004946CC
		public string baseData { get; set; }

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06011176 RID: 70006 RVA: 0x004964D5 File Offset: 0x004946D5
		// (set) Token: 0x06011177 RID: 70007 RVA: 0x004964DD File Offset: 0x004946DD
		public string extraData { get; set; }

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06011178 RID: 70008 RVA: 0x004964E6 File Offset: 0x004946E6
		// (set) Token: 0x06011179 RID: 70009 RVA: 0x004964EE File Offset: 0x004946EE
		public string mintmarkData { get; set; }

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0601117A RID: 70010 RVA: 0x004964F7 File Offset: 0x004946F7
		// (set) Token: 0x0601117B RID: 70011 RVA: 0x004964FF File Offset: 0x004946FF
		public string monsterMove { get; set; }

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x0601117C RID: 70012 RVA: 0x00496508 File Offset: 0x00494708
		// (set) Token: 0x0601117D RID: 70013 RVA: 0x00496510 File Offset: 0x00494710
		public string monsterName { get; set; }

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x0601117E RID: 70014 RVA: 0x00496519 File Offset: 0x00494719
		// (set) Token: 0x0601117F RID: 70015 RVA: 0x00496521 File Offset: 0x00494721
		public string monsterNewse { get; set; }

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06011180 RID: 70016 RVA: 0x0049652A File Offset: 0x0049472A
		// (set) Token: 0x06011181 RID: 70017 RVA: 0x00496532 File Offset: 0x00494732
		public int id { get; set; }

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06011182 RID: 70018 RVA: 0x0049653B File Offset: 0x0049473B
		// (set) Token: 0x06011183 RID: 70019 RVA: 0x00496543 File Offset: 0x00494743
		public int monsterEffect_id { get; set; }

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06011184 RID: 70020 RVA: 0x0049654C File Offset: 0x0049474C
		// (set) Token: 0x06011185 RID: 70021 RVA: 0x00496554 File Offset: 0x00494754
		public int monsterId { get; set; }

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06011186 RID: 70022 RVA: 0x0049655D File Offset: 0x0049475D
		// (set) Token: 0x06011187 RID: 70023 RVA: 0x00496565 File Offset: 0x00494765
		public int monsterLv { get; set; }

		// Token: 0x06011188 RID: 70024 RVA: 0x00496570 File Offset: 0x00494770
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.baseData = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.extraData = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mintmarkData = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterEffect_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterMove = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterNewse = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
