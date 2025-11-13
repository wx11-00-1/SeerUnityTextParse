using System;

namespace core.config
{
	// Token: 0x02001D8C RID: 7564
	public class ILuckyrocketLevelcontentInfo : IConfigItem
	{
		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x003D606C File Offset: 0x003D426C
		// (set) Token: 0x0600DDE3 RID: 56803 RVA: 0x003D6074 File Offset: 0x003D4274
		public string equip { get; set; }

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x0600DDE4 RID: 56804 RVA: 0x003D607D File Offset: 0x003D427D
		// (set) Token: 0x0600DDE5 RID: 56805 RVA: 0x003D6085 File Offset: 0x003D4285
		public string showdescribe { get; set; }

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600DDE6 RID: 56806 RVA: 0x003D608E File Offset: 0x003D428E
		// (set) Token: 0x0600DDE7 RID: 56807 RVA: 0x003D6096 File Offset: 0x003D4296
		public string unlock { get; set; }

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x0600DDE8 RID: 56808 RVA: 0x003D609F File Offset: 0x003D429F
		// (set) Token: 0x0600DDE9 RID: 56809 RVA: 0x003D60A7 File Offset: 0x003D42A7
		public int[] beginindex { get; set; }

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x0600DDEA RID: 56810 RVA: 0x003D60B0 File Offset: 0x003D42B0
		// (set) Token: 0x0600DDEB RID: 56811 RVA: 0x003D60B8 File Offset: 0x003D42B8
		public int[] beginitem { get; set; }

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x0600DDEC RID: 56812 RVA: 0x003D60C1 File Offset: 0x003D42C1
		// (set) Token: 0x0600DDED RID: 56813 RVA: 0x003D60C9 File Offset: 0x003D42C9
		public int id { get; set; }

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x0600DDEE RID: 56814 RVA: 0x003D60D2 File Offset: 0x003D42D2
		// (set) Token: 0x0600DDEF RID: 56815 RVA: 0x003D60DA File Offset: 0x003D42DA
		public int level { get; set; }

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x0600DDF0 RID: 56816 RVA: 0x003D60E3 File Offset: 0x003D42E3
		// (set) Token: 0x0600DDF1 RID: 56817 RVA: 0x003D60EB File Offset: 0x003D42EB
		public int opentime { get; set; }

		// Token: 0x0600DDF2 RID: 56818 RVA: 0x003D60F4 File Offset: 0x003D42F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.beginindex = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.beginindex[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.beginitem = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.beginitem[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.equip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showdescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlock = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
