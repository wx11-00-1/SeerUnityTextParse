using System;

namespace core.config.battle_effects
{
	// Token: 0x02002066 RID: 8294
	public class ISubEffectItem
	{
		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600FD4D RID: 64845 RVA: 0x00402F78 File Offset: 0x00401178
		// (set) Token: 0x0600FD4E RID: 64846 RVA: 0x00402F80 File Offset: 0x00401180
		public string Name { get; set; }

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600FD4F RID: 64847 RVA: 0x00402F89 File Offset: 0x00401189
		// (set) Token: 0x0600FD50 RID: 64848 RVA: 0x00402F91 File Offset: 0x00401191
		public int Efftype { get; set; }

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600FD51 RID: 64849 RVA: 0x00402F9A File Offset: 0x0040119A
		// (set) Token: 0x0600FD52 RID: 64850 RVA: 0x00402FA2 File Offset: 0x004011A2
		public int ID { get; set; }

		// Token: 0x0600FD53 RID: 64851 RVA: 0x00402FAB File Offset: 0x004011AB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Efftype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
