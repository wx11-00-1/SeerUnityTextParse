using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200196B RID: 6507
	public class PetUpdatePropInfo
	{
		// Token: 0x0600CC61 RID: 52321 RVA: 0x003B5848 File Offset: 0x003B3A48
		public PetUpdatePropInfo(ByteArray data)
		{
			this.m_addition = (int)data.ReadUnsignedInt();
			this.m_eggAddition = (int)data.ReadUnsignedInt();
			int num = (int)data.ReadUnsignedInt();
			for (int i = 0; i < num; i++)
			{
				this.m_dataArray.Add(new UpdatePropInfo(data));
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x0600CC62 RID: 52322 RVA: 0x003B58A2 File Offset: 0x003B3AA2
		public List<UpdatePropInfo> dataArray
		{
			get
			{
				return this.m_dataArray;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600CC63 RID: 52323 RVA: 0x003B58AA File Offset: 0x003B3AAA
		public double addition
		{
			get
			{
				return (double)(this.m_addition / 100);
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x0600CC64 RID: 52324 RVA: 0x003B58B6 File Offset: 0x003B3AB6
		public int addPer
		{
			get
			{
				return this.m_addition;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x0600CC65 RID: 52325 RVA: 0x003B58BE File Offset: 0x003B3ABE
		public int eggAddition
		{
			get
			{
				return this.m_eggAddition;
			}
		}

		// Token: 0x0400E2B3 RID: 58035
		private int m_addition;

		// Token: 0x0400E2B4 RID: 58036
		private int m_eggAddition;

		// Token: 0x0400E2B5 RID: 58037
		private List<UpdatePropInfo> m_dataArray = new List<UpdatePropInfo>();
	}
}
