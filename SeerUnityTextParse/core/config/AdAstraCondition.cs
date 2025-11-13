using System;

namespace core.config
{
	// Token: 0x02001C93 RID: 7315
	public class AdAstraCondition : XlsConfigBase<AdAstraCondition, IAdAstraConditionInfo>
	{
		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x003C9A35 File Offset: 0x003C7C35
		public override string fileName
		{
			get
			{
				return "AdAstraCondition";
			}
		}

		// Token: 0x0600D3B1 RID: 54193 RVA: 0x003C9A3C File Offset: 0x003C7C3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraConditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraConditionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x003C9A90 File Offset: 0x003C7C90
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
