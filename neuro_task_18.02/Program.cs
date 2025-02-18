namespace neuro_task_18._02
{

    
        internal class Program
        {
            static void Main(string[] args)
            {
                double[] inputData = new double[] { 10.0, 8.0, 6.0, 3.0 };
                double[] outputData = new double[] { 1, 0.8, 0.6, 0.3 };

                double weigh = 0.8; //new Random().NextDouble();
                double alpha = 0.003;

                for (int epoch = 0; epoch < 10; epoch++)
                    for (int i = 0; i < inputData.Length; i++)
                    {
                        double pred = inputData[i] * weigh;
                        double delta = pred - outputData[i];
                        double weigh_delta = inputData[i] * delta;
                        weigh -= weigh_delta * alpha;
                        Console.WriteLine(weigh);
                    }

            }
        }
    

}
