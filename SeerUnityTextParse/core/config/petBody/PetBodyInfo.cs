using System;

namespace core.config.petBody
{
	// Token: 0x02002777 RID: 10103
	public class PetBodyInfo
	{
		// Token: 0x06013DB9 RID: 81337 RVA: 0x00536284 File Offset: 0x00534484
		public void Parse(byte[] bytes, ref int index)
		{
			this.petId = ByteUtil.ReadSignedInt(bytes, ref index);
			this.position = new Vector2(ByteUtil.ReadFloat(bytes, ref index), ByteUtil.ReadFloat(bytes, ref index));
			this.scale = ByteUtil.ReadFloat(bytes, ref index);
		}

		// Token: 0x0401323C RID: 78396
		public int petId;

		// Token: 0x0401323D RID: 78397
		public Vector2 position;

		// Token: 0x0401323E RID: 78398
		public float scale;

		public class Vector2
		{
			public float x, y;
			public Vector2(float x, float y)
			{
				this.x = x; this.y = y;
			}
		}
    }
}
