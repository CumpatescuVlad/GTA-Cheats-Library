namespace Basic
{
    public class Exeptions : Exception
    {
        public void GenerateNums()
        {
            Exception ex = new Exception();

            Random random = new Random();

            int num = random.Next(1, 10);

            try
            {
                if (num == 2)
                {
                    Console.WriteLine($"This num is {num}.");
                }


            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
            finally
            {


                Console.WriteLine();
            }





        }




    }
}
