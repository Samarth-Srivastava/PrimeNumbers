namespace PrimeNumbers
{
    public class Solution
    {
        public void solve()
        {

        }

        public bool isPrime(int n)
        {
            bool isPrimeFlag = true;

            if (n % 2 == 0){
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
    }
}
