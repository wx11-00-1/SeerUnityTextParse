using System;

namespace core.config.free_monster_list
{
	// Token: 0x02002031 RID: 8241
	public class IMonsters
	{
		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x0600FB9F RID: 64415 RVA: 0x00400F7A File Offset: 0x003FF17A
		// (set) Token: 0x0600FBA0 RID: 64416 RVA: 0x00400F82 File Offset: 0x003FF182
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600FBA1 RID: 64417 RVA: 0x00400F8B File Offset: 0x003FF18B
		// (set) Token: 0x0600FBA2 RID: 64418 RVA: 0x00400F93 File Offset: 0x003FF193
		public string SumDes { get; set; }

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600FBA3 RID: 64419 RVA: 0x00400F9C File Offset: 0x003FF19C
		// (set) Token: 0x0600FBA4 RID: 64420 RVA: 0x00400FA4 File Offset: 0x003FF1A4
		public string UpdateDes { get; set; }

		// Token: 0x0600FBA5 RID: 64421 RVA: 0x00400FB0 File Offset: 0x003FF1B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Monster = new IMonsterItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Monster[i] = new IMonsterItem();
					this.Monster[i].Parse(bytes, ref byteIndex);
				}
			}
			this.SumDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.UpdateDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
