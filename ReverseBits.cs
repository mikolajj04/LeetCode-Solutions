//Reverse bits of a given 32 bits signed integer.
//Example 1:

//Input: n = 43261596 (00000010100101000001111010011100)

//Output: 964176192 (00111001011110000010100101000000)


public class Solution {
      public int ReverseBits(int n)
  {
      string bitNum = Convert.ToString(n, 2).PadLeft(32, '0');
  char[] charBitNum = bitNum.ToCharArray();
  Array.Reverse(charBitNum);
  string reversedStringBits= new string(charBitNum);
  int result = Convert.ToInt32(reversedStringBits, 2);
  return result;
        
  }
}
