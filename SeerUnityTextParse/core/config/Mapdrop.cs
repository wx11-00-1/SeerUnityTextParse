using System;

namespace core.config
{
	// Token: 0x020022AC RID: 8876
	public class Mapdrop : XlsConfigBase<Mapdrop, IMapdropInfo>
	{
		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06010CE0 RID: 68832 RVA: 0x00490942 File Offset: 0x0048EB42
		public override string fileName
		{
			get
			{
				return "mapdrop";
			}
		}

		// Token: 0x06010CE1 RID: 68833 RVA: 0x0049094C File Offset: 0x0048EB4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMapdropInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMapdropInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010CE2 RID: 68834 RVA: 0x004909A0 File Offset: 0x0048EBA0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
