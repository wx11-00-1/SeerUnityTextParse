using System;

namespace core.config
{
	// Token: 0x020026B7 RID: 9911
	public class IStoryAnniversary2026BBSInfo : IConfigItem
	{
		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x060134A2 RID: 79010 RVA: 0x00523050 File Offset: 0x00521250
		// (set) Token: 0x060134A3 RID: 79011 RVA: 0x00523058 File Offset: 0x00521258
		public string comments { get; set; }

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x060134A4 RID: 79012 RVA: 0x00523061 File Offset: 0x00521261
		// (set) Token: 0x060134A5 RID: 79013 RVA: 0x00523069 File Offset: 0x00521269
		public string desc { get; set; }

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x060134A6 RID: 79014 RVA: 0x00523072 File Offset: 0x00521272
		// (set) Token: 0x060134A7 RID: 79015 RVA: 0x0052307A File Offset: 0x0052127A
		public string name { get; set; }

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x060134A8 RID: 79016 RVA: 0x00523083 File Offset: 0x00521283
		// (set) Token: 0x060134A9 RID: 79017 RVA: 0x0052308B File Offset: 0x0052128B
		public string publisher { get; set; }

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x060134AA RID: 79018 RVA: 0x00523094 File Offset: 0x00521294
		// (set) Token: 0x060134AB RID: 79019 RVA: 0x0052309C File Offset: 0x0052129C
		public int id { get; set; }

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x060134AC RID: 79020 RVA: 0x005230A5 File Offset: 0x005212A5
		// (set) Token: 0x060134AD RID: 79021 RVA: 0x005230AD File Offset: 0x005212AD
		public int sort { get; set; }

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x060134AE RID: 79022 RVA: 0x005230B6 File Offset: 0x005212B6
		// (set) Token: 0x060134AF RID: 79023 RVA: 0x005230BE File Offset: 0x005212BE
		public int type { get; set; }

		// Token: 0x060134B0 RID: 79024 RVA: 0x005230C8 File Offset: 0x005212C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.comments = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.publisher = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
