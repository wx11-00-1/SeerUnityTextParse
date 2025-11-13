using System;

namespace core.config
{
	// Token: 0x02001D2F RID: 7471
	public class DeepSeaRoom : XlsConfigBase<DeepSeaRoom, IDeepSeaRoomInfo>
	{
		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600DA4A RID: 55882 RVA: 0x003D18A6 File Offset: 0x003CFAA6
		public override string fileName
		{
			get
			{
				return "deepSeaRoom";
			}
		}

		// Token: 0x0600DA4B RID: 55883 RVA: 0x003D18B0 File Offset: 0x003CFAB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepSeaRoomInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepSeaRoomInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA4C RID: 55884 RVA: 0x003D1904 File Offset: 0x003CFB04
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
