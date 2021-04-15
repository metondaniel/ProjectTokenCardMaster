using ProjectTokenCard.Domain.Interfaces.Services;
using ProjectTokenCard.Domain.Model;
using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Services
{
    public class TokenService
    {
        public TokenService()
        {
        }
        public Guid GenerateToken(int[] numbers,int ccvNumber)
        {

            for (int i = 0; i < ccvNumber; i++)
            {
                numbers = Move(numbers);
            }
            var result = string.Join("", numbers);
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(Convert.ToInt32(result)).CopyTo(bytes, 0);
            
            return new Guid(bytes);
        }

        public int[] Move(int[] numbers)
        {
            var totalLength = numbers.Length;
            for (int j = numbers.Length - 1; j > 0 ; j--)
            {
                var temp = numbers[numbers.Length - 1];
                numbers[totalLength - 1] = numbers[j - 1];
                numbers[j - 1] = temp;
            }
            return numbers;
        }
    }
}
