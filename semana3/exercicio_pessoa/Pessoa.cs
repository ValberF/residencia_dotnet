namespace Semana3.ExercicioPessoa {
    public class Pessoa {
        public Pessoa (string name, double height) {
            name = name;
            height = height;
        }

        public string Name { get; private set; }
        public double Height { get; private set; }
    }
}