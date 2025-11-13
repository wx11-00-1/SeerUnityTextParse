using System;

namespace core.config.itemsOptimizeCat
{
	// Token: 0x0200201C RID: 8220
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x0600F9E3 RID: 63971 RVA: 0x003FF20C File Offset: 0x003FD40C
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCat";
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600F9E4 RID: 63972 RVA: 0x003FF213 File Offset: 0x003FD413
		// (set) Token: 0x0600F9E5 RID: 63973 RVA: 0x003FF21B File Offset: 0x003FD41B
		public ICatsItem[] cats { get; set; }

		// Token: 0x0600F9E6 RID: 63974 RVA: 0x003FF224 File Offset: 0x003FD424
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.cats = new ICatsItem[num];
				for (int i = 0; i < num; i++)
				{
					this.cats[i] = new ICatsItem();
					this.cats[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F9E7 RID: 63975 RVA: 0x003FF278 File Offset: 0x003FD478
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
