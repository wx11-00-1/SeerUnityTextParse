using System;

namespace core.config
{
	// Token: 0x020026EB RID: 9963
	public class IStory1017Info : IConfigItem
	{
		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x06013702 RID: 79618 RVA: 0x00525D64 File Offset: 0x00523F64
		// (set) Token: 0x06013703 RID: 79619 RVA: 0x00525D6C File Offset: 0x00523F6C
		public string param1 { get; set; }

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x06013704 RID: 79620 RVA: 0x00525D75 File Offset: 0x00523F75
		// (set) Token: 0x06013705 RID: 79621 RVA: 0x00525D7D File Offset: 0x00523F7D
		public string param2 { get; set; }

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06013706 RID: 79622 RVA: 0x00525D86 File Offset: 0x00523F86
		// (set) Token: 0x06013707 RID: 79623 RVA: 0x00525D8E File Offset: 0x00523F8E
		public string param3 { get; set; }

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06013708 RID: 79624 RVA: 0x00525D97 File Offset: 0x00523F97
		// (set) Token: 0x06013709 RID: 79625 RVA: 0x00525D9F File Offset: 0x00523F9F
		public string param4 { get; set; }

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0601370A RID: 79626 RVA: 0x00525DA8 File Offset: 0x00523FA8
		// (set) Token: 0x0601370B RID: 79627 RVA: 0x00525DB0 File Offset: 0x00523FB0
		public string param5 { get; set; }

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0601370C RID: 79628 RVA: 0x00525DB9 File Offset: 0x00523FB9
		// (set) Token: 0x0601370D RID: 79629 RVA: 0x00525DC1 File Offset: 0x00523FC1
		public float control { get; set; }

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0601370E RID: 79630 RVA: 0x00525DCA File Offset: 0x00523FCA
		// (set) Token: 0x0601370F RID: 79631 RVA: 0x00525DD2 File Offset: 0x00523FD2
		public int id { get; set; }

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06013710 RID: 79632 RVA: 0x00525DDB File Offset: 0x00523FDB
		// (set) Token: 0x06013711 RID: 79633 RVA: 0x00525DE3 File Offset: 0x00523FE3
		public int logic { get; set; }

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06013712 RID: 79634 RVA: 0x00525DEC File Offset: 0x00523FEC
		// (set) Token: 0x06013713 RID: 79635 RVA: 0x00525DF4 File Offset: 0x00523FF4
		public int next { get; set; }

		// Token: 0x06013714 RID: 79636 RVA: 0x00525E00 File Offset: 0x00524000
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
