using System;

namespace core.config
{
	// Token: 0x0200255C RID: 9564
	public class AutocardbattlepassTask : XlsConfigBase<AutocardbattlepassTask, IAutocardbattlepassTaskInfo>
	{
		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x0601287B RID: 75899 RVA: 0x00545319 File Offset: 0x00543519
		public override string fileName
		{
			get
			{
				return "autocardbattlepass_task";
			}
		}

		// Token: 0x0601287C RID: 75900 RVA: 0x00545320 File Offset: 0x00543520
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardbattlepassTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardbattlepassTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x00545374 File Offset: 0x00543574
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
