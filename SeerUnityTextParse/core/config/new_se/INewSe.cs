using System;

namespace core.config.new_se
{
	// Token: 0x02001F8F RID: 8079
	public class INewSe
	{
		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x0600F276 RID: 62070 RVA: 0x003F74D9 File Offset: 0x003F56D9
		// (set) Token: 0x0600F277 RID: 62071 RVA: 0x003F74E1 File Offset: 0x003F56E1
		public INewSeIdxItem[] NewSeIdx { get; set; }

		// Token: 0x0600F278 RID: 62072 RVA: 0x003F74EC File Offset: 0x003F56EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NewSeIdx = new INewSeIdxItem[num];
				for (int i = 0; i < num; i++)
				{
					this.NewSeIdx[i] = new INewSeIdxItem();
					this.NewSeIdx[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
