using System;

namespace NeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            double i=0;
            NeuralNetwork neuralnetwork = new NeuralNetwork(3, 2, 3);
            i = neuralnetwork.feedfoward(0.01);
            
            neuralnetwork.print();
            
        }
    }
}
