using System;

namespace core.config
{
	// Token: 0x02002572 RID: 9586
	public class AutocarddiduoReward : XlsConfigBase<AutocarddiduoReward, IAutocarddiduoRewardInfo>
	{
		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0601295F RID: 76127 RVA: 0x00546395 File Offset: 0x00544595
		public override string fileName
		{
			get
			{
				return "autocarddiduo_reward";
			}
		}

		// Token: 0x06012960 RID: 76128 RVA: 0x0054639C File Offset: 0x0054459C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocarddiduoRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocarddiduoRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012961 RID: 76129 RVA: 0x005463F0 File Offset: 0x005445F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
