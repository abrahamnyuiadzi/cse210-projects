namespace PasswordGenerator 
{

    public enum ChartType
    {
    LowerCase,
    DigitsCase,
    UpperCase,
    SymbolsCase,


    }

    public class PasswordGenHelper{

        public static string GeneratePassword() 
        {
           string GeneratedPassword = string.Empty;

           List<Char> charaters  =new List<Char>(); 

           if (GenerateConfig.IslowerCase)
           Characters.AddRange(GetCharacters(charType.LowerCase));

  if (GenerateConfig.IsUpperCase)
           Characters.AddRange(GetCharacters(charType.UpperCase));

  if (GenerateConfig.IsDigitsCase)
           Characters.AddRange(GetCharacters(charType.DigitsCase));

  if (GenerateConfig.IsSymbolsCase)
           Characters.AddRange(GetCharacters(charType.SymbolsCase));

           Random random = new Random();
           List<char> seletedchars =Enumerable.Range(0, generateConfig.Length ).Select(c => chararters [random.Next(Characters.count)]).ToList();
           GeneratedPassword= string.Join("" ,selectedChars);

           return GeneratedPassword;



        }

        public  static List <char> GetCharacters (charType charType)
        {
            if (charType == charType .LowerCase){
                return Enumerable.Range('a', 'z'-'a'+1).Select(i=> (char)i).ToList();
            }

 if (charType == charType .UpperCase){
                return Enumerable.Range('A', 'Z'-'A'+1).Select(i=> (char)i).ToList();
            }
             if (charType == charType.DigitsCase){
                return Enumerable.Range('0', '9'-'0'+1).Select(i=> (char)i).ToList();
            }

                return "!#$%^&*".Where(c=> char.IsSymbol(c)).ToList();
          





        }
    }
}