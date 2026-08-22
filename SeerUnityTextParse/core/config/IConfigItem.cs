namespace core.config
{
	public interface IConfigItem
	{
		int id { get; set; }

		void Parse(byte[] bytes, ref int byteIndex);
	}
}
