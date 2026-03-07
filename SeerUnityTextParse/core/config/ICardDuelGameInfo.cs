using System;

namespace core.config
{
	// Token: 0x02001F37 RID: 7991
	public class ICardDuelGameInfo : IConfigItem
	{
		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x0042F0C8 File Offset: 0x0042D2C8
		// (set) Token: 0x0600ECFD RID: 60669 RVA: 0x0042F0D0 File Offset: 0x0042D2D0
		public int[] attackPos { get; set; }

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x0600ECFE RID: 60670 RVA: 0x0042F0D9 File Offset: 0x0042D2D9
		// (set) Token: 0x0600ECFF RID: 60671 RVA: 0x0042F0E1 File Offset: 0x0042D2E1
		public int actionType { get; set; }

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600ED00 RID: 60672 RVA: 0x0042F0EA File Offset: 0x0042D2EA
		// (set) Token: 0x0600ED01 RID: 60673 RVA: 0x0042F0F2 File Offset: 0x0042D2F2
		public int id { get; set; }

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600ED02 RID: 60674 RVA: 0x0042F0FB File Offset: 0x0042D2FB
		// (set) Token: 0x0600ED03 RID: 60675 RVA: 0x0042F103 File Offset: 0x0042D303
		public int prepareTime { get; set; }

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600ED04 RID: 60676 RVA: 0x0042F10C File Offset: 0x0042D30C
		// (set) Token: 0x0600ED05 RID: 60677 RVA: 0x0042F114 File Offset: 0x0042D314
		public int value { get; set; }

		// Token: 0x0600ED06 RID: 60678 RVA: 0x0042F120 File Offset: 0x0042D320
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.actionType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.attackPos = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.attackPos[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.prepareTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
