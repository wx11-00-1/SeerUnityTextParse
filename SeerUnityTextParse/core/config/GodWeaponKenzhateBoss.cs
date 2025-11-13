using System;

namespace core.config
{
	// Token: 0x02001D5F RID: 7519
	public class GodWeaponKenzhateBoss : XlsConfigBase<GodWeaponKenzhateBoss, IGodWeaponKenzhateBossInfo>
	{
		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x0600DC2E RID: 56366 RVA: 0x003D3F16 File Offset: 0x003D2116
		public override string fileName
		{
			get
			{
				return "GodWeaponKenzhateBoss";
			}
		}

		// Token: 0x0600DC2F RID: 56367 RVA: 0x003D3F20 File Offset: 0x003D2120
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IGodWeaponKenzhateBossInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IGodWeaponKenzhateBossInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x003D3F74 File Offset: 0x003D2174
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
