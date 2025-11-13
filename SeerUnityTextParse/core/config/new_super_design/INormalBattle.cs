using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F87 RID: 8071
	public class INormalBattle
	{
		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x0600F230 RID: 62000 RVA: 0x003F6FF5 File Offset: 0x003F51F5
		// (set) Token: 0x0600F231 RID: 62001 RVA: 0x003F6FFD File Offset: 0x003F51FD
		public string Desc { get; set; }

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x0600F232 RID: 62002 RVA: 0x003F7006 File Offset: 0x003F5206
		// (set) Token: 0x0600F233 RID: 62003 RVA: 0x003F700E File Offset: 0x003F520E
		public string RuleID { get; set; }

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x0600F234 RID: 62004 RVA: 0x003F7017 File Offset: 0x003F5217
		// (set) Token: 0x0600F235 RID: 62005 RVA: 0x003F701F File Offset: 0x003F521F
		public ITaskItem[] Task { get; set; }

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x0600F236 RID: 62006 RVA: 0x003F7028 File Offset: 0x003F5228
		// (set) Token: 0x0600F237 RID: 62007 RVA: 0x003F7030 File Offset: 0x003F5230
		public int BattleCnt { get; set; }

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x0600F238 RID: 62008 RVA: 0x003F7039 File Offset: 0x003F5239
		// (set) Token: 0x0600F239 RID: 62009 RVA: 0x003F7041 File Offset: 0x003F5241
		public int Out { get; set; }

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x0600F23A RID: 62010 RVA: 0x003F704A File Offset: 0x003F524A
		// (set) Token: 0x0600F23B RID: 62011 RVA: 0x003F7052 File Offset: 0x003F5252
		public int TaskStyle { get; set; }

		// Token: 0x0600F23C RID: 62012 RVA: 0x003F705C File Offset: 0x003F525C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BattleCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Out = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RuleID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
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
