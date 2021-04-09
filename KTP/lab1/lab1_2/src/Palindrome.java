public class Palindrome 
{
	public static void main(String[] args) 
	{
		for(int i = 0; i < args.length; i++)
		{
			String s = args[i];

			if(isPalindrome(s))
			{
				System.out.println("Строка " + s + " - палиндром");
			}
			else
			{
				System.out.println("Строка " + s + " - не палиндром");
			}
		}
	}

	// Проверяет, является ли строка палиндромом
	public static boolean isPalindrome(String s) 
	{
        if (s.equals(reverseString(s)))
		{
			return true;
		}
		else
		{
			return false;
		}
    }

	// Возвращает строку инвертированной
	public static String reverseString(String s)
	{
		String result = "";
		
        for (int i = s.length() - 1; i >= 0; i--) 
		{
            result += s.charAt(i);
		}

        return result;
	}
}
