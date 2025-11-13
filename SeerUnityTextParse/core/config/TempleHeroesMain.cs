using System;

namespace core.config
{
	// Token: 0x02001E7D RID: 7805
	public class TempleHeroesMain : XlsConfigBase<TempleHeroesMain, ITempleHeroesMainInfo>
	{
		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x0600E852 RID: 59474 RVA: 0x003E328B File Offset: 0x003E148B
		public override string fileName
		{
			get
			{
				return "templeHeroesMain";
			}
		}

		// Token: 0x0600E853 RID: 59475 RVA: 0x003E3294 File Offset: 0x003E1494
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITempleHeroesMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITempleHeroesMainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E854 RID: 59476 RVA: 0x003E32E8 File Offset: 0x003E14E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
