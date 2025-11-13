using System;

namespace core.config
{
	// Token: 0x02001DD7 RID: 7639
	public class PvpAchieve : XlsConfigBase<PvpAchieve, IPvpAchieveInfo>
	{
		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x0600E110 RID: 57616 RVA: 0x003DA163 File Offset: 0x003D8363
		public override string fileName
		{
			get
			{
				return "pvp_achieve";
			}
		}

		// Token: 0x0600E111 RID: 57617 RVA: 0x003DA16C File Offset: 0x003D836C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpAchieveInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpAchieveInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E112 RID: 57618 RVA: 0x003DA1C0 File Offset: 0x003D83C0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
