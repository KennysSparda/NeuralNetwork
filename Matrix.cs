using System;

namespace NeuralNetwork {
    public class Matrix {
        public string name;
        public int line, column;
        public double[,] data { get; set; }

        public Matrix(string n, int lin, int col) {
            this.name = n;
            this.line = lin;
            this.column = col;
            this.data = new double[this.line, this.column];
        }

        public string show() {
            string s = "";
            for(int i=0; i<this.line; i++) {
                for(int j=0; j<this.column; j++) {
                    s += Convert.ToString(this.data[i,j]) + "\t";
                }
                s += "\n";
            }
            return "Name: " + this.name + ", lines: " + this.line + ", columns: " + this.column + "\n" + s;
        }

        public int set_one(int lin, int col, double value) {
            this.data[lin, col] = value;
            return 0;
        }

        public int set(double value) {
            for(int i=0; i<this.line; i++) {
                for(int j=0; j<this.column; j++) {
                    this.data[i,j] = value;
                }
            }
            return 0;
        }

        public int randomize() {
            var random = new Random();
            for(int i=0; i<this.line; i++) {
                for(int j=0; j<this.column; j++) {
                    var value = random.Next(1, 10);
                    this.data[i, j] = value;
                }
            }
            return 0;
        }

        public int add(Matrix A, Matrix B) {
            if(A.line == B.line && A.column == B.column) {
                for(int i=0; i<this.line; i++) {
                    for(int j=0; j<this.column; j++) {
                        this.data[i,j] = A.data[i,j] + B.data[i,j];
                    }
                }
                return 0;
            } else {
                Console.WriteLine("These arrays cannot be added.");
                return 1;
            }
        }

        public int mul(Matrix A, Matrix B) {
            if(A.column == B.line){
                double cont = 0;
                for(int i=0; i<A.line; i++) {
                    for(int j=0; j<B.column; j++) {
                        for(int x=0; x<A.column; x++) {
                            cont += A.data[i,x] * B.data[x,j];
                        }
                        this.data[i,j] = cont;
                        cont = 0;
                    }
                }
                return 0;
            } else {
                Console.WriteLine("These matrices are not can be multiplied.");
                return 1;
            }
        }
    }
}
