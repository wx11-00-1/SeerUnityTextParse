using System;

namespace core.config.free_monster_list
{
	// Token: 0x02002032 RID: 8242
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600FBA7 RID: 64423 RVA: 0x00401032 File Offset: 0x003FF232
		public override string fileName
		{
			get
			{
				return "free_monster_list";
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600FBA8 RID: 64424 RVA: 0x00401039 File Offset: 0x003FF239
		// (set) Token: 0x0600FBA9 RID: 64425 RVA: 0x00401041 File Offset: 0x003FF241
		public IMonsters Monsters { get; set; }

		// Token: 0x0600FBAA RID: 64426 RVA: 0x0040104A File Offset: 0x003FF24A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Monsters = new IMonsters();
				this.Monsters.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FBAB RID: 64427 RVA: 0x00401070 File Offset: 0x003FF270
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
