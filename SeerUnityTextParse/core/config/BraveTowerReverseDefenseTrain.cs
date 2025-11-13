using System;

namespace core.config
{
	// Token: 0x02001CD5 RID: 7381
	public class BraveTowerReverseDefenseTrain : XlsConfigBase<BraveTowerReverseDefenseTrain, IBraveTowerReverseDefenseTrainInfo>
	{
		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x0600D652 RID: 54866 RVA: 0x003CCBC2 File Offset: 0x003CADC2
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_train";
			}
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x003CCBCC File Offset: 0x003CADCC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTowerReverseDefenseTrainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTowerReverseDefenseTrainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x003CCC20 File Offset: 0x003CAE20
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
