using System;

namespace core.config.TeamTaskMonsters
{
	// Token: 0x0200248A RID: 9354
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06012174 RID: 74100 RVA: 0x004B205E File Offset: 0x004B025E
		public override string fileName
		{
			get
			{
				return "TeamTaskMonsters";
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06012175 RID: 74101 RVA: 0x004B2065 File Offset: 0x004B0265
		// (set) Token: 0x06012176 RID: 74102 RVA: 0x004B206D File Offset: 0x004B026D
		public IMonsterPool MonsterPool { get; set; }

		// Token: 0x06012177 RID: 74103 RVA: 0x004B2076 File Offset: 0x004B0276
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.MonsterPool = new IMonsterPool();
				this.MonsterPool.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012178 RID: 74104 RVA: 0x004B209C File Offset: 0x004B029C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
