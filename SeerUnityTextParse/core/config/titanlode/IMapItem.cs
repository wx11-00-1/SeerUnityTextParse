using System;

namespace core.config.titanlode
{
	// Token: 0x02001F08 RID: 7944
	public class IMapItem : IConfigItem
	{
		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x0600EDD6 RID: 60886 RVA: 0x003F1B0C File Offset: 0x003EFD0C
		// (set) Token: 0x0600EDD7 RID: 60887 RVA: 0x003F1B14 File Offset: 0x003EFD14
		public IShowItem[] Show { get; set; }

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x0600EDD8 RID: 60888 RVA: 0x003F1B1D File Offset: 0x003EFD1D
		// (set) Token: 0x0600EDD9 RID: 60889 RVA: 0x003F1B25 File Offset: 0x003EFD25
		public int colcnt { get; set; }

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x0600EDDA RID: 60890 RVA: 0x003F1B2E File Offset: 0x003EFD2E
		// (set) Token: 0x0600EDDB RID: 60891 RVA: 0x003F1B36 File Offset: 0x003EFD36
		public int id { get; set; }

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x0600EDDC RID: 60892 RVA: 0x003F1B3F File Offset: 0x003EFD3F
		// (set) Token: 0x0600EDDD RID: 60893 RVA: 0x003F1B47 File Offset: 0x003EFD47
		public int maxcnt { get; set; }

		// Token: 0x0600EDDE RID: 60894 RVA: 0x003F1B50 File Offset: 0x003EFD50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Show = new IShowItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Show[i] = new IShowItem();
					this.Show[i].Parse(bytes, ref byteIndex);
				}
			}
			this.colcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.maxcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F070 RID: 61552
		private bool b;
	}
}
