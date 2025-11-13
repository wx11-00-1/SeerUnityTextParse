using System;

namespace core.config
{
	// Token: 0x02001CDF RID: 7391
	public class BtlCondition : XlsConfigBase<BtlCondition, IBtlConditionInfo>
	{
		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600D696 RID: 54934 RVA: 0x003CD1F4 File Offset: 0x003CB3F4
		public override string fileName
		{
			get
			{
				return "btl_condition";
			}
		}

		// Token: 0x0600D697 RID: 54935 RVA: 0x003CD1FC File Offset: 0x003CB3FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBtlConditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBtlConditionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D698 RID: 54936 RVA: 0x003CD250 File Offset: 0x003CB450
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
