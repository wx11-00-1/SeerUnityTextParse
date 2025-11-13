using System;

namespace core.config
{
	// Token: 0x02001E8E RID: 7822
	public class IYear2025QteMainInfo : IConfigItem
	{
		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x003E3E30 File Offset: 0x003E2030
		// (set) Token: 0x0600E8E1 RID: 59617 RVA: 0x003E3E38 File Offset: 0x003E2038
		public int[] buttons { get; set; }

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x0600E8E2 RID: 59618 RVA: 0x003E3E41 File Offset: 0x003E2041
		// (set) Token: 0x0600E8E3 RID: 59619 RVA: 0x003E3E49 File Offset: 0x003E2049
		public int[] waves { get; set; }

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600E8E4 RID: 59620 RVA: 0x003E3E52 File Offset: 0x003E2052
		// (set) Token: 0x0600E8E5 RID: 59621 RVA: 0x003E3E5A File Offset: 0x003E205A
		public int id { get; set; }

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x0600E8E6 RID: 59622 RVA: 0x003E3E63 File Offset: 0x003E2063
		// (set) Token: 0x0600E8E7 RID: 59623 RVA: 0x003E3E6B File Offset: 0x003E206B
		public int type { get; set; }

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x003E3E74 File Offset: 0x003E2074
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.buttons = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.buttons[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.waves = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.waves[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
