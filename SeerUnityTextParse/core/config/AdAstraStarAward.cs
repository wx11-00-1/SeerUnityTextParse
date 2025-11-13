using System;

namespace core.config
{
	// Token: 0x02001C9D RID: 7325
	public class AdAstraStarAward : XlsConfigBase<AdAstraStarAward, IAdAstraStarAwardInfo>
	{
		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x003CA2D7 File Offset: 0x003C84D7
		public override string fileName
		{
			get
			{
				return "AdAstraStarAward";
			}
		}

		// Token: 0x0600D429 RID: 54313 RVA: 0x003CA2E0 File Offset: 0x003C84E0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraStarAwardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraStarAwardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D42A RID: 54314 RVA: 0x003CA334 File Offset: 0x003C8534
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
