using System;
namespace _05._08._2023
{
	internal static class Extension
	{
		public static bool CustomContains(this string sentence)
		{
			string str = "Bu bir custom contains methodudur";
			 
			for (int i = 0; i < str.Length; i++)  //1
			{
				if (str[i] == 'B')
				{
					for (int j = 0; j < str.Length; j++)
					{
						if (str[j] == 'u')
						{
							break;
				
						}
						return true;
					}
				}

			}
		
            for (int i = 0; i < str.ToLower().Length; i++)  //2
            {
                if (str[i] == 'b')
                {
                    for (int j = 0; j < str.ToLower().Length; j++)
                    {
                        if (str[j] == 'u')
                        {
                            break;

                        }
                        return true;
                    }
                }

            }
			return false;








        }

		public static void CustomSplit(this string sentence)
		{
			string str = "Bu bir custom split methodudur";
			char chr = 'i';
			int value = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str.ElementAt(i) == chr)
				{
					value++;
				}
			}
			String[] splitArray = new String[value];
			for (int i = 0; i < splitArray.Length; i++)
			{
				for (int j = 0; j < str.Length; j++)
				{
					if (str.ElementAt(j) == chr)
					{
						splitArray[i] = str.Substring(0, j);
						str = str.Substring(j + 1, str.Length);

					}
				}
				//return splitArray ;
				Console.WriteLine(splitArray);
			}

			//return null;
			Console.WriteLine("nothing");

		}
	}

}

