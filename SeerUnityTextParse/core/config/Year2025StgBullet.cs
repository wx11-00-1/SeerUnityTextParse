using System;

namespace core.config
{
	// Token: 0x02001E8F RID: 7823
	public class Year2025StgBullet : XlsConfigBase<Year2025StgBullet, IYear2025StgBulletInfo>
	{
		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x0600E8EA RID: 59626 RVA: 0x003E3F13 File Offset: 0x003E2113
		public override string fileName
		{
			get
			{
				return "year2025_stg_bullet";
			}
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x003E3F1C File Offset: 0x003E211C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYear2025StgBulletInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYear2025StgBulletInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8EC RID: 59628 RVA: 0x003E3F70 File Offset: 0x003E2170
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
