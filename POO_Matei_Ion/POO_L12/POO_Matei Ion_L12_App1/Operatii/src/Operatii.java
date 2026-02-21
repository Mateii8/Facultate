 public class Operatii implements Minus, Plus, Mult, Div {
    private float number;

    public Operatii(float number) {
        this.number = number;
    }

    public float getNumber() {
        return number;
    }

    @Override
    public void minus(float value) {
        number -= value;
    }

    @Override
    public void plus(float value) {
        number += value;
    }

    @Override
    public void mult(float value) {
        number *= value;
    }

    @Override
    public void div(float value) {
        if (value == 0) {
            System.out.println("Impartirea la 0 nu se poate");
        } else {
            number /= value;
        }
    }
}
