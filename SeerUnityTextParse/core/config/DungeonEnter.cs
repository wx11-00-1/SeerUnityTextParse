using System;

namespace core.config
{
	// Token: 0x02001D39 RID: 7481
	public class DungeonEnter : XlsConfigBase<DungeonEnter, IDungeonEnterInfo>
	{
		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x003D1EAB File Offset: 0x003D00AB
		public override string fileName
		{
			get
			{
				return "dungeon_enter";
			}
		}

		// Token: 0x0600DA9B RID: 55963 RVA: 0x003D1EB4 File Offset: 0x003D00B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDungeonEnterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDungeonEnterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA9C RID: 55964 RVA: 0x003D1F08 File Offset: 0x003D0108
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
