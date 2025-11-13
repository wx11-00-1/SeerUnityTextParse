using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F86 RID: 8070
	public class IEasyBattle
	{
		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x0600F224 RID: 61988 RVA: 0x003F6F0A File Offset: 0x003F510A
		// (set) Token: 0x0600F225 RID: 61989 RVA: 0x003F6F12 File Offset: 0x003F5112
		public string Desc { get; set; }

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x0600F226 RID: 61990 RVA: 0x003F6F1B File Offset: 0x003F511B
		// (set) Token: 0x0600F227 RID: 61991 RVA: 0x003F6F23 File Offset: 0x003F5123
		public ITaskItem[] Task { get; set; }

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x0600F228 RID: 61992 RVA: 0x003F6F2C File Offset: 0x003F512C
		// (set) Token: 0x0600F229 RID: 61993 RVA: 0x003F6F34 File Offset: 0x003F5134
		public int BattleCnt { get; set; }

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x0600F22A RID: 61994 RVA: 0x003F6F3D File Offset: 0x003F513D
		// (set) Token: 0x0600F22B RID: 61995 RVA: 0x003F6F45 File Offset: 0x003F5145
		public int Out { get; set; }

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x0600F22C RID: 61996 RVA: 0x003F6F4E File Offset: 0x003F514E
		// (set) Token: 0x0600F22D RID: 61997 RVA: 0x003F6F56 File Offset: 0x003F5156
		public int TaskStyle { get; set; }

		// Token: 0x0600F22E RID: 61998 RVA: 0x003F6F60 File Offset: 0x003F5160
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BattleCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Out = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Task = new ITaskItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Task[i] = new ITaskItem();
					this.Task[i].Parse(bytes, ref byteIndex);
				}
			}
			this.TaskStyle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
