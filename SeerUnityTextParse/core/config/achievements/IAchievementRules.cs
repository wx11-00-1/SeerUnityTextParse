using System;

namespace core.config.achievements
{
	// Token: 0x02002088 RID: 8328
	public class IAchievementRules
	{
		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600FE4B RID: 65099 RVA: 0x004041E7 File Offset: 0x004023E7
		// (set) Token: 0x0600FE4C RID: 65100 RVA: 0x004041EF File Offset: 0x004023EF
		public ITypeItem[] type { get; set; }

		// Token: 0x0600FE4D RID: 65101 RVA: 0x004041F8 File Offset: 0x004023F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.type = new ITypeItem[num];
				for (int i = 0; i < num; i++)
				{
					this.type[i] = new ITypeItem();
					this.type[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
