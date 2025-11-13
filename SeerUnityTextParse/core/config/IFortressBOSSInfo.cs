using System;

namespace core.config
{
	// Token: 0x02001D56 RID: 7510
	public class IFortressBOSSInfo : IConfigItem
	{
		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600DBE0 RID: 56288 RVA: 0x003D3938 File Offset: 0x003D1B38
		// (set) Token: 0x0600DBE1 RID: 56289 RVA: 0x003D3940 File Offset: 0x003D1B40
		public string bossInfo { get; set; }

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600DBE2 RID: 56290 RVA: 0x003D3949 File Offset: 0x003D1B49
		// (set) Token: 0x0600DBE3 RID: 56291 RVA: 0x003D3951 File Offset: 0x003D1B51
		public string fortressName { get; set; }

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x0600DBE4 RID: 56292 RVA: 0x003D395A File Offset: 0x003D1B5A
		// (set) Token: 0x0600DBE5 RID: 56293 RVA: 0x003D3962 File Offset: 0x003D1B62
		public int[] damageToHp { get; set; }

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x0600DBE6 RID: 56294 RVA: 0x003D396B File Offset: 0x003D1B6B
		// (set) Token: 0x0600DBE7 RID: 56295 RVA: 0x003D3973 File Offset: 0x003D1B73
		public int boss { get; set; }

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x0600DBE8 RID: 56296 RVA: 0x003D397C File Offset: 0x003D1B7C
		// (set) Token: 0x0600DBE9 RID: 56297 RVA: 0x003D3984 File Offset: 0x003D1B84
		public int fortressHp { get; set; }

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x0600DBEA RID: 56298 RVA: 0x003D398D File Offset: 0x003D1B8D
		// (set) Token: 0x0600DBEB RID: 56299 RVA: 0x003D3995 File Offset: 0x003D1B95
		public int id { get; set; }

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x003D399E File Offset: 0x003D1B9E
		// (set) Token: 0x0600DBED RID: 56301 RVA: 0x003D39A6 File Offset: 0x003D1BA6
		public int layer { get; set; }

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600DBEE RID: 56302 RVA: 0x003D39AF File Offset: 0x003D1BAF
		// (set) Token: 0x0600DBEF RID: 56303 RVA: 0x003D39B7 File Offset: 0x003D1BB7
		public int petID { get; set; }

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x003D39C0 File Offset: 0x003D1BC0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossInfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.damageToHp = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.damageToHp[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.fortressHp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.fortressName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.layer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
