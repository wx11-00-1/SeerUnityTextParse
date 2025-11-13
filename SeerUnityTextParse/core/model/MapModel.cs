using System;
using common;
using core.config;
using core.manager;


namespace core.model
{
	// Token: 0x02001945 RID: 6469
	public class MapModel
	{


		// Token: 0x0600CBB8 RID: 52152 RVA: 0x003B26AC File Offset: 0x003B08AC
		public int GetLayer(int x, int y)
		{
			if (this.m_RoadInfo.layerInfo == null || this.m_RoadInfo.layerInfo.Length == 0)
			{
				return 0;
			}
			int num = x * this.m_RoadInfo.gridY + y;
			if (num >= this.m_RoadInfo.layerInfo.Length)
			{
				return 0;
			}
			return (int)this.m_RoadInfo.layerInfo[num];
		}



		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x0600CBBB RID: 52155 RVA: 0x003B2723 File Offset: 0x003B0923
		// (set) Token: 0x0600CBBC RID: 52156 RVA: 0x003B272B File Offset: 0x003B092B
		public int gridSize
		{
			get
			{
				return this.m_gridSize;
			}
			set
			{
				this.m_gridSize = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600CBBD RID: 52157 RVA: 0x003B2734 File Offset: 0x003B0934
		// (set) Token: 0x0600CBBE RID: 52158 RVA: 0x003B273C File Offset: 0x003B093C
		public int gridX
		{
			get
			{
				return this.m_gridX;
			}
			set
			{
				this.m_gridX = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600CBBF RID: 52159 RVA: 0x003B2745 File Offset: 0x003B0945
		// (set) Token: 0x0600CBC0 RID: 52160 RVA: 0x003B274D File Offset: 0x003B094D
		public bool[,] data
		{
			get
			{
				return this.m_data;
			}
			set
			{
				this.m_data = value;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600CBC1 RID: 52161 RVA: 0x003B2756 File Offset: 0x003B0956
		public int gridTotal
		{
			get
			{
				return this.m_gridTotal;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x0600CBC2 RID: 52162 RVA: 0x003B275E File Offset: 0x003B095E
		// (set) Token: 0x0600CBC3 RID: 52163 RVA: 0x003B2766 File Offset: 0x003B0966
		public int gridY
		{
			get
			{
				return this.m_gridY;
			}
			set
			{
				this.m_gridY = value;
			}
		}

		// Token: 0x0600CBC6 RID: 52166 RVA: 0x003B2780 File Offset: 0x003B0980
		public void setRoad(bool[,] value)
		{
			this.m_data = value;
		}

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x003B2789 File Offset: 0x003B0989
		public void destroy()
		{
		}

		// Token: 0x0600CBC8 RID: 52168 RVA: 0x003B278B File Offset: 0x003B098B
		public void makeMapArray()
		{
		}


		// Token: 0x0400E115 RID: 57621
		public int mapId;

		// Token: 0x0400E116 RID: 57622
		private float m_width = 960f;

		// Token: 0x0400E117 RID: 57623
		private float m_height = 560f;

		// Token: 0x0400E118 RID: 57624
		private int m_gridSize = 10;

		// Token: 0x0400E119 RID: 57625
		private int m_gridX;

		// Token: 0x0400E11A RID: 57626
		private int m_gridY;

		// Token: 0x0400E11B RID: 57627
		private int m_gridTotal;

		// Token: 0x0400E11C RID: 57628
		private bool[,] m_data;

		// Token: 0x0400E11D RID: 57629
		private MapRoadInfo m_RoadInfo;
	}
}
