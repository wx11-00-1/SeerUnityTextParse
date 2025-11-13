using System;

namespace core.config.peak_battle_mons
{
	// Token: 0x02001F72 RID: 8050
	public class IPeakBtGlobalRule
	{
		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x0600F198 RID: 61848 RVA: 0x003F64B3 File Offset: 0x003F46B3
		// (set) Token: 0x0600F199 RID: 61849 RVA: 0x003F64BB File Offset: 0x003F46BB
		public IWeeklyIDItem[] WeeklyID { get; set; }

		// Token: 0x0600F19A RID: 61850 RVA: 0x003F64C4 File Offset: 0x003F46C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WeeklyID = new IWeeklyIDItem[num];
				for (int i = 0; i < num; i++)
				{
					this.WeeklyID[i] = new IWeeklyIDItem();
					this.WeeklyID[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
