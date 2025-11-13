using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F51 RID: 8017
	public class IBranchItem
	{
		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600F07E RID: 61566 RVA: 0x003F4DCF File Offset: 0x003F2FCF
		// (set) Token: 0x0600F07F RID: 61567 RVA: 0x003F4DD7 File Offset: 0x003F2FD7
		public string intro { get; set; }

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x0600F080 RID: 61568 RVA: 0x003F4DE0 File Offset: 0x003F2FE0
		// (set) Token: 0x0600F081 RID: 61569 RVA: 0x003F4DE8 File Offset: 0x003F2FE8
		public IPlaceItem[] place { get; set; }

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x0600F082 RID: 61570 RVA: 0x003F4DF1 File Offset: 0x003F2FF1
		// (set) Token: 0x0600F083 RID: 61571 RVA: 0x003F4DF9 File Offset: 0x003F2FF9
		public string title { get; set; }

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x0600F084 RID: 61572 RVA: 0x003F4E02 File Offset: 0x003F3002
		// (set) Token: 0x0600F085 RID: 61573 RVA: 0x003F4E0A File Offset: 0x003F300A
		public int ID { get; set; }

		// Token: 0x0600F086 RID: 61574 RVA: 0x003F4E14 File Offset: 0x003F3014
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.place = new IPlaceItem[num];
				for (int i = 0; i < num; i++)
				{
					this.place[i] = new IPlaceItem();
					this.place[i].Parse(bytes, ref byteIndex);
				}
			}
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
