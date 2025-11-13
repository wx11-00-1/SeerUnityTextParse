using System;

namespace core.config
{
	// Token: 0x02001D99 RID: 7577
	public class MonsterVideos : XlsConfigBase<MonsterVideos, IMonsterVideosInfo>
	{
		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x0600DE6A RID: 56938 RVA: 0x003D6CA7 File Offset: 0x003D4EA7
		public override string fileName
		{
			get
			{
				return "monsterVideos";
			}
		}

		// Token: 0x0600DE6B RID: 56939 RVA: 0x003D6CB0 File Offset: 0x003D4EB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMonsterVideosInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMonsterVideosInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x003D6D04 File Offset: 0x003D4F04
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
