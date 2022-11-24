using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public class Solution
    {
        public void solve()
        {

        }

        public bool isPrime(int n)
        {
            bool isPrimeFlag = false;
            if(n < 2){
                isPrimeFlag = false;
            }
            else if(n == 2){
                isPrimeFlag = true;
            }
            else if (n % 2 == 0){
                isPrimeFlag = false;
            }

            if (isPrimeFlag){
                for (int i = 3; i * i < n; i = i + 2){
                    if (n % i == 0){
                        isPrimeFlag = false;
                        break;
                    }
                }
            }

            return isPrimeFlag;
        }

        public int getNumberOfFactors(int N)
        {
            int f = 2;
            for (int i = 2; i * i <= N; i++){
                if (N % i == 0){
                    if (i == (N / i)){
                        f = f + 1;
                    }
                    else{
                        f = f + 2;
                    }
                }
            }
            return f;
        }

        public List<string> GetAllPrimes(string number){


            //brute force
            List<string> primeList1 = new List<string>();
            int n = Convert.ToInt32(number);
            for(int i = 2; i < n;i++){
                if(isPrime(i)){
                    primeList1.Add(i.ToString());
                }
            }

            return primeList1;
        }
    }
}
