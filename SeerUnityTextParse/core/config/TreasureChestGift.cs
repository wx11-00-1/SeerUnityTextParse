using System;

namespace core.config
{
	// Token: 0x02001E81 RID: 7809
	public class TreasureChestGift : XlsConfigBase<TreasureChestGift, ITreasureChestGiftInfo>
	{
		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600E87C RID: 59516 RVA: 0x003E35D3 File Offset: 0x003E17D3
		public override string fileName
		{
			get
			{
				return "treasure_chest_gift";
			}
		}

		// Token: 0x0600E87D RID: 59517 RVA: 0x003E35DC File Offset: 0x003E17DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITreasureChestGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITreasureChestGiftInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E87E RID: 59518 RVA: 0x003E3630 File Offset: 0x003E1830
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
