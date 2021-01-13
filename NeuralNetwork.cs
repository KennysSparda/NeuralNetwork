using System;

namespace NeuralNetwork {
    public class NeuralNetwork {
        int i_nodes, h_nodes, o_nodes;
        Matrix weigth_ih, weigth_ho, bias_ih, bias_ho;

        public NeuralNetwork(int i_nodes, int h_nodes, int o_nodes) {
            this.i_nodes = i_nodes;
            this.h_nodes = h_nodes;
            this.o_nodes = o_nodes;

            this.weigth_ih = new Matrix("weigth_ih", this.h_nodes, 1);
            this.weigth_ho = new Matrix("weigth_ho", this.h_nodes, 1);
            this.bias_ih = new Matrix("bias_ih", this.h_nodes, 1);
            this.bias_ho = new Matrix("bias_ho", this.h_nodes, 1);
        }

	        public void init() { 
            this.weigth_ih.randomize();
            this.weigth_ho.randomize();
            this.bias_ih.randomize();
            this.bias_ho.randomize();
            Console.WriteLine(this.bias_ih.show());
            Console.WriteLine(this.bias_ho.show());
            Console.WriteLine(this.weigth_ih.show());
            Console.WriteLine(this.weigth_ho.show());
        }
    }
}
