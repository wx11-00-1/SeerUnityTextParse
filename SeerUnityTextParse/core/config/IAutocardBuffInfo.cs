using System;

namespace core.config
{
	// Token: 0x02002127 RID: 8487
	public class IAutocardBuffInfo : IConfigItem
	{
		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600FC00 RID: 64512 RVA: 0x0047C5E0 File Offset: 0x0047A7E0
		// (set) Token: 0x0600FC01 RID: 64513 RVA: 0x0047C5E8 File Offset: 0x0047A7E8
		public string effectIcon { get; set; }

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x0600FC02 RID: 64514 RVA: 0x0047C5F1 File Offset: 0x0047A7F1
		// (set) Token: 0x0600FC03 RID: 64515 RVA: 0x0047C5F9 File Offset: 0x0047A7F9
		public string @object { get; set; }

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x0600FC04 RID: 64516 RVA: 0x0047C602 File Offset: 0x0047A802
		// (set) Token: 0x0600FC05 RID: 64517 RVA: 0x0047C60A File Offset: 0x0047A80A
		public string param { get; set; }

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x0600FC06 RID: 64518 RVA: 0x0047C613 File Offset: 0x0047A813
		// (set) Token: 0x0600FC07 RID: 64519 RVA: 0x0047C61B File Offset: 0x0047A81B
		public string paramDes { get; set; }

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600FC08 RID: 64520 RVA: 0x0047C624 File Offset: 0x0047A824
		// (set) Token: 0x0600FC09 RID: 64521 RVA: 0x0047C62C File Offset: 0x0047A82C
		public int id { get; set; }

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600FC0A RID: 64522 RVA: 0x0047C635 File Offset: 0x0047A835
		// (set) Token: 0x0600FC0B RID: 64523 RVA: 0x0047C63D File Offset: 0x0047A83D
		public int IsDeathEffect { get; set; }

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600FC0C RID: 64524 RVA: 0x0047C646 File Offset: 0x0047A846
		// (set) Token: 0x0600FC0D RID: 64525 RVA: 0x0047C64E File Offset: 0x0047A84E
		public int IsPlaceEffect { get; set; }

		// Token: 0x0600FC0E RID: 64526 RVA: 0x0047C658 File Offset: 0x0047A858
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.IsDeathEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsPlaceEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effectIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.@object = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.paramDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
