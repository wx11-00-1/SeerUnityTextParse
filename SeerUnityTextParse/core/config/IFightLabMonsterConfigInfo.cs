using System;

namespace core.config
{
	// Token: 0x02001D4E RID: 7502
	public class IFightLabMonsterConfigInfo : IConfigItem
	{
		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x003D2F98 File Offset: 0x003D1198
		// (set) Token: 0x0600DB7F RID: 56191 RVA: 0x003D2FA0 File Offset: 0x003D11A0
		public string monsterIntro { get; set; }

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600DB80 RID: 56192 RVA: 0x003D2FA9 File Offset: 0x003D11A9
		// (set) Token: 0x0600DB81 RID: 56193 RVA: 0x003D2FB1 File Offset: 0x003D11B1
		public int[] monsterData { get; set; }

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x003D2FBA File Offset: 0x003D11BA
		// (set) Token: 0x0600DB83 RID: 56195 RVA: 0x003D2FC2 File Offset: 0x003D11C2
		public int[] monsterMove { get; set; }

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x003D2FCB File Offset: 0x003D11CB
		// (set) Token: 0x0600DB85 RID: 56197 RVA: 0x003D2FD3 File Offset: 0x003D11D3
		public int id { get; set; }

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600DB86 RID: 56198 RVA: 0x003D2FDC File Offset: 0x003D11DC
		// (set) Token: 0x0600DB87 RID: 56199 RVA: 0x003D2FE4 File Offset: 0x003D11E4
		public int monsterId { get; set; }

		// Token: 0x0600DB88 RID: 56200 RVA: 0x003D2FF0 File Offset: 0x003D11F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monsterData = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.monsterData[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monsterMove = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.monsterMove[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
