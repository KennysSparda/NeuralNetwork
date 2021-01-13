using System;

namespace NeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            NeuralNetwork neuralnetwork = new NeuralNetwork(2, 3, 2);
	        neuralnetwork.feedfoward(1);
            neuralnetwork.print();
        }
    }
}
