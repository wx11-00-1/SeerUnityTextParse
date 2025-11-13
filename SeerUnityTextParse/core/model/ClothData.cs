using System;
using common;
using core.config;

namespace core.model
{
	// Token: 0x02001922 RID: 6434
	public class ClothData
	{
		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600CA78 RID: 51832 RVA: 0x003B0085 File Offset: 0x003AE285
		// (set) Token: 0x0600CA77 RID: 51831 RVA: 0x003B007C File Offset: 0x003AE27C
		public int id { get; private set; }

		// Token: 0x0600CA79 RID: 51833 RVA: 0x003B008D File Offset: 0x003AE28D
		public ClothData(int id)
		{
			this.id = id;
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x0600CA7A RID: 51834 RVA: 0x003B009C File Offset: 0x003AE29C
		public long price
		{
			get
			{
				return (long)ResetableSingleTon<ItemXMLInfo>.Ins.getPrice(this.id);
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600CA7B RID: 51835 RVA: 0x003B00AF File Offset: 0x003AE2AF
		public string type
		{
			get
			{
				return ResetableSingleTon<ItemXMLInfo>.Ins.gettype(this.id);
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x0600CA7C RID: 51836 RVA: 0x003B00C1 File Offset: 0x003AE2C1
		public string name
		{
			get
			{
				return ResetableSingleTon<ItemXMLInfo>.Ins.getName(this.id);
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600CA7D RID: 51837 RVA: 0x003B00D3 File Offset: 0x003AE2D3
		public int actionDir
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600CA7E RID: 51838 RVA: 0x003B00D6 File Offset: 0x003AE2D6
		public int repairPrice
		{
			get
			{
				return ResetableSingleTon<ItemXMLInfo>.Ins.getRepairPrice(this.id);
			}
		}
	}
}
