using System;

namespace core.config
{
	// Token: 0x02001D91 RID: 7569
	public class Map : XlsConfigBase<Map, IMapInfo>
	{
		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x0600DE12 RID: 56850 RVA: 0x003D6482 File Offset: 0x003D4682
		public override string fileName
		{
			get
			{
				return "map";
			}
		}

		// Token: 0x0600DE13 RID: 56851 RVA: 0x003D648C File Offset: 0x003D468C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMapInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMapInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x003D64E0 File Offset: 0x003D46E0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
