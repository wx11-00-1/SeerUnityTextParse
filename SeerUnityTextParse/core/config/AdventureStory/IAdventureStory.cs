using System;

namespace core.config.AdventureStory
{
	// Token: 0x02002630 RID: 9776
	public class IAdventureStory
	{
		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0601339F RID: 78751 RVA: 0x004C7358 File Offset: 0x004C5558
		// (set) Token: 0x060133A0 RID: 78752 RVA: 0x004C7360 File Offset: 0x004C5560
		public IStoryItem[] Story { get; set; }

		// Token: 0x060133A1 RID: 78753 RVA: 0x004C736C File Offset: 0x004C556C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Story = new IStoryItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Story[i] = new IStoryItem();
					this.Story[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
