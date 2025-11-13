using System;

namespace core.config.pet_skin
{
	// Token: 0x02001F3C RID: 7996
	public class ISkinItem
	{
		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x0600EFCC RID: 61388 RVA: 0x003F40AC File Offset: 0x003F22AC
		// (set) Token: 0x0600EFCD RID: 61389 RVA: 0x003F40B4 File Offset: 0x003F22B4
		public string Go { get; set; }

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x003F40BD File Offset: 0x003F22BD
		// (set) Token: 0x0600EFCF RID: 61391 RVA: 0x003F40C5 File Offset: 0x003F22C5
		public string GoType { get; set; }

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x0600EFD0 RID: 61392 RVA: 0x003F40CE File Offset: 0x003F22CE
		// (set) Token: 0x0600EFD1 RID: 61393 RVA: 0x003F40D6 File Offset: 0x003F22D6
		public string Name { get; set; }

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x0600EFD2 RID: 61394 RVA: 0x003F40DF File Offset: 0x003F22DF
		// (set) Token: 0x0600EFD3 RID: 61395 RVA: 0x003F40E7 File Offset: 0x003F22E7
		public ISkinKindItem[] SkinKind { get; set; }

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x0600EFD4 RID: 61396 RVA: 0x003F40F0 File Offset: 0x003F22F0
		// (set) Token: 0x0600EFD5 RID: 61397 RVA: 0x003F40F8 File Offset: 0x003F22F8
		public int ID { get; set; }

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x0600EFD6 RID: 61398 RVA: 0x003F4101 File Offset: 0x003F2301
		// (set) Token: 0x0600EFD7 RID: 61399 RVA: 0x003F4109 File Offset: 0x003F2309
		public int MonID { get; set; }

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x0600EFD8 RID: 61400 RVA: 0x003F4112 File Offset: 0x003F2312
		// (set) Token: 0x0600EFD9 RID: 61401 RVA: 0x003F411A File Offset: 0x003F231A
		public int Type { get; set; }

		// Token: 0x0600EFDA RID: 61402 RVA: 0x003F4124 File Offset: 0x003F2324
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GoType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
