using System;

namespace core.config
{
	// Token: 0x02001CC1 RID: 7361
	public class BattleServerShop : XlsConfigBase<BattleServerShop, IBattleServerShopInfo>
	{
		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600D596 RID: 54678 RVA: 0x003CBE06 File Offset: 0x003CA006
		public override string fileName
		{
			get
			{
				return "BattleServerShop";
			}
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x003CBE10 File Offset: 0x003CA010
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBattleServerShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBattleServerShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D598 RID: 54680 RVA: 0x003CBE64 File Offset: 0x003CA064
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
