using System;

namespace NeuralNetwork {
    public class NeuralNetwork {
        int i_nodes, h_nodes, o_nodes;
        Matrix bias_ih;
        
        public NeuralNetwork(int i_nodes, int h_nodes, int o_nodes) {
            this.i_nodes = i_nodes;
            this.h_nodes = h_nodes;
            this.o_nodes = o_nodes;

            this.bias_ih = new Matrix("bias_ih", i_nodes, h_nodes);
            bias_ih.randomize();
            bias_ih.show();
        }
    }
}