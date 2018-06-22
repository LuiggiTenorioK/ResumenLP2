/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Model;

/**
 *
 * @author alulab14
 */
public class Pais {

    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id) {
        this.id = id;
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the cat
     */
    public int getCat() {
        return cat;
    }

    /**
     * @param cat the cat to set
     */
    public void setCat(int cat) {
        this.cat = cat;
    }

    /**
     * @return the grp
     */
    public char getGrp() {
        return grp;
    }

    /**
     * @param grp the grp to set
     */
    public void setGrp(char grp) {
        this.grp = grp;
    }

    /**
     * @return the pj
     */
    public int getPj() {
        return pj;
    }

    /**
     * @param pj the pj to set
     */
    public void setPj(int pj) {
        this.pj = pj;
    }

    /**
     * @return the pg
     */
    public int getPg() {
        return pg;
    }

    /**
     * @param pg the pg to set
     */
    public void setPg(int pg) {
        this.pg = pg;
    }

    /**
     * @return the pe
     */
    public int getPe() {
        return pe;
    }

    /**
     * @param pe the pe to set
     */
    public void setPe(int pe) {
        this.pe = pe;
    }

    /**
     * @return the pp
     */
    public int getPp() {
        return pp;
    }

    /**
     * @param pp the pp to set
     */
    public void setPp(int pp) {
        this.pp = pp;
    }

    /**
     * @return the gf
     */
    public int getGf() {
        return gf;
    }

    /**
     * @param gf the gf to set
     */
    public void setGf(int gf) {
        this.gf = gf;
    }

    /**
     * @return the gc
     */
    public int getGc() {
        return gc;
    }

    /**
     * @param gc the gc to set
     */
    public void setGc(int gc) {
        this.gc = gc;
    }

    /**
     * @return the df
     */
    public int getDf() {
        return df;
    }

    /**
     * @param df the df to set
     */
    public void setDf(int df) {
        this.df = df;
    }

    /**
     * @return the pts
     */
    public int getPts() {
        return pts;
    }

    /**
     * @param pts the pts to set
     */
    public void setPts(int pts) {
        this.pts = pts;
    }
    private int id;
    private String nombre;
    private int cat;
    private char grp;

    private int pj;
    private int pg;
    private int pe;
    private int pp;
    private int gf;
    private int gc;
    private int df;
    private int pts;

    public Pais() {
        pj=0;
        pg=0;
        pe=0;
        pp=0;
        gf=0;
        gc=0;
        df=0;
        pts=0;
    }
    
    
}
