using System;

namespace core.config.pet_skin_temp
{
	// Token: 0x02002200 RID: 8704
	public class ISkinItem
	{
		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06010B59 RID: 68441 RVA: 0x0045C4C0 File Offset: 0x0045A6C0
		// (set) Token: 0x06010B5A RID: 68442 RVA: 0x0045C4C8 File Offset: 0x0045A6C8
		public string Go { get; set; }

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06010B5B RID: 68443 RVA: 0x0045C4D1 File Offset: 0x0045A6D1
		// (set) Token: 0x06010B5C RID: 68444 RVA: 0x0045C4D9 File Offset: 0x0045A6D9
		public string GoType { get; set; }

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06010B5D RID: 68445 RVA: 0x0045C4E2 File Offset: 0x0045A6E2
		// (set) Token: 0x06010B5E RID: 68446 RVA: 0x0045C4EA File Offset: 0x0045A6EA
		public string Name { get; set; }

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06010B5F RID: 68447 RVA: 0x0045C4F3 File Offset: 0x0045A6F3
		// (set) Token: 0x06010B60 RID: 68448 RVA: 0x0045C4FB File Offset: 0x0045A6FB
		public ISkinKindItem[] SkinKind { get; set; }

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06010B61 RID: 68449 RVA: 0x0045C504 File Offset: 0x0045A704
		// (set) Token: 0x06010B62 RID: 68450 RVA: 0x0045C50C File Offset: 0x0045A70C
		public int ID { get; set; }

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06010B63 RID: 68451 RVA: 0x0045C515 File Offset: 0x0045A715
		// (set) Token: 0x06010B64 RID: 68452 RVA: 0x0045C51D File Offset: 0x0045A71D
		public int Jumptarget { get; set; }

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06010B65 RID: 68453 RVA: 0x0045C526 File Offset: 0x0045A726
		// (set) Token: 0x06010B66 RID: 68454 RVA: 0x0045C52E File Offset: 0x0045A72E
		public int MonID { get; set; }

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06010B67 RID: 68455 RVA: 0x0045C537 File Offset: 0x0045A737
		// (set) Token: 0x06010B68 RID: 68456 RVA: 0x0045C53F File Offset: 0x0045A73F
		public int Type { get; set; }

		// Token: 0x06010B69 RID: 68457 RVA: 0x0045C548 File Offset: 0x0045A748
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GoType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Jumptarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SkinKind = new ISkinKindItem[num];
				for (int i = 0; i < num; i++)
				{
					this.SkinKind[i] = new ISkinKindItem();
					this.SkinKind[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
