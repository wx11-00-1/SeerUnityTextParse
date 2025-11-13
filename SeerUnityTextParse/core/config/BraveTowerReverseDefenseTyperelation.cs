using System;

namespace core.config
{
	// Token: 0x02001CD7 RID: 7383
	public class BraveTowerReverseDefenseTyperelation : XlsConfigBase<BraveTowerReverseDefenseTyperelation, IBraveTowerReverseDefenseTyperelationInfo>
	{
		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x0600D65E RID: 54878 RVA: 0x003CCCB2 File Offset: 0x003CAEB2
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_typerelation";
			}
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x003CCCBC File Offset: 0x003CAEBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTowerReverseDefenseTyperelationInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTowerReverseDefenseTyperelationInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D660 RID: 54880 RVA: 0x003CCD10 File Offset: 0x003CAF10
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
