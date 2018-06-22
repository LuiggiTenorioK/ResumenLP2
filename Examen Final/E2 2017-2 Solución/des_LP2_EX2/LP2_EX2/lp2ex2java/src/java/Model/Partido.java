package Model;

public class Partido {

    /**
     * @return the eqA
     */
    public int getEqA() {
        return eqA;
    }

    /**
     * @param eqA the eqA to set
     */
    public void setEqA(int eqA) {
        this.eqA = eqA;
    }

    /**
     * @return the eqB
     */
    public int getEqB() {
        return eqB;
    }

    /**
     * @param eqB the eqB to set
     */
    public void setEqB(int eqB) {
        this.eqB = eqB;
    }

    /**
     * @return the gEqA
     */
    public int getgEqA() {
        return gEqA;
    }

    /**
     * @param gEqA the gEqA to set
     */
    public void setgEqA(int gEqA) {
        this.gEqA = gEqA;
    }

    /**
     * @return the gEqB
     */
    public int getgEqB() {
        return gEqB;
    }

    /**
     * @param gEqB the gEqB to set
     */
    public void setgEqB(int gEqB) {
        this.gEqB = gEqB;
    }

    /**
     * @return the jugado
     */
    public boolean isJugado() {
        return jugado;
    }

    /**
     * @param jugado the jugado to set
     */
    public void setJugado(boolean jugado) {
        this.jugado = jugado;
    }
    private int eqA;
    private int eqB;
    private int gEqA;
    private int gEqB;
    private boolean jugado;

    public Partido() {
        eqA = 0;
        eqB = 0;
        gEqA = 0;
        gEqB = 0;
        jugado = false;
    }
    
    
}
