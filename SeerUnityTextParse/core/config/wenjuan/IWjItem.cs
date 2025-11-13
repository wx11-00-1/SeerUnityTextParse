using System;

namespace core.config.wenjuan
{
	// Token: 0x02001EF5 RID: 7925
	public class IWjItem : IConfigItem
	{
		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x0600ED34 RID: 60724 RVA: 0x003F0F94 File Offset: 0x003EF194
		// (set) Token: 0x0600ED35 RID: 60725 RVA: 0x003F0F9C File Offset: 0x003EF19C
		public IItemItem[] item { get; set; }

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x0600ED36 RID: 60726 RVA: 0x003F0FA5 File Offset: 0x003EF1A5
		// (set) Token: 0x0600ED37 RID: 60727 RVA: 0x003F0FAD File Offset: 0x003EF1AD
		public string q { get; set; }

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600ED38 RID: 60728 RVA: 0x003F0FB6 File Offset: 0x003EF1B6
		// (set) Token: 0x0600ED39 RID: 60729 RVA: 0x003F0FBE File Offset: 0x003EF1BE
		public string statlog { get; set; }

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x0600ED3A RID: 60730 RVA: 0x003F0FC7 File Offset: 0x003EF1C7
		// (set) Token: 0x0600ED3B RID: 60731 RVA: 0x003F0FCF File Offset: 0x003EF1CF
		public int id { get; set; }

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x0600ED3C RID: 60732 RVA: 0x003F0FD8 File Offset: 0x003EF1D8
		// (set) Token: 0x0600ED3D RID: 60733 RVA: 0x003F0FE0 File Offset: 0x003EF1E0
		public int skip { get; set; }

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x0600ED3E RID: 60734 RVA: 0x003F0FE9 File Offset: 0x003EF1E9
		// (set) Token: 0x0600ED3F RID: 60735 RVA: 0x003F0FF1 File Offset: 0x003EF1F1
		public int type { get; set; }

		// Token: 0x0600ED40 RID: 60736 RVA: 0x003F0FFC File Offset: 0x003EF1FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.item[i] = new IItemItem();
					this.item[i].Parse(bytes, ref byteIndex);
				}
			}
			this.q = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.statlog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
