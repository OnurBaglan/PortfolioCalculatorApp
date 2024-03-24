public class ApiKeyRepository
{
	public void Save(string apiKey, APISources apiSource)
	{

		File.WriteAllText(string.Format("/apiKey{0}",(int)apiSource), apiKey);

	}

	public string? Load(APISources apiSource)
	{
		if (File.Exists(string.Format("/apiKey{0}", (int)apiSource)))
		{
			var data = File.ReadAllText(string.Format("/apiKey{0}", (int)apiSource));
			return data;
		}

		return null;
	}
}