using System;

namespace core.config
{
	// Token: 0x02001E7B RID: 7803
	public class TempleHeroes : XlsConfigBase<TempleHeroes, ITempleHeroesInfo>
	{
		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600E840 RID: 59456 RVA: 0x003E30E0 File Offset: 0x003E12E0
		public override string fileName
		{
			get
			{
				return "templeHeroes";
			}
		}

		// Token: 0x0600E841 RID: 59457 RVA: 0x003E30E8 File Offset: 0x003E12E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITempleHeroesInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITempleHeroesInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E842 RID: 59458 RVA: 0x003E313C File Offset: 0x003E133C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
