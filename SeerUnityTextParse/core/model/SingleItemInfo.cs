using System;
using common;
using core.config;

namespace core.model
{
	// Token: 0x02001975 RID: 6517
	public class SingleItemInfo
	{
		// Token: 0x0600CC75 RID: 52341 RVA: 0x003B5B40 File Offset: 0x003B3D40
		public SingleItemInfo()
		{
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x003B5B48 File Offset: 0x003B3D48
		public SingleItemInfo(int itemID)
		{
			this.itemID = itemID;
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x003B5B57 File Offset: 0x003B3D57
		public SingleItemInfo(ByteArray data = null, bool hasUpdateTime = false)
		{
			this.init(data, hasUpdateTime);
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x003B5B67 File Offset: 0x003B3D67
		public void update(ByteArray data, bool hasUpdateTime = false)
		{
			this.init(data, hasUpdateTime);
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x003B5B74 File Offset: 0x003B3D74
		private void init(ByteArray data, bool hasUpdateTime = false)
		{
			if (data != null)
			{
				this.itemID = (int)data.ReadUnsignedInt();
				this.itemNum = data.ReadUnsignedInt();
				this.leftTime = data.ReadUnsignedInt();
				this.itemLevel = (int)data.ReadUnsignedInt();
				if (hasUpdateTime)
				{
					this.updateTime = data.ReadUnsignedInt();
				}
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600CC7A RID: 52346 RVA: 0x003B5BC3 File Offset: 0x003B3DC3
		public int type
		{
			get
			{
				if (this.m_type <= 0)
				{
					this.m_type = ResetableSingleTon<ItemXMLInfo>.Ins.getItemType(this.m_itemID);
				}
				return this.m_type;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x0600CC7B RID: 52347 RVA: 0x003B5BEA File Offset: 0x003B3DEA
		// (set) Token: 0x0600CC7C RID: 52348 RVA: 0x003B5BF2 File Offset: 0x003B3DF2
		public int itemID
		{
			get
			{
				return this.m_itemID;
			}
			set
			{
				this.m_itemID = value;
				this.m_type = 0;
				this.rarity = ResetableSingleTon<ItemXMLInfo>.Ins.getRarity(this.m_itemID);
			}
		}

		// Token: 0x0400E2DE RID: 58078
		private int m_itemID;

		// Token: 0x0400E2DF RID: 58079
		protected int m_type;

		// Token: 0x0400E2E0 RID: 58080
		public int itemLevel;

		// Token: 0x0400E2E1 RID: 58081
		public uint itemNum;

		// Token: 0x0400E2E2 RID: 58082
		public uint leftTime;

		// Token: 0x0400E2E3 RID: 58083
		public uint updateTime;

		// Token: 0x0400E2E4 RID: 58084
		public int rarity;
	}
}
