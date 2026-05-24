using System;

namespace core.config
{
	// Token: 0x020024BE RID: 9406
	public class CarrygameStage : XlsConfigBase<CarrygameStage, ICarrygameStageInfo>
	{
		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06011E3C RID: 73276 RVA: 0x00507AE5 File Offset: 0x00505CE5
		public override string fileName
		{
			get
			{
				return "carrygame_stage";
			}
		}

		// Token: 0x06011E3D RID: 73277 RVA: 0x00507AEC File Offset: 0x00505CEC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICarrygameStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICarrygameStageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011E3E RID: 73278 RVA: 0x00507B40 File Offset: 0x00505D40
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
