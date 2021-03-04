using System;

namespace NeuralNetwork {
    public class NeuralNetwork {
        int i_nodes, h_nodes, o_nodes;
        Matrix input, hide, output, weigth_ih, weigth_ho, bias_ih, bias_ho, prod1, prod2;

        public NeuralNetwork(int i_nodes, int h_nodes, int o_nodes) {
            this.i_nodes = i_nodes;
            this.h_nodes = h_nodes;
            this.o_nodes = o_nodes;

            this.input = new Matrix("input", 1, this.i_nodes);
            this.hide = new Matrix("hide", 1, this.h_nodes);
            this.output = new Matrix("output", 1, this.o_nodes);
            this.weigth_ih = new Matrix("weigth_ih", this.i_nodes, this.h_nodes);
            this.weigth_ho = new Matrix("weigth_ho", this.h_nodes, this.o_nodes);
            this.bias_ih = new Matrix("bias_ih", 1, this.h_nodes);
            this.bias_ho = new Matrix("bias_ho", 1, this.o_nodes);
            this.prod1 = new Matrix("prod1", 1, this.h_nodes);
            this.prod2 = new Matrix("prod2", 1, this.o_nodes);
        }

        private double sigmoid(double z) {
            return 1 / ( 1 + Math.Exp(-z));
        }

        public double feedfoward(double input_value) {
            this.input.set(input_value);
            this.weigth_ih.randomize(0,11);
            this.bias_ih.randomize(0,4);
            this.prod1.mul(this.input, this.weigth_ih);
            this.prod1.add(this.prod1, this.bias_ih);
            for(int i=0; i<this.hide.line; i++) {
                for(int j=0; j<this.hide.column; j++) {
                    this.hide.set_one(i, j, this.sigmoid(this.prod1.data[i,j]));
                }
            }
            this.weigth_ho.randomize(0,11);
            this.bias_ho.randomize(0,4);
            this.prod2.mul(this.hide, this.weigth_ho);
            this.prod2.add(this.prod2, this.bias_ho);
            for(int i=0; i<this.output.line; i++) {
                for(int j=0; j<this.output.column; j++) {
                    this.output.set_one(i, j, this.sigmoid(this.prod2.data[i,j]));
                }
            }
	          return this.output.data[0,0];
        }

        public void print() {
	          Console.Clear();
            Console.WriteLine(this.input.show());
            //Console.WriteLine(this.weigth_ih.show());
            //Console.WriteLine(this.bias_ih.show());
            Console.WriteLine(this.hide.show());
            //Console.WriteLine(this.weigth_ho.show());
            //Console.WriteLine(this.bias_ho.show());
            Console.WriteLine(this.output.show());
        }
    }
}
