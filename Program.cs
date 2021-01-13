using System;

namespace NeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Matrix A = new Matrix("A", 2, 2);
            Matrix B = new Matrix("B", 2, 2);
            Matrix C = new Matrix("C", 2, 2);
	        Matrix D = new Matrix("D", 2, 2);

            if(A.make() == 0)
                Console.WriteLine(A.show());
            if(B.make() == 0)
                Console.WriteLine(B.show());
            if(C.mul(A, B) == 0)
                Console.WriteLine(C.show());
            if(D.add(B, C) == 0)
	            Console.WriteLine(D.show());    */
            NeuralNetwork neuralnetwork = new NeuralNetwork(2, 3, 2);
	        neuralnetwork.init();
        }
    }
}
