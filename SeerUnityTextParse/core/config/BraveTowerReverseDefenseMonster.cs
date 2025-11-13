using System;

namespace core.config
{
	// Token: 0x02001CD1 RID: 7377
	public class BraveTowerReverseDefenseMonster : XlsConfigBase<BraveTowerReverseDefenseMonster, IBraveTowerReverseDefenseMonsterInfo>
	{
		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x0600D632 RID: 54834 RVA: 0x003CC971 File Offset: 0x003CAB71
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_monster";
			}
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x003CC978 File Offset: 0x003CAB78
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTowerReverseDefenseMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTowerReverseDefenseMonsterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x003CC9CC File Offset: 0x003CABCC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
