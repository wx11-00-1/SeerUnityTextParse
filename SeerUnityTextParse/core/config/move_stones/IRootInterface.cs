using System;

namespace core.config.move_stones
{
	// Token: 0x02001FA1 RID: 8097
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x0600F35E RID: 62302 RVA: 0x003F8612 File Offset: 0x003F6812
		public override string fileName
		{
			get
			{
				return "move_stones";
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x0600F35F RID: 62303 RVA: 0x003F8619 File Offset: 0x003F6819
		// (set) Token: 0x0600F360 RID: 62304 RVA: 0x003F8621 File Offset: 0x003F6821
		public IMoveStones MoveStones { get; set; }

		// Token: 0x0600F361 RID: 62305 RVA: 0x003F862A File Offset: 0x003F682A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.MoveStones = new IMoveStones();
				this.MoveStones.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F362 RID: 62306 RVA: 0x003F8650 File Offset: 0x003F6850
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
