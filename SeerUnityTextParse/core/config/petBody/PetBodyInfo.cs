using System;

namespace core.config.petBody
{
	public class PetBodyInfo
	{
		public void Parse(byte[] bytes, ref int index)
		{
			this.petId = ByteUtil.ReadSignedInt(bytes, ref index);
			this.position = new Vector2(ByteUtil.ReadFloat(bytes, ref index), ByteUtil.ReadFloat(bytes, ref index));
			this.scale = ByteUtil.ReadFloat(bytes, ref index);
		}

		public int petId;

		public Vector2 position;

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
