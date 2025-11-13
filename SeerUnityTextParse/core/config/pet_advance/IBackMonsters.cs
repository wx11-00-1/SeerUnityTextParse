using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F44 RID: 8004
	public class IBackMonsters
	{
		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x0600F01E RID: 61470 RVA: 0x003F4676 File Offset: 0x003F2876
		// (set) Token: 0x0600F01F RID: 61471 RVA: 0x003F467E File Offset: 0x003F287E
		public IBackItem[] Back { get; set; }

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x0600F020 RID: 61472 RVA: 0x003F4687 File Offset: 0x003F2887
		// (set) Token: 0x0600F021 RID: 61473 RVA: 0x003F468F File Offset: 0x003F288F
		public int free_cnt { get; set; }

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x0600F022 RID: 61474 RVA: 0x003F4698 File Offset: 0x003F2898
		// (set) Token: 0x0600F023 RID: 61475 RVA: 0x003F46A0 File Offset: 0x003F28A0
		public int refresh_add_cost { get; set; }

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x0600F024 RID: 61476 RVA: 0x003F46A9 File Offset: 0x003F28A9
		// (set) Token: 0x0600F025 RID: 61477 RVA: 0x003F46B1 File Offset: 0x003F28B1
		public int refresh_base_cost { get; set; }

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x0600F026 RID: 61478 RVA: 0x003F46BA File Offset: 0x003F28BA
		// (set) Token: 0x0600F027 RID: 61479 RVA: 0x003F46C2 File Offset: 0x003F28C2
		public int refresh_max_cost { get; set; }

		// Token: 0x0600F028 RID: 61480 RVA: 0x003F46CC File Offset: 0x003F28CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Back = new IBackItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Back[i] = new IBackItem();
					this.Back[i].Parse(bytes, ref byteIndex);
				}
			}
			this.free_cnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.refresh_add_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.refresh_base_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.refresh_max_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
